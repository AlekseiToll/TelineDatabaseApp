CREATE TABLE "tyomaat"(
    "id" serial PRIMARY KEY,
    "nimi" VARCHAR(255) NOT NULL,
    "osoite" VARCHAR(255) NOT NULL,
	"yhteyshenkilo" VARCHAR(255) NOT NULL,
	"puhelin" VARCHAR(20) NOT NULL
);

CREATE TABLE "osattyomaittain"(
    "id_tilaus" serial PRIMARY KEY,
    "id_osa" BIGINT NOT NULL,
    "id_tyomaa" BIGINT NOT NULL,
    "maara_lahetetty" BIGINT NOT NULL,
    "lahetys_pvm" DATE NOT NULL,
    "palautettu" BOOLEAN NOT NULL,
    "palautus_pvm" DATE NULL,
    "maara_palautettu" BIGINT NULL,
    "rikkiosat" BIGINT NULL
);

CREATE INDEX "osattyomaittain_id_osa_index" ON
    "osattyomaittain"("id_osa");
CREATE INDEX "osattyomaittain_id_tyomaa_index" ON
    "osattyomaittain"("id_tyomaa");
COMMENT
ON COLUMN
    "osattyomaittain"."lahetys_pvm" IS 'pvm kun osat oli lahetetty varastosta tyomaalle';
COMMENT
ON COLUMN
    "osattyomaittain"."palautettu" IS 'Oliko osat palautettu';
COMMENT
ON COLUMN
    "osattyomaittain"."palautus_pvm" IS 'Milloin osat oli palautettu varastolle (jos oli)';
COMMENT
ON COLUMN
    "osattyomaittain"."rikkiosat" IS 'Palautettujen rikkinaisten osien maara';
	
	
CREATE TABLE "telineosat"(
    "id" serial PRIMARY KEY,
    "nimi" VARCHAR(50) NOT NULL,
    "pituus" DOUBLE PRECISION NULL,
    "maara_nyt" BIGINT NOT NULL,
    "minimimaara" BIGINT NOT NULL,
    "laatikko" VARCHAR(50) NULL,
    "hinta" DOUBLE PRECISION NULL
);

COMMENT
ON COLUMN
    "telineosat"."maara_nyt" IS 'Nykyinen maara varastossa';
CREATE TABLE "telineosakuvaukset"(
    "id_osa" BIGINT NOT NULL,
    "kuvaus" TEXT NOT NULL,
    "kuva" bytea NOT NULL
);
CREATE INDEX "telineosakuvaukset_id_osa_index" ON
    "telineosakuvaukset"("id_osa");
ALTER TABLE
    "osattyomaittain" ADD CONSTRAINT "osattyomaittain_id_osa_foreign" FOREIGN KEY("id_osa") REFERENCES "telineosat"("id");
ALTER TABLE
    "osattyomaittain" ADD CONSTRAINT "osattyomaittain_id_tyomaa_foreign" FOREIGN KEY("id_tyomaa") REFERENCES "tyomaat"("id");
ALTER TABLE
    "telineosakuvaukset" ADD CONSTRAINT "telineosakuvaukset_id_osa_foreign" FOREIGN KEY("id_osa") REFERENCES "telineosat"("id");



CREATE ROLE teline_app WITH
	LOGIN
	NOSUPERUSER
	NOCREATEDB
	NOCREATEROLE
	INHERIT
	REPLICATION
	CONNECTION LIMIT -1
	PASSWORD 'teline';   