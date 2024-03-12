namespace StructuredProgrammingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation;
            double firstData;
            double secondData;
            bool isCalculating = true;

            while (isCalculating)
            {

                Console.WriteLine("Bienvenido a tu calculadora!");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir");

                operation = GetIntegerDataFromUser("Proporcionda la operación que deseas ejecutar:");

                switch (operation)
                {
                    case 1:
                        // sum
                        firstData = GetDoubleDataFromUser("Proporciona el primer valor: ");
                        secondData = GetDoubleDataFromUser("Proporciona el segundo valor: ");
                        Console.WriteLine($"El resultado de {firstData} + {secondData} es igual a {firstData + secondData}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // resta
                        firstData = GetDoubleDataFromUser("Proporciona el primer valor: ");
                        secondData = GetDoubleDataFromUser("Proporciona el segundo valor: ");
                        Console.WriteLine($"El resultado de {firstData} - {secondData} es igual a {firstData - secondData}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // salir
                        Console.Clear();
                        isCalculating = false;
                        Console.WriteLine("Presione cualquier tecla para salir ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no existe.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        private static double GetDoubleDataFromUser(string message)
        {
            string userValue;
            double data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userValue = Console.ReadLine();

                if (!double.TryParse(userValue, out data))
                {
                    Console.WriteLine("El dato proporcionado no es valido. Vuelve a intentarlo");
                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userValue;
            int data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userValue = Console.ReadLine();

                if (!int.TryParse(userValue, out data))
                {
                    Console.WriteLine("El dato proporcionado no es valido. Vuelve a intentarlo");
                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }
    }
}