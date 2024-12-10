namespace MyDST;
public class Programm
{
    // Место для программы.












    
    public static int[,] Data = { { 0, 1,1 }, { 1, 0,1 },{ 1, 1,0 } };
    public static int[,] Dta = { 
        { -2, 0, 0, -5,-19 },
        { 2, -1, 0, 0,0 }, 
        { 0, 1, -1,5, 0},
        { 0, 0, 1, 0,19}
    };
    static void Main(string[] args)
    {
        var g = new Graph(Dta, 1);
        g.Dijkstra(g.Peaks.First());

        foreach (var x in g.Peaks)
        {
            Console.WriteLine(x.Name);
            var tmp = x.routestoPeak;
            
            foreach (var y in tmp)
            {
                Console.WriteLine(y.ToString());


            }
        }

        Console.WriteLine();
        
        Console.WriteLine(g.Peaks.Last().count);
        Console.WriteLine(g.Peaks.Last().routestoPeak.First());


    }

    
}