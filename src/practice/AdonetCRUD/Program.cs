// See https://aka.ms/new-console-template for more information
using AdonetCRUD;
string connetionString = "Server=DESKTOP-7T438A0\\SQLEXPRESS;Database=CSharpB9;User Id=shamim;Password=saba2005;";
//var query = "INSERT INTO Students ([Name], DateOfBirth) values ('Abdul Alim', '2010-08-28')";
var query = "DELETE FROM Students where [Name] like '%shamim hosen%'";
DataUtility datautility = new DataUtility(connetionString);
datautility.ExecuteCommend(query);
