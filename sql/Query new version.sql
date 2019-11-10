USE db4
GO
-- рюакхжю йнмтхдемжхюкэмни хмтнплюжхх
CREATE TABLE [UserConfidentialInformation]
(
	[UserId]	INT IDENTITY (1, 1),
	[Username]	VARCHAR	(150) NOT NULL,
	[Password]	NVARCHAR(150) NOT NULL
);
-- днаюбхл нцпюмхвемхъ ярнкажс [UserName]
ALTER TABLE [UserConfidentialInformation]
ADD CONSTRAINT DF_UserConfidentialInformation_Username_Unique UNIQUE (Username)
GO

SELECT * FROM [UserConfidentialInformation]
-- ядекюел мюь юррпхаср ясппнцюрмшл йкчвнл
ALTER TABLE [UserConfidentialInformation]
ADD CONSTRAINT PK_UserConfidentialInformation_UserId PRIMARY KEY CLUSTERED (UserId)
GO
-- рюакхжю кхвмни хмтнплюжхх аецсмю
CREATE TABLE [UserPersonalInformation]
(
	[Email]			VARCHAR(150)	NOT NULL,
	[Name]			NVARCHAR(150)	NOT NULL,
	[Surname]		NVARCHAR(150)	NOT NULL,
	[Gender]		NVARCHAR(20)	NOT NULL,
	[Picture_name]	NVARCHAR(MAX)	NOT NULL,
	[Image]			IMAGE			NOT NULL,
	[Date]			DATE			NOT NULL,
	[County]		NVARCHAR(150)	NOT NULL
);
-- рюй фе днаюбхл нцпюмхвемхе смхйюкэмнярх дкъ ярнкажю Email
ALTER TABLE [UserPersonalInformation]
ADD CONSTRAINT DF_UserPersonalInformation_Email_Unique UNIQUE (Email)
GO

-- ядекюел ярнкаеж Email оепбхвмшл йкчвнл
ALTER TABLE [UserPersonalInformation]
ADD CONSTRAINT PK_UserPersonalInformation_Email PRIMARY KEY CLUSTERED (Email)
GO

-- яяшкйх цнрнбш, мюдн ябъгюрэ рюакхжш
ALTER TABLE UserConfidentialInformation
WITH CHECK ADD CONSTRAINT FK_UserConfidentialInformation_UserPersonalInformation FOREIGN KEY (Username)
REFERENCES [UserPersonalInformation] (Email)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

SELECT * FROM UserPersonalInformation

-- рюакхжю яонмянпнб
create table SponsorInformation
(
	id	INT IDENTITY PRIMARY KEY,
	Contribution		NVARCHAR(150) NOT NULL,
	Summ_Contribution	INT			  NOT NULL
);

SELECT * FROM SponsorInformation