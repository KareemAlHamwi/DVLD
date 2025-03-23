SELECT 
    People.PersonID, People.NationalNo, People.FirstName, People.SecondName, 
    People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor, 
    People.Address, People.Phone, People.Email, 
    Countries.CountryName AS Nationality,
    People.ImagePath
FROM People  
INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID;
