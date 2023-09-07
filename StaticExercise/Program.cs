namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool inInCode = false;
            while (!inInCode)
            {
                Console.WriteLine("press 1 if you want to covert fahrenheit to celsius, press 2 if you want to covert celsius to fahrenheit, press 3 to close the code");
                int chose = int.Parse(Console.ReadLine());
                if (chose == 1)
                {
                    Console.WriteLine("what is the fahrenheit");
                    int Temp = int.Parse(Console.ReadLine());
                    TempConverter.FahrenheitToCelsius(Temp);
                    Console.WriteLine("");
                }
                if (chose == 2)
                {
                    Console.WriteLine("what is the celsius");
                    int Temp = int.Parse(Console.ReadLine());
                    TempConverter.FahrenheitToCelsius(Temp);
                    Console.WriteLine("");
                }
                if (chose == 3)
                {
                    inInCode = true;
                }
            }
        }
    }
}
