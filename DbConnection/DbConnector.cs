using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

using Npgsql;
using ServiceLib;
using TelineLib;

namespace DbConnection
{
    public enum ServerStatus
    {
        UNKNOWN = 0, CONNECTED = 1, ACCESS_DENIED = 2
    }

    public class DbConnector
    {
        private List<DbServer> serverList_ = new List<DbServer>();
        private NpgsqlConnection npgsqlConnection_;
        private int connectedServerIndex_ = -1;
        private NpgsqlCommand sqlCommand_ = new NpgsqlCommand();

        public int ConnectedServerIndex
        {
            get { return connectedServerIndex_; }
        }

        public string GetPgConnectionString(int serverIndex)
        {
            DbServer server = serverList_[serverIndex];
            //return String.Format("SERVER={0};Port={1};DATABASE=postgres;USER ID=postgres;PASSWORD={2};Encoding=UNICODE",
            //    server.Host, server.Port, server.Password);
            return String.Format("SERVER={0};Port={1};DATABASE=teline_db;USER ID=teline_app;PASSWORD={2}",
                server.Host, server.Port, server.Password);
        }

        #region Server command

        public void AddServer(DbServer server)
        {
            serverList_.Add(server);
        }

        public int GetServersCount()
        {
            return serverList_.Count;
        }

        public DbServer GetServer(int serverIndex)
        {
            return serverList_[serverIndex];
        }

        public void SetServer(DbServer server, int serverIndex)
        {
            serverList_[serverIndex] = server;
        }

        public void SetServerStatus(int serverIndex, ServerStatus status)
        {
            serverList_[serverIndex].Status = status;
        }

        public void SaveServerData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<DbServer>));

            foreach(DbServer server in serverList_)
            {
                if (!server.SavePassword)
                    server.Password = string.Empty;
                server.Status = ServerStatus.UNKNOWN;
            }

            using(StreamWriter sw = new StreamWriter("ServerList.xml"))
            {
                serializer.Serialize(sw, serverList_);
                sw.Close();
            }
        }

        public void LoadServerData()
        {
            if (!File.Exists("ServerList.xml"))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<DbServer>));

            using (StreamReader sr = new StreamReader("ServerList.xml"))
            {
                serverList_ = (List<DbServer>)serializer.Deserialize(sr);
                sr.Close();
            }
        }

        public bool ConnectToServer(int serverIndex)
        {
            if (connectedServerIndex_ != -1)
                DisconnectFromServer();
             
            //connectString_ = connectString_.Replace("localhost", "127.0.0.1");
            npgsqlConnection_ = new NpgsqlConnection(GetPgConnectionString(serverIndex));
            try { npgsqlConnection_.Open(); }
            catch (Exception ex)
            {
                connectedServerIndex_ = -1;
                TelineAppService.DumpException(ex, "Error connection to DB");
                return false;
            }
            sqlCommand_.Connection = npgsqlConnection_;
            connectedServerIndex_ = serverIndex;
            return true;
        }

        public void DisconnectFromServer()
        {
            if (connectedServerIndex_ == -1) 
                return;

            npgsqlConnection_.Close();
            serverList_[connectedServerIndex_].Status = ServerStatus.UNKNOWN;
            connectedServerIndex_ = -1;
        }

        #endregion

        #region Simple command

        public object ExecuteScalar(string commandText)
        {
            sqlCommand_.CommandText = commandText;
            try
            {
                return sqlCommand_.ExecuteScalar();
            }
            catch (Exception ex)
            {
                TelineAppService.DumpException(ex, "Error in ExecuteScalar():");
                return null;
            }
        }

        public int ExecuteNonQuery(string commandText)
        {
            sqlCommand_.CommandText = commandText;
            try
            {
                return sqlCommand_.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                TelineAppService.DumpException(ex, "Error in ExecuteNonQuery():");
                return -1;
            }
        }

        #endregion

        //public bool CreateAndFillDataAdapter(string queryText, string tableName, ref DataSet ds)
        //{
        //    try
        //    {
        //        NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryText, npgsqlConnection_);
        //        da.TableMappings.Add("Table", tableName);
        //        da.Fill(ds);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        TelineAppService.DumpException(ex, "Error in CreateAndFillDataAdapter():");
        //        return false;
        //    }
        //}

        public bool LoadTelineOsatData(ref List<TelineOsa> listOsat)
        {
            try
            {
                string query = "SELECT nimi, pituus, maara_nyt, minimimaara, laatikko, hinta  FROM public.telineosat;";
//                string query = 
// @"SELECT 
//    CASE WHEN pituus IS NULL 
//            THEN nimi 
//            ELSE CONCAT(nimi, ' ', pituus, ' m') 
//    END AS koko_nimi,
//	maara_nyt, minimimaara, laatikko, hinta
//FROM public.telineosat;";
                NpgsqlCommand command = new NpgsqlCommand(query, npgsqlConnection_);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                listOsat.Clear();
                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        string nimi = dataReader[(int)TelineOsaIndex.NIMI].ToString();
                        string strPituus = dataReader[(int)TelineOsaIndex.PITUUS].ToString();
                        string strMaaraVarastossa = dataReader[(int)TelineOsaIndex.MAARA_VARASTOSSA].ToString();
                        string strMinMaara = dataReader[(int)TelineOsaIndex.MIN_MAARA].ToString();
                        string laatikko = dataReader[(int)TelineOsaIndex.LAATIKKO].ToString();
                        string strHinta = dataReader[(int)TelineOsaIndex.HINTA].ToString();

                        if (!float.TryParse(strPituus, out float pituus))
                            pituus = -1;
                        if (!float.TryParse(strHinta, out float hinta))
                            hinta = -1;

                        if (!int.TryParse(strMaaraVarastossa, out int maara))
                            maara = -1;
                        if (!int.TryParse(strMinMaara, out int minMaara))
                            minMaara = -1;

                        listOsat.Add(new TelineOsa(nimi, pituus, maara, minMaara, laatikko, hinta));
                    }
                }
                dataReader.Close();
                return true;
            }
            catch (Exception ex)
            {
                TelineAppService.DumpException(ex, "Error in DbConnector::LoadTelineOsatData():");
                return false;
            }
        }

        public bool LoadTyomaatData(ref List<Tyomaa> listTyomaat)
        {
            try
            {
                string query =
 @"SELECT t1.id, t1.nimi, t1.osoite, t1.yhteyshenkilo, t1.puhelin, SUM(t2.maara_lahetetty) AS maara
  FROM public.tyomaat AS t1 INNER JOIN public.osattyomaittain AS t2 
  ON t1.id = t2.id_tyomaa AND t2.palautettu = FALSE
  GROUP BY t1.id, t1.nimi, t1.osoite, t1.yhteyshenkilo, t1.puhelin;";
                NpgsqlCommand command = new NpgsqlCommand(query, npgsqlConnection_);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                listTyomaat.Clear();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string strId = dataReader[(int)TyomaaIndex.ID].ToString();
                        string nimi = dataReader[(int)TyomaaIndex.NIMI].ToString();
                        string osoite = dataReader[(int)TyomaaIndex.OSOITE].ToString();
                        string yhteyshenkilo = dataReader[(int)TyomaaIndex.YHTEYSHENKILO].ToString();
                        string puhelin = dataReader[(int)TyomaaIndex.PUHELIN].ToString();
                        string strMaaraYhteensa = dataReader[(int)TyomaaIndex.MAARA_YHTEENSA].ToString();

                        if (!int.TryParse(strMaaraYhteensa, out int id))
                            id = -1;
                        if (!int.TryParse(strMaaraYhteensa, out int maara))
                            maara = -1;

                        listTyomaat.Add(new Tyomaa(id, nimi, osoite, yhteyshenkilo, puhelin, maara));
                    }
                }
                dataReader.Close();
                return true;
            }
            catch (Exception ex)
            {
                TelineAppService.DumpException(ex, "Error in DbConnector::LoadTyomaatData():");
                return false;
            }
        }

        public bool AddUusiOsa(string nimi, float pituus, int maaraVarastossa, int minMaara, string laatikko, float hinta)
        {
            string query = string.Format("INSERT INTO public.telineosat(nimi, pituus, maara_nyt, minimimaara, laatikko, hinta) VALUES('{0}', {1}, {2}, {3}, '{4}', {5});",
                nimi,
                pituus > 0 ? pituus.ToString() : "NULL",
                maaraVarastossa,
                minMaara,
                laatikko.ToString().Length > 0 ? laatikko : "NULL",
                hinta > 0 ? hinta.ToString() : "NULL"
                );

            int res = this.ExecuteNonQuery(query);
            if (res < 1)
                return false;
            return true;
        }
    }
}
