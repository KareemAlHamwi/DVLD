RESTORE DATABASE dbDVLD
FROM DISK = 'C:\Educational & Miscellaneous\Programming\.Programming Advices\19.Full Real Project\DVLD.bak'

SELECT
    People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
    People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor,
    People.Address, People.Phone, People.Email,
    Countries.CountryName AS Nationality,
    People.ImagePath
FROM People
    INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID;

SELECT *
FROM People

SELECT *
FROM Countries

SELECT
    PersonID AS 'Person ID', NationalNo as 'National No.', FirstName AS 'First Name', SecondName AS 'Second Name', ThirdName AS 'Third Name', LastName AS 'Last Name',
    DateOfBirth AS 'Birthdate',
    CASE 
    WHEN Gendor = 0 THEN 'Male' 
    WHEN Gendor = 1 THEN 'Female' 
    ELSE 'Unknown' 
END AS 'Gender',
    Address, Phone, Email,
    Countries.CountryName AS 'Nationality',
    ImagePath, NationalityCountryID
FROM People
    LEFT JOIN Countries ON People.NationalityCountryID = Countries.CountryID


SELECT *
FROM Users

DELETE From Users WHERE UserID = 18

SELECT *
FROM Users
WHERE PersonID = 1

SELECT *
FROM Users
WHERE UserID = 20

SELECT
    u.UserID AS 'User ID',
    u.PersonID AS 'Person ID',
    CONCAT_WS(' ', p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS 'Full Name',
    u.UserName,
    u.IsActive AS 'Is Active'
FROM Users u
    LEFT JOIN People p ON p.PersonID = u.PersonID


SELECT * From People WHERE PersonID = 1

SELECT
                            u.UserID AS 'User ID',
                            u.PersonID AS 'Person ID',
                            CONCAT_WS(' ', p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS 'Full Name',
                            u.UserName,
                            u.IsActive AS 'Is Active'
                            FROM Users u
                            LEFT JOIN People p ON p.PersonID = u.PersonID

SELECT * from Applications

select 

ap.ApplicationID as 'L.D.L AppID',
l.ClassName as 'Driving Class',
p.NationalNo as 'National No.',
p.FirstName  + ' ' + p.SecondName + ' ' + p.ThirdName + ' ' + p.LastName as 'Full Name',
ap.ApplicationDate as 'Application Date',
1 as 'Passed Tests',
ap.ApplicationStatus as 'Status'

from Applications ap
JOIN People p ON p.PersonID = ap.ApplicantPersonID
JOIN LicenseClasses l ON ap.ApplicationTypeID = l.LicenseClassID
JOIN Users u ON ap.CreatedByUserID = u.UserID


SELECT 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.LAppID], 
    LicenseClasses.ClassName AS [Driving Class], 
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName) AS [FULL Name], 
    Applications.ApplicationDate,
    (SELECT COUNT(DISTINCT TestAppointments.TestAppointmentID)
FROM TestAppointments 
INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  
AND Tests.TestResult = 1) AS [Passed Tests], 
  CASE WHEN Applications.ApplicationStatus = 1 THEN 'New'
  WHEN Applications.ApplicationStatus = 2 THEN 'Canceled' 
  WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS Status
FROM LocalDrivingLicenseApplications 
LEFT JOIN Applications 
    ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
LEFT JOIN LicenseClasses 
    ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID 
LEFT JOIN People 
    ON Applications.ApplicantPersonID = People.PersonID 
LEFT JOIN TestAppointments 
    ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
LEFT JOIN Tests 
    ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
GROUP BY 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
    LicenseClasses.ClassName,
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName),
    Applications.ApplicationDate,
    Applications.ApplicationStatus


SELECT * from Applications

SELECT * from LocalDrivingLicenseApplications

SELECT * FROM LocalDrivingLicenseApplications_View

SELECT * from InternationalLicenses

-- UPDATE People
-- SET ImagePath = NULL;

SELECT * from People

SELECT * from users

SELECT * from LicenseClasses

SELECT * from ApplicationTypes

SELECT ApplicantPersonID FROM Applications

DELETE from LocalDrivingLicenseApplications WHERE ApplicationID = 74
DELETE from LocalDrivingLicenseApplications WHERE ApplicationID = 76

delete from Applications WHERE ApplicantPersonID = 3070

select * from Countries

UPDATE Countries SET CountryName = 'Palestine'
WHERE CountryID = 81

SELECT * FROM People

DROP DATABASE dbDVLD