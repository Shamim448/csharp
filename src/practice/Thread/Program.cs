// See https://aka.ms/new-console-template for more information

void PrintEvenNumber(int total)
{
    for(int i = 0; i < total; i += 2)
    {
        Console.WriteLine("\t" + i);
        Thread.Sleep(100);
    }
}
void PrintOddNumber(int total)
{
    for (int i = 1; i < total; i += 2)
    {
        Console.WriteLine(i);
        Thread.Sleep(100);
    }
}

Thread t1 = new Thread(() => PrintEvenNumber(100));
Thread t2 = new Thread(() => PrintOddNumber(101));
t1.Priority = ThreadPriority.Highest; 
t2.Priority = ThreadPriority.Lowest;
t1.Start();
t2.Start();