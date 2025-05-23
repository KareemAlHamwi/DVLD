SELECT
    People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
    People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor,
    People.Address, People.Phone, People.Email,
    Countries.CountryName AS Nationality,
    People.ImagePath
FROM People
    INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID;

INSERT into People
VALUES
    ('N5', 'Sofia', 'Jack', 'Thor', 'GlassHeart', 1745/12/23, 1, 'Dragon Valley', 09999, 'SofiaGlassHeart@Dragons.com', 92, 'C:\Educational & Miscellaneous\Pixel Art\Random Bullshit Go!!\warrior.png');

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
                            LEFT JOIN People p ON p.PersonID = u.PersonID?