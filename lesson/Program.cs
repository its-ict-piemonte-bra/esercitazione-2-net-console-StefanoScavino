namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            //Esercizio1();
            //Esercizio2();
            //Esercizio3();
            Esercizio4();
        }
        /// <summary>
        /// Visualizza 100 numeri pari, partendo dal numero 2
        /// </summary>
        private static void Esercizio1()
        {
            for(int i = 1; i <= 100; i++)
            { 

                Console.WriteLine($"{i * 2}");

            }
        }

        private static void Esercizio2()
        {
            Console.WriteLine("qual è il numero da fattorializzare?");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num < 0)
            {
                Console.WriteLine($"{num} non è un numero positivo");
            }
            else
            {
                int fattoriale = 1;
                for (int i = 2; i <= num; i++)
                {

                    fattoriale *= i;

                }
                Console.WriteLine($" il numero fattoriale vale {fattoriale}");
            }
        }
        private static void Esercizio3()
        {
            Console.WriteLine("qual è il numero binario da rendere decimale?");
            string binario = Console.ReadLine();

            double decimale = 0;
            
            for(int i = 0; i < binario.Length; i++)
            {
                int currentExpValue = Convert.ToInt32(binario[i] - '0');
                decimale += currentExpValue + Math.Pow(2, binario.Length - i - 1);
            }
            Console.WriteLine($"il numero in decimale vale {decimale}");
        }
        private static void Esercizio4()
        {
            Console.WriteLine("qual è numero vuoi rendere fibonaccioso?");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if(num < 0)
            {
                Console.WriteLine($"{num} non è un numero positivo");
            }
            else if (num < 2)
            {
                Console.WriteLine($"{num}");
            }
            else
            {
                int first = 0;
                int second = 1;

                for (int i = 2; i<= num; i++)
                {
                    int third = first + second;
                    second = third;
                    first = second;
                }
                Console.WriteLine($"il fibonacci vale {second}");
            }

        }
    }
}
