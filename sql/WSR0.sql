CREATE DATABASE WS;

USE db2
GO
-- ������� ���������������� �����������, �� ��� �� �������������
CREATE TABLE UserConfidentialInformation
(
	id INT IDENTITY PRIMARY KEY,
	[Username]	VARCHAR(150)	NOT NULL,
	[Password]	NVARCHAR(150)	NOT NULL
);
-- ������� ������������ ���������� ������� (�� ������ ������ �������� �������)
CREATE TABLE UserPersonalInformation
(
	id INT IDENTITY PRIMARY KEY,
	[Email]			VARCHAR(150)	NOT NULL,
	[Password]		NVARCHAR(150)	NOT NULL,
	[Name]			NVARCHAR(150)	NOT NULL,
	[Surname]		NVARCHAR(150)	NOT NULL,
	[Gender]		NVARCHAR(20)	NOT NULL,
	[Picture_name]	NVARCHAR(MAX)	NOT NULL,
	[Image]			IMAGE			NOT NULL,
	[Date]			DATE			NOT NULL,
	[County]		NVARCHAR(150)	NOT NULL
);

SELECT  UserPersonalInformation.Email, UserPersonalInformation.Password
FROM UserPersonalInformation
GO

-- ������� ���������
CREATE TABLE SponsorInformation
(
	id INT IDENTITY PRIMARY KEY,
	Contribution	  NVARCHAR(150) NOT NULL,
	Summ_Contribution INT			NOT NULL
);

SELECT * FROM SponsorInformation

-- ������� ��������������
CREATE TABLE Administration
(
	[Email]		VARCHAR(150)	NOT NULL,
	[Password]	VARCHAR(150)	NOT NULL,
	[Name]		NVARCHAR(150)	NOT NULL,
	[Surname]	NVARCHAR(150)	NOT NULL
)
GO

-- ������ ������������ ���� ������� 'Email'
ALTER TABLE Administration
ADD CONSTRAINT PK_Administration_Email PRIMARY KEY CLUSTERED (Email)
GO

-- ������ ����������� ������������ ������� Email
ALTER TABLE Administration
ADD CONSTRAINT DF_Administration_Email_Unique UNIQUE (Email)
GO

SELECT Administration.Email, Administration.Password
FROM Administration
GO