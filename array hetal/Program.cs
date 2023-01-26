namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tal = new string[3];
            tal[0] = "8";
            tal[1] = "2";
            Console.WriteLine($"Skriv in ditt heltal förutom {tal[0]} och {tal[1]}");
            tal[2] = Console.ReadLine();
            
            
            
            

            Console.WriteLine("Här är de 3 heltalen");
            Console.WriteLine($"{tal[0]}, {tal[1]} och {tal[2]}");

           
        }
    }

}