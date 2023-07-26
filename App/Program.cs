
class Program {
    
    static void Main(string[] args) {
        
        Console.Write("Teplota v Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        
        Console.WriteLine("Teplota "+celsius+" °C se rovná "+fahrenheit+" °F.");
    }
    
}