using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib
{
	public class TelineAppService
	{
		private static string currentDirectory_;
		public static string logDebugName;
		public static string logFailedName;

		private static object logDebugLock_ = new object();
		private static object logFailedLock_ = new object();

		public static string GetBoolDBValueAsString(object obj)
		{
			try
			{
				if (obj is System.DBNull) return "null";
				if (obj.ToString().Equals("null")) return "null";

				return ((bool)obj).ToString();
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetBoolDBValue(): " + obj.ToString());
				return "null";
			}
		}

		public static string GetFloatDBValueAsString(object obj)
		{
			try
			{
				if (obj is System.DBNull) return "null";
				if (obj.ToString().Equals("null")) return "null";

				return ((float)obj).ToString(new System.Globalization.CultureInfo("en-US"));
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetFloatDBValue(): " + obj.ToString());
				return "null";
			}
		}

		public static string GetIntDBValueAsString(object obj)
		{
			try
			{
				if (obj is System.DBNull) return "null";
				if (obj.ToString().Equals("null")) return "null";

				return ((int)obj).ToString();
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetIntDBValue(): " + obj.ToString());
				return "null";
			}
		}

		public static string GetStringDBValue(object obj)
		{
			try
			{
				if (obj is System.DBNull) return "null";
				if (obj.ToString().Equals("null")) return "null";

				return (string)obj;
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetStringDBValue(): " + obj.ToString());
				return "null";
			}
		}

		public static float GetFloatDBValue(object obj)
		{
			try
			{
				if (obj is System.DBNull) return 0;
				if (obj.ToString().Equals("null")) return 0;

				return (float)obj;
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetFloatDBValue(): " + obj.ToString());
				return 0;
			}
		}

		public static double GetDoubleDBValue(object obj)
		{
			try
			{
				if (obj is System.DBNull) return 0;
				if (obj.ToString().Equals("null")) return 0;

				return (double)obj;
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetDoubleDBValue(): " + obj.ToString());
				return 0;
			}
		}

		public static int GetIntDBValue(object obj)
		{
			try
			{
				if (obj is System.DBNull) return 0;
				if (obj.ToString().Equals("null")) return 0;

				return (int)obj;
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetIntDBValue(): " + obj.ToString());
				return 0;
			}
		}

		public static short GetShortDBValue(object obj)
		{
			try
			{
				if (obj is System.DBNull) return 0;
				if (obj.ToString().Equals("null")) return 0;

				return (short)obj;
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetShortDBValue(): " + obj.ToString());
				return 0;
			}
		}

		public static bool GetBoolDBValue(object obj)
		{
			try
			{
				if (obj is System.DBNull) return false;
				if (obj.ToString().Equals("null")) return false;

				return (bool)obj;
			}
			catch (Exception ex)
			{
				TelineAppService.DumpException(ex, "Error in GetBoolDBValue(): " + obj.ToString());
				return false;
			}
		}

		public static void Init()
		{
			currentDirectory_ = System.AppDomain.CurrentDomain.BaseDirectory;

			logDebugName = currentDirectory_ + "LogDebug.txt";
			logFailedName = currentDirectory_ + "LogFailed.txt";

			try
			{
				if (File.Exists(logFailedName))
					File.Delete(logFailedName);
				if (File.Exists(logDebugName))
					File.Delete(logDebugName);
			}
			catch (Exception)
			{
			}
		}

		public static void WriteToLogDebug(string s)
		{
			StreamWriter sw = null;
			try
			{
				System.Diagnostics.Debug.WriteLine(s);
				lock (logDebugLock_)
				{
					try
					{
						sw = new StreamWriter(logDebugName, true);
						sw.WriteLine(s);
					}
					finally
					{
						if (sw != null) sw.Close();
					}
				}
			}
			catch (IOException)
			{
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error in WriteToLogDebug() " + ex.Message);
				throw;
			}
		}

		public static void WriteToLogDebugToSameString(string s)
		{
			StreamWriter sw = null;
			try
			{
				s += " | ";
				System.Diagnostics.Debug.Write(s);
				lock (logDebugLock_)
				{
					try
					{
						sw = new StreamWriter(logDebugName, true);
						sw.Write(s);
					}
					finally
					{
						if (sw != null) sw.Close();
					}
				}
			}
			catch (IOException)
			{
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error in WriteToLogDebug() " + ex.Message);
				throw;
			}
		}

		public static void WriteBytesToLogDebug(List<byte> bytes)
		{
			StreamWriter sw = null;
			try
			{
				string s = "\n";
				for (int i = 0; i < bytes.Count; ++i)
				{
					//s += bytes[i].ToString() + " | ";
					s += bytes[i].ToString() + "\n";
				}
				System.Diagnostics.Debug.Write(s);
				s += "\n";
				lock (logDebugLock_)
				{
					try
					{
						sw = new StreamWriter(logDebugName, true);
						sw.Write(s);
					}
					finally
					{
						if (sw != null) sw.Close();
					}
				}
			}
			catch (IOException)
			{
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error in WriteToLogDebug() " + ex.Message);
				throw;
			}
		}

		// аварийный лог
		public static void WriteToLogFailed(string s)
		{
			StreamWriter sw = null;

			try
			{
				System.Diagnostics.Debug.WriteLine(s);
				lock (logFailedLock_)
				{
					try
					{
						sw = new StreamWriter(logFailedName, true);

						sw.WriteLine("=======================================");
						sw.WriteLine(DateTime.Now);
						sw.WriteLine(s);
						sw.WriteLine("=======================================");
					}
					finally
					{
						if (sw != null) sw.Close();
					}
				}
			}
			catch (IOException)
			{
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error in WriteToLogFailed() " + ex.Message);
				throw;
			}
		}

		public static void DumpException(Exception ex, string info)
		{
			StreamWriter sw = null;

			try
			{
				lock (logFailedLock_)
				{
					try
					{
						sw = new StreamWriter(logFailedName, true);
						sw.WriteLine("Exception at " + DateTime.Now.ToString());

						sw.WriteLine(info);
						System.Diagnostics.Debug.WriteLine(info);

						System.Diagnostics.Debug.WriteLine("--------- Outer Exception Data ---------");
						sw.WriteLine("========= Exception Dump ===============");
						sw.WriteLine("--------- Outer Exception Data ---------");
						WriteExceptionInfo(ex, ref sw);

						ex = ex.InnerException;
						while (ex != null)
						{
							System.Diagnostics.Debug.WriteLine("--------- Inner Exception Data ---------");
							sw.WriteLine("--------- Inner Exception Data ---------");
							WriteExceptionInfo(ex, ref sw);
							ex = ex.InnerException;
						}
						sw.WriteLine("========= end of Exception Dump ========");
					}
					finally
					{
						if (sw != null) sw.Close();
					}
				}
			}
			catch (IOException)
			{
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine("Error in DumpException() " + e.Message);
				throw e;
			}
		}

		public static void WriteExceptionInfo(Exception ex, ref StreamWriter sw)
		{
			System.Diagnostics.Debug.WriteLine("\nMessage: {0}", ex.Message);
			sw.WriteLine("\nMessage: {0}", ex.Message);
			System.Diagnostics.Debug.WriteLine("\nException Type: {0}", ex.GetType().FullName);
			sw.WriteLine("\nException Type: {0}", ex.GetType().FullName);
			System.Diagnostics.Debug.WriteLine("\nSource: {0}", ex.Source);
			sw.WriteLine("\nSource: {0}", ex.Source);
			System.Diagnostics.Debug.WriteLine("\nStrackTrace: {0}", ex.StackTrace);
			sw.WriteLine("\nStrackTrace: {0}", ex.StackTrace);
			System.Diagnostics.Debug.WriteLine("\nTargetSite: {0}", ex.TargetSite.ToString());
			sw.WriteLine("\nTargetSite: {0}", ex.TargetSite);
		}

		public static string AppDirectory
		{
			get
			{
				return currentDirectory_;
			}
		}
	}
}
