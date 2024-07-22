class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seleccione la opción:");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicación");
            Console.WriteLine("4- División");
            Console.WriteLine("5- Salir");

            int option = int.Parse(Console.ReadLine());

            if (option == 5)
            {
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Resultado: {Add(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {Subtract(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {Multiply(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Resultado: {Divide(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
}
