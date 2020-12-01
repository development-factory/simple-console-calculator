using System;

namespace PrimulProiect
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Vă rog să selectati operatia:");
                Console.WriteLine("1. Adunare");
                Console.WriteLine("2. Scădere");
                Console.WriteLine("3. Înmultire");
                Console.WriteLine("4. Împărtire");
                Console.WriteLine("5. Iesire aplicatie");

                string input = Console.ReadLine();

                int operation, firstNumber, secondNumber;

                int.TryParse(input, out operation);

                if (operation == 5)
                {
                    Console.WriteLine("Calculatorul a fost oprit.");
                    return;
                }

                Console.WriteLine("Va rog sa introduceti primul numar..");
                int.TryParse(Console.ReadLine(), out firstNumber);

                Console.WriteLine("Va rog sa introduceti al doilea numar..");
                int.TryParse(Console.ReadLine(), out secondNumber);

                double result = 0;

                switch (operation)
                {
                    case 1:
                        result = Calculator.Sum(firstNumber, secondNumber);
                        break;
                    case 2:
                        result = Calculator.Difference(firstNumber, secondNumber);
                        break;
                    case 3:
                        result = Calculator.Multiply(firstNumber, secondNumber);
                        break;
                    case 4:
                        result = Calculator.Divide(firstNumber, secondNumber);
                        break;
                }

                Console.WriteLine("Rezultatul este : " + result);
            }
        }
    }
}
