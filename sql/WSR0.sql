create database WS;

use WS
go

create table UserConfidentialInformation
(
	id int identity primary key,
	Username varchar(150) not null,
	[Password] nvarchar(150) not null
);

create table UserPersonalInformation
(
	id int identity primary key,
	Email varchar(150) not null,
	[Password] nvarchar(150) not null,
	[Name] nvarchar(150) not null,
	[Surname] nvarchar(150) not null,
	[Gender] nvarchar(20) not null,
	[Picture_name] nvarchar(max) not null,
	[Image] image not null,
	[Date] date not null,
	[County] nvarchar(150) not null
);

select * from UserPersonalInformation

create table SponsorInformation
(
	id int identity primary key,
	Contribution nvarchar(150) not null,
	Summ_Contribution int not null
);

select * from SponsorInformation