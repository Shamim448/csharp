namespace graphInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] inputs = Console.ReadLine().Split(","); //5, 4
            int nods = int.Parse(inputs[0].Trim()); //5
            int edges = int.Parse(inputs[1].Trim()); //4
            
            int [,] graph = new int[nods + 1, nods + 1];
            for(int i = 0; i < edges; i++)
            {
                string[] nodsConnection = Console.ReadLine().Split(",");
                int node1 = int.Parse(nodsConnection[0].Trim());
                int node2 = int.Parse(nodsConnection[1].Trim());
                graph[node1, node2] = graph[node2, node1] = 1;
            }
            for(int i = 0; i <= nods; i++) { 
                for(int j = 0; j <= nods; j++) {
                    Console.Write(graph[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}