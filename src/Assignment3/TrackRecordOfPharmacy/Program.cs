
MenuOption();
//Opeaning Screen Menu
static void MenuOption()
{   
    Console.Clear(); // Clear repiting Munu 
    Console.WriteLine("Welcome To Our Apps");
    Console.WriteLine(" ");
    Console.WriteLine("a. Search Medicin");
    Console.WriteLine("b. Add Medicin");
    Console.WriteLine("c. Update Medicin");
    Console.WriteLine("d. Remove Medicin");
    Console.WriteLine("e. Exit Medicin");
    Console.ReadLine();
    //If User Press enter call Opening screen
    MenuOption();
}