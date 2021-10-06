using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o', ja 'l' tähte on lauses "Hello, World!"

            string helloW = "Hello World!".ToLower();

            int counter1 = 0;
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < helloW.Length; i++)

            {
                if (helloW[i] == 'h')
                {
                    counter2++;
                }
                else if (helloW[i] == 'o')
                {
                    counter1++;
                }
                else if(helloW[i] == 'l')
                {
                    counter++;
                }
            }
            Console.WriteLine($"lauses {helloW} on {counter2} 'h' {counter1} 'o' ja {counter} 'l' tähte");
        }
    }
}
