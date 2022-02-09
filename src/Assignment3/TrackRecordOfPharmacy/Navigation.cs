using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackRecordOfPharmacy
{
    public class Navigation
    {
        //Opeaning Screen Menu
        public static void MenuOption()
        {
            Console.Clear(); // Clear repiting Munu 
            Console.WriteLine("Welcome To Our Apps");
            Console.WriteLine(" ");
            Console.WriteLine("a. Search Medicin");
            Console.WriteLine("b. Add Medicin");
            Console.WriteLine("c. Update Medicin");
            Console.WriteLine("d. Remove Medicin");
            Console.WriteLine("e. Exit Medicin");
            Console.WriteLine("Please type a or b or c or d or e to navigation ");
            var options = Console.ReadLine().ToLower();
            Console.WriteLine(" ");
            switch (options)
            {
                case "a":
                    SearchMedicineRecord();
                    break;
                case "b":
                    InsertMedicineRecord();
                    break;
                case "c":
                    UpdateMedicineRecord();
                    break;
                case "d":
                    DeleteMedicineRecord();
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
            }
            //If User Press enter call Opening screen
            MenuOption();
        }
        //dbcontext connection
        private static DBContext dbcontext = new DBContext();
        //Add medicine
        static void InsertMedicineRecord()
        {
            MedicineRecord medicineRecord = new MedicineRecord();
            Console.WriteLine("Please Enter Medicine Name (Ex: Napa)");
            medicineRecord.MName = Console.ReadLine();
            Console.WriteLine("Please Enter Box Quantity"); 
            medicineRecord.Quantity = Console.ReadLine();
            dbcontext.Add(medicineRecord);
            Console.WriteLine("Data Insert successfully" + '\n');
            dbcontext.SaveChanges();
            RetriveMedicineRecord();

        }
        //Retrive Medicine
        public static void RetriveMedicineRecord()
        {
            var medicineRecords = dbcontext.MedicineRecords.ToList();
            Console.WriteLine("\nMedicine Stock List");
            foreach(var medicineInfo in medicineRecords)
            {
                Console.WriteLine(medicineInfo.MName  + '\t' + medicineInfo.Quantity );
            }
            //Console.WriteLine("\nPlease Press Enter For Back To Home Screen");
            Console.ReadLine();
        }

        //Search Medicine
        public static void SearchMedicineRecord()
        {
            Console.WriteLine("\nPlease Enter Medicine Name which you want to Find");
            var Uname =Console.ReadLine();
            if(Uname != null && Uname != string.Empty) { 
            var medicineRecords = dbcontext.MedicineRecords.FirstOrDefault(x => x.MName.Contains(Uname) && x.Quantity.Length > 0);
            //var medicineRecords = dbcontext.MedicineRecords.Where().ToList();
            if(medicineRecords != null) {
                Console.WriteLine(medicineRecords.MName + '\t' + medicineRecords.Quantity);
                Console.ReadLine();
            }else
            {
                Console.WriteLine(Uname + " Not Available Right Now");
                Console.ReadLine();
            }
            }

        }
        //Update Medicine
        static void UpdateMedicineRecord()
        {
            Console.WriteLine("\nPlease Enter Medicine Name which you want to update");
            var Uname = Console.ReadLine();
            var medicineRecords = dbcontext.MedicineRecords.FirstOrDefault(x => x.MName.Contains(Uname));
            Console.WriteLine("Please Enter Medicine Name (Ex: Napa)");
            medicineRecords.MName = Console.ReadLine();
            Console.WriteLine("Please Enter Box Quantity");
            medicineRecords.Quantity = Console.ReadLine();
            Console.WriteLine("Data Update successfully" + '\n');
            dbcontext.SaveChanges();
            RetriveMedicineRecord();
            Console.WriteLine("\nPlease Press Enter For Back To Home Screen");
            Console.ReadLine();
        }
        //Update Medicine
        static void DeleteMedicineRecord()
        {
            Console.WriteLine("\nPlease Enter Medicine Name which you want to Delete");
            var Dname = Console.ReadLine();
            var medicineRecords = dbcontext.MedicineRecords.FirstOrDefault(x => x.MName.Contains(Dname));
            dbcontext.Remove(medicineRecords);
            Console.WriteLine("Data Remove Successfully" + '\n');
            dbcontext.SaveChanges();
            RetriveMedicineRecord();
            Console.WriteLine("\nPlease Press Enter For Back To Home Screen");
            Console.ReadLine();
        }
        
    }
}
