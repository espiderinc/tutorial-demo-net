CREATE TABLE City (
    "CityID"          INT        NOT NULL,
    "CityName"        NCHAR (50) NOT NULL,
    "CityDescription" NCHAR (50) NOT NULL,
	"Country"		  NCHAR (50) Not NULL,
    CONSTRAINT "PK_City" PRIMARY KEY NONCLUSTERED ("CityID" ASC)
);
