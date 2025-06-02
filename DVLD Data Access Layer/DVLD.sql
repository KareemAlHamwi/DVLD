CREATE DATABASE dbDVLD_Copy

--* to make db diagram work
-- USE db 
-- GO 
-- ALTER DATABASE db set TRUSTWORTHY ON; 
-- GO 
-- EXEC dbo.sp_changedbowner @loginame = N'sa', @map = false 
-- GO 
-- sp_configure 'show advanced options', 1; 
-- GO 
-- RECONFIGURE; 
-- GO 
-- sp_configure 'clr enabled', 1; 
-- GO 
-- RECONFIGURE; 
-- GO

CREATE TABLE People (
    PersonID INT IDENTITY(1000,1),
    NationalNo VARCHAR(20) NOT NULL,
    FirstName VARCHAR(20) NOT NULL,
    SecondName VARCHAR(20) NOT NULL,
    ThirdName VARCHAR(20),
    LastName VARCHAR(20) NOT NULL,
    Birthdate DATETIME NOT NULL,
    Gender TINYINT NOT NULL,
    Address VARCHAR(500) NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    Email VARCHAR(50),
    NationalityCountryID INT NOT NULL,
    ImagePath VARCHAR(250)
    PRIMARY KEY (PersonID)
);

CREATE TABLE Countries (
  CountryID INT IDENTITY(1,1),
  CountryName VARCHAR(50)
  PRIMARY KEY (CountryID)
);

INSERT INTO Countries (CountryName) VALUES ('Afghanistan');
INSERT INTO Countries (CountryName) VALUES ('Albania');
INSERT INTO Countries (CountryName) VALUES ('Algeria');
INSERT INTO Countries (CountryName) VALUES ('Andorra');
INSERT INTO Countries (CountryName) VALUES ('Angola');
INSERT INTO Countries (CountryName) VALUES ('Antigua and Barbuda');
INSERT INTO Countries (CountryName) VALUES ('Argentina');
INSERT INTO Countries (CountryName) VALUES ('Armenia');
INSERT INTO Countries (CountryName) VALUES ('Australia');
INSERT INTO Countries (CountryName) VALUES ('Austria');
INSERT INTO Countries (CountryName) VALUES ('Azerbaijan');
INSERT INTO Countries (CountryName) VALUES ('Bahamas');
INSERT INTO Countries (CountryName) VALUES ('Bahrain');
INSERT INTO Countries (CountryName) VALUES ('Bangladesh');
INSERT INTO Countries (CountryName) VALUES ('Barbados');
INSERT INTO Countries (CountryName) VALUES ('Belarus');
INSERT INTO Countries (CountryName) VALUES ('Belgium');
INSERT INTO Countries (CountryName) VALUES ('Belize');
INSERT INTO Countries (CountryName) VALUES ('Benin');
INSERT INTO Countries (CountryName) VALUES ('Bhutan');
INSERT INTO Countries (CountryName) VALUES ('Bolivia');
INSERT INTO Countries (CountryName) VALUES ('Bosnia and Herzegovina');
INSERT INTO Countries (CountryName) VALUES ('Botswana');
INSERT INTO Countries (CountryName) VALUES ('Brazil');
INSERT INTO Countries (CountryName) VALUES ('Brunei');
INSERT INTO Countries (CountryName) VALUES ('Bulgaria');
INSERT INTO Countries (CountryName) VALUES ('Burkina Faso');
INSERT INTO Countries (CountryName) VALUES ('Burundi');
INSERT INTO Countries (CountryName) VALUES ('Cabo Verde');
INSERT INTO Countries (CountryName) VALUES ('Cambodia');
INSERT INTO Countries (CountryName) VALUES ('Cameroon');
INSERT INTO Countries (CountryName) VALUES ('Canada');
INSERT INTO Countries (CountryName) VALUES ('Central African Republic');
INSERT INTO Countries (CountryName) VALUES ('Chad');
INSERT INTO Countries (CountryName) VALUES ('Chile');
INSERT INTO Countries (CountryName) VALUES ('China');
INSERT INTO Countries (CountryName) VALUES ('Colombia');
INSERT INTO Countries (CountryName) VALUES ('Comoros');
INSERT INTO Countries (CountryName) VALUES ('Congo (Congo-Brazzaville)');
INSERT INTO Countries (CountryName) VALUES ('Costa Rica');
INSERT INTO Countries (CountryName) VALUES ('Croatia');
INSERT INTO Countries (CountryName) VALUES ('Cuba');
INSERT INTO Countries (CountryName) VALUES ('Cyprus');
INSERT INTO Countries (CountryName) VALUES ('Czech Republic (Czechia)');
INSERT INTO Countries (CountryName) VALUES ('Democratic Republic of the Congo');
INSERT INTO Countries (CountryName) VALUES ('Denmark');
INSERT INTO Countries (CountryName) VALUES ('Djibouti');
INSERT INTO Countries (CountryName) VALUES ('Dominica');
INSERT INTO Countries (CountryName) VALUES ('Dominican Republic');
INSERT INTO Countries (CountryName) VALUES ('Ecuador');
INSERT INTO Countries (CountryName) VALUES ('Egypt');
INSERT INTO Countries (CountryName) VALUES ('El Salvador');
INSERT INTO Countries (CountryName) VALUES ('Equatorial Guinea');
INSERT INTO Countries (CountryName) VALUES ('Eritrea');
INSERT INTO Countries (CountryName) VALUES ('Estonia');
INSERT INTO Countries (CountryName) VALUES ('Eswatini');
INSERT INTO Countries (CountryName) VALUES ('Ethiopia');
INSERT INTO Countries (CountryName) VALUES ('Fiji');
INSERT INTO Countries (CountryName) VALUES ('Finland');
INSERT INTO Countries (CountryName) VALUES ('France');
INSERT INTO Countries (CountryName) VALUES ('Gabon');
INSERT INTO Countries (CountryName) VALUES ('Gambia');
INSERT INTO Countries (CountryName) VALUES ('Georgia');
INSERT INTO Countries (CountryName) VALUES ('Germany');
INSERT INTO Countries (CountryName) VALUES ('Ghana');
INSERT INTO Countries (CountryName) VALUES ('Greece');
INSERT INTO Countries (CountryName) VALUES ('Grenada');
INSERT INTO Countries (CountryName) VALUES ('Guatemala');
INSERT INTO Countries (CountryName) VALUES ('Guinea');
INSERT INTO Countries (CountryName) VALUES ('Guinea-Bissau');
INSERT INTO Countries (CountryName) VALUES ('Guyana');
INSERT INTO Countries (CountryName) VALUES ('Haiti');
INSERT INTO Countries (CountryName) VALUES ('Honduras');
INSERT INTO Countries (CountryName) VALUES ('Hungary');
INSERT INTO Countries (CountryName) VALUES ('Iceland');
INSERT INTO Countries (CountryName) VALUES ('India');
INSERT INTO Countries (CountryName) VALUES ('Indonesia');
INSERT INTO Countries (CountryName) VALUES ('Iran');
INSERT INTO Countries (CountryName) VALUES ('Iraq');
INSERT INTO Countries (CountryName) VALUES ('Ireland');
INSERT INTO Countries (CountryName) VALUES ('Israel');
INSERT INTO Countries (CountryName) VALUES ('Italy');
INSERT INTO Countries (CountryName) VALUES ('Jamaica');
INSERT INTO Countries (CountryName) VALUES ('Japan');
INSERT INTO Countries (CountryName) VALUES ('Jordan');
INSERT INTO Countries (CountryName) VALUES ('Kazakhstan');
INSERT INTO Countries (CountryName) VALUES ('Kenya');
INSERT INTO Countries (CountryName) VALUES ('Kiribati');
INSERT INTO Countries (CountryName) VALUES ('Kuwait');
INSERT INTO Countries (CountryName) VALUES ('Kyrgyzstan');
INSERT INTO Countries (CountryName) VALUES ('Laos');
INSERT INTO Countries (CountryName) VALUES ('Latvia');
INSERT INTO Countries (CountryName) VALUES ('Lebanon');
INSERT INTO Countries (CountryName) VALUES ('Lesotho');
INSERT INTO Countries (CountryName) VALUES ('Liberia');
INSERT INTO Countries (CountryName) VALUES ('Libya');
INSERT INTO Countries (CountryName) VALUES ('Liechtenstein');
INSERT INTO Countries (CountryName) VALUES ('Lithuania');
INSERT INTO Countries (CountryName) VALUES ('Luxembourg');
INSERT INTO Countries (CountryName) VALUES ('Madagascar');
INSERT INTO Countries (CountryName) VALUES ('Malawi');
INSERT INTO Countries (CountryName) VALUES ('Malaysia');
INSERT INTO Countries (CountryName) VALUES ('Maldives');
INSERT INTO Countries (CountryName) VALUES ('Mali');
INSERT INTO Countries (CountryName) VALUES ('Malta');
INSERT INTO Countries (CountryName) VALUES ('Marshall Islands');
INSERT INTO Countries (CountryName) VALUES ('Mauritania');
INSERT INTO Countries (CountryName) VALUES ('Mauritius');
INSERT INTO Countries (CountryName) VALUES ('Mexico');
INSERT INTO Countries (CountryName) VALUES ('Micronesia');
INSERT INTO Countries (CountryName) VALUES ('Moldova');
INSERT INTO Countries (CountryName) VALUES ('Monaco');
INSERT INTO Countries (CountryName) VALUES ('Mongolia');
INSERT INTO Countries (CountryName) VALUES ('Montenegro');
INSERT INTO Countries (CountryName) VALUES ('Morocco');
INSERT INTO Countries (CountryName) VALUES ('Mozambique');
INSERT INTO Countries (CountryName) VALUES ('Myanmar');
INSERT INTO Countries (CountryName) VALUES ('Namibia');
INSERT INTO Countries (CountryName) VALUES ('Nauru');
INSERT INTO Countries (CountryName) VALUES ('Nepal');
INSERT INTO Countries (CountryName) VALUES ('Netherlands');
INSERT INTO Countries (CountryName) VALUES ('New Zealand');
INSERT INTO Countries (CountryName) VALUES ('Nicaragua');
INSERT INTO Countries (CountryName) VALUES ('Niger');
INSERT INTO Countries (CountryName) VALUES ('Nigeria');
INSERT INTO Countries (CountryName) VALUES ('North Korea');
INSERT INTO Countries (CountryName) VALUES ('North Macedonia');
INSERT INTO Countries (CountryName) VALUES ('Norway');
INSERT INTO Countries (CountryName) VALUES ('Oman');
INSERT INTO Countries (CountryName) VALUES ('Pakistan');
INSERT INTO Countries (CountryName) VALUES ('Palau');
INSERT INTO Countries (CountryName) VALUES ('Palestine State');
INSERT INTO Countries (CountryName) VALUES ('Panama');
INSERT INTO Countries (CountryName) VALUES ('Papua New Guinea');
INSERT INTO Countries (CountryName) VALUES ('Paraguay');
INSERT INTO Countries (CountryName) VALUES ('Peru');
INSERT INTO Countries (CountryName) VALUES ('Philippines');
INSERT INTO Countries (CountryName) VALUES ('Poland');
INSERT INTO Countries (CountryName) VALUES ('Portugal');
INSERT INTO Countries (CountryName) VALUES ('Qatar');
INSERT INTO Countries (CountryName) VALUES ('Romania');
INSERT INTO Countries (CountryName) VALUES ('Russia');
INSERT INTO Countries (CountryName) VALUES ('Rwanda');
INSERT INTO Countries (CountryName) VALUES ('Saint Kitts and Nevis');
INSERT INTO Countries (CountryName) VALUES ('Saint Lucia');
INSERT INTO Countries (CountryName) VALUES ('Saint Vincent and the Grenadines');
INSERT INTO Countries (CountryName) VALUES ('Samoa');
INSERT INTO Countries (CountryName) VALUES ('San Marino');
INSERT INTO Countries (CountryName) VALUES ('Sao Tome and Principe');
INSERT INTO Countries (CountryName) VALUES ('Saudi Arabia');
INSERT INTO Countries (CountryName) VALUES ('Senegal');
INSERT INTO Countries (CountryName) VALUES ('Serbia');
INSERT INTO Countries (CountryName) VALUES ('Seychelles');
INSERT INTO Countries (CountryName) VALUES ('Sierra Leone');
INSERT INTO Countries (CountryName) VALUES ('Singapore');
INSERT INTO Countries (CountryName) VALUES ('Slovakia');
INSERT INTO Countries (CountryName) VALUES ('Slovenia');
INSERT INTO Countries (CountryName) VALUES ('Solomon Islands');
INSERT INTO Countries (CountryName) VALUES ('Somalia');
INSERT INTO Countries (CountryName) VALUES ('South Africa');
INSERT INTO Countries (CountryName) VALUES ('South Korea');
INSERT INTO Countries (CountryName) VALUES ('South Sudan');
INSERT INTO Countries (CountryName) VALUES ('Spain');
INSERT INTO Countries (CountryName) VALUES ('Sri Lanka');
INSERT INTO Countries (CountryName) VALUES ('Sudan');
INSERT INTO Countries (CountryName) VALUES ('Suriname');
INSERT INTO Countries (CountryName) VALUES ('Sweden');
INSERT INTO Countries (CountryName) VALUES ('Switzerland');
INSERT INTO Countries (CountryName) VALUES ('Syria');
INSERT INTO Countries (CountryName) VALUES ('Tajikistan');
INSERT INTO Countries (CountryName) VALUES ('Tanzania');
INSERT INTO Countries (CountryName) VALUES ('Thailand');
INSERT INTO Countries (CountryName) VALUES ('Timor-Leste');
INSERT INTO Countries (CountryName) VALUES ('Togo');
INSERT INTO Countries (CountryName) VALUES ('Tonga');
INSERT INTO Countries (CountryName) VALUES ('Trinidad and Tobago');
INSERT INTO Countries (CountryName) VALUES ('Tunisia');
INSERT INTO Countries (CountryName) VALUES ('Turkey');
INSERT INTO Countries (CountryName) VALUES ('Turkmenistan');
INSERT INTO Countries (CountryName) VALUES ('Tuvalu');
INSERT INTO Countries (CountryName) VALUES ('Uganda');
INSERT INTO Countries (CountryName) VALUES ('Ukraine');
INSERT INTO Countries (CountryName) VALUES ('United Arab Emirates');
INSERT INTO Countries (CountryName) VALUES ('United Kingdom');
INSERT INTO Countries (CountryName) VALUES ('United States of America');
INSERT INTO Countries (CountryName) VALUES ('Uruguay');
INSERT INTO Countries (CountryName) VALUES ('Uzbekistan');
INSERT INTO Countries (CountryName) VALUES ('Vanuatu');
INSERT INTO Countries (CountryName) VALUES ('Vatican City');
INSERT INTO Countries (CountryName) VALUES ('Venezuela');
INSERT INTO Countries (CountryName) VALUES ('Vietnam');
INSERT INTO Countries (CountryName) VALUES ('Yemen');
INSERT INTO Countries (CountryName) VALUES ('Zambia');
INSERT INTO Countries (CountryName) VALUES ('Zimbabwe');
INSERT INTO Countries (CountryName) VALUES ('Kosovo');

SELECT * from Countries

INSERT INTO People
(NationalNo,FirstName,SecondName,ThirdName,LastName,Birthdate,Gender,Address,Phone,Email,NationalityCountryID) VALUES
('05050181863','Kareem','Mazhar','Hussein','Al-Hamwi',05/22/2004,0,'Rif Dimashq - Jdaydet Artuz','0982700331','kalhamwilol@gmail.com',169);

SELECT FirstName,CountryName from People
LEFT JOIN Countries on People.NationalityCountryID = Countries.CountryID

CREATE TABLE Users (
  UserID INT IDENTITY(100,1),
  PersonID INT NOT NULL,
  Username VARCHAR(20) UNIQUE NOT NULL,
  Password VARCHAR(20) NOT NULL,
  IsActive BIT NOT NULL
  PRIMARY KEY (UserID)
);

INSERT INTO Users
(PersonID,Username,[Password],IsActive) VALUES
(1000,'Kareem','123',1)

SELECT Username , FirstName + ' ' + SecondName + ' ' + LastName AS 'Full Name' FROM Users
LEFT JOIN People ON Users.PersonID = People.PersonID

CREATE TABLE Applications (
  ApplicationID INT IDENTITY(2000,1),
  ApplicationPersonID INT NOT NULL,
  ApplicationDate DATETIME NOT NULL,
  ApplicationTypeID INT NOT NULL,
  ApplicationStatus TINYINT NOT NULL,
  LastStatusDate DATETIME NOT NULL,
  PaidFees SMALLMONEY NOT NULL,
  CreatedByUser INT NOT NULL
  PRIMARY KEY (ApplicationID)
);

CREATE TABLE ApplicationTypes (
  ApplicationTypeID INT IDENTITY(1,1),
  ApplicationTypeTitle VARCHAR(50) NOT NULL,
  ApplicationFees DECIMAL NOT NULL
  PRIMARY KEY (ApplicationTypeID)
);

INSERT INTO ApplicationTypes
(ApplicationTypeTitle,ApplicationFees) VALUES
('New Local Driving License Service',15)
INSERT INTO ApplicationTypes
(ApplicationTypeTitle,ApplicationFees) VALUES
('Renew Driving License Service',5)
INSERT INTO ApplicationTypes
(ApplicationTypeTitle,ApplicationFees) VALUES
('Replacement for a Lost Driving License',10)
INSERT INTO ApplicationTypes
(ApplicationTypeTitle,ApplicationFees) VALUES
('Replacement for a Damaged Driving License',5)
INSERT INTO ApplicationTypes
(ApplicationTypeTitle,ApplicationFees) VALUES
('Release Detained Driving License',15)
INSERT INTO ApplicationTypes
(ApplicationTypeTitle,ApplicationFees) VALUES
('New International License',100)

SELECT * FROM ApplicationTypes

CREATE TABLE LocalDrivingLicenseApplications (
  LocalDrivingLicenseApplicationID INT IDENTITY(3000,1),
  ApplicationID INT NOT NULL,
  LicenseClassID INT NOT NULL,
  PRIMARY KEY (LocalDrivingLicenseApplicationID)
);

CREATE TABLE LicenseClasses (
  LicenseClassID INT IDENTITY(1,1),
  ClassName VARCHAR(50),
  ClassDescription VARCHAR(500),
  MinimumAllowedAge TINYINT,
  DefaultValidityLength TINYINT,
  ClassFees SMALLMONEY
  PRIMARY KEY (LicenseClassID)
);

INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 1 - Small Motorcycle','It allows the driver to drive small motorcycles, It is suitable for motorcycles with small capacity and limited power.',18,5,15)
INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 2 - Heavy Motorcycle License','Heavy Motorcycle License (Large Motorcycle License)',21,5,30)
INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 3 - Ordinary driving license','Ordinary driving license (car license)',18,10,20)
INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 4 - Commercial','Commercial driving license (taxi/limousine)',21,10,200)
INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 5 - Agricultural','Agricultural and work vehicles used in farming or construction, (tractors / tillage machinery)',21,10,50)
INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 6 - Small and medium bus','Small and medium bus license',21,10,250)
INSERT INTO LicenseClasses
(ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees) VALUES
('Class 7 - Truck and heavy vehicle','Truck and heavy vehicle license',21,10,300)

SELECT * FROM LicenseClasses

