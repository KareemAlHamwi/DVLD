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
('N5','Sofia','Jack','Thor','GlassHeart',1745/12/23,1,'Dragon Valley',09999,'SofiaGlassHeart@Dragons.com',92,'C:\Educational & Miscellaneous\Pixel Art\Random Bullshit Go!!\warrior.png');

SELECT * FROM People

SELECT * FROM Countries
