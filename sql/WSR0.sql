CREATE DATABASE ws;

USE ws
GO

CREATE TABLE UserConfidentialInformation
(
	id			INT IDENTITY PRIMARY KEY,
	Username	VARCHAR	(150) NOT NULL,
	[Password]	NVARCHAR(150) NOT NULL
);

CREATE TABLE UserPersonalInformation
(
	id				INT IDENTITY PRIMARY KEY,
	Email			VARCHAR(150)	NOT NULL,
	[Password]	    NVARCHAR(150)	NOT NULL,
	[Name]			NVARCHAR(150)	NOT NULL,
	[Surname]		NVARCHAR(150)	NOT NULL,
	[Gender]		NVARCHAR(20)	NOT NULL,
	[Picture_name]	NVARCHAR(MAX)	NOT NULL,
	[Image]			IMAGE			NOT NULL,
	[Date]			DATE			NOT NULL,
	[County]		NVARCHAR(150)	NOT NULL
);

SELECT * FROM UserPersonalInformation

create table SponsorInformation
(
	id	INT IDENTITY PRIMARY KEY,
	Contribution		NVARCHAR(150) NOT NULL,
	Summ_Contribution	INT			  NOT NULL
);

SELECT * FROM SponsorInformation
