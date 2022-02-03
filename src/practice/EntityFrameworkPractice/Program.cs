using EntityFrameworkPractice;

MedicineDbContext dbContex = new MedicineDbContext();
//MedicinInfo medicinInfo = new MedicinInfo();
/*medicinInfo.MedicineName = "Napa";
medicinInfo.Quantity = 20;
medicinInfo.Price = 300;
medicinInfo.PurchaseDate = DateTime.Now;

dbContex.MedicinInfo.Add(medicinInfo);
dbContex.SaveChanges();
*/
/*
MedicinInfo? delete = dbContex.MedicinInfo.Where(x => x.MedicineName.Contains("N")).FirstOrDefault();
dbContex.MedicinInfo.Remove(delete);
dbContex.SaveChanges();


List<MedicinInfo> read = dbContex.MedicinInfo.ToList();
//List<MedicinInfo> read = dbContex.MedicinInfo.Where(x => x.MedicineName.Contains("N")).ToList();
foreach (var item in read)
{
    Console.WriteLine(item.MedicineName);
}
*/
MedicinInfo medicinInfo = new MedicinInfo();
<<<<<<< HEAD
/*
medicinInfo.MedicineName = "Embrox";
medicinInfo.Quantity = 10;
medicinInfo.Price = 200;
=======
medicinInfo.MedicineName = "Napa";
medicinInfo.Quantity = 20;
medicinInfo.Price = 300;
>>>>>>> b4492bd32aef64b3a9a00bc742f799804ec31a42
medicinInfo.PurchaseDate = DateTime.Now;

Dispansary dispansary1 = new Dispansary();
dispansary1.Name = "Saba Pharmecy";
dispansary1.Address = "Paharpur Bazar";

Dispansary dispansary2 = new Dispansary();
dispansary1.Name = "Saba Medicine Store";
dispansary1.Address = "Paharpur Bazar";

medicinInfo.Pharmecy = new List<Dispansary>();
medicinInfo.Pharmecy.Add(dispansary1);
medicinInfo.Pharmecy.Add(dispansary2);

dbContex.MedicinInfo.Add(medicinInfo);
dbContex.SaveChanges();
<<<<<<< HEAD
*/

=======
>>>>>>> b4492bd32aef64b3a9a00bc742f799804ec31a42
