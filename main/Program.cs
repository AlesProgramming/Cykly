namespace main
{
    class cykly
    {
        static void Main()
        {
            Console.WriteLine("1 for task 1 - 2 for task 2");
            string input = Console.ReadLine().Trim();
            if (input == "1")
            {
                Exercise1();
            }
            if (input == "2")
            {
                Exercise2();
            }
        }

        static void Exercise1()
        {
            Console.WriteLine("Keep entering words: ");
            string input = Console.ReadLine();
            string full = "";
            while (!String.IsNullOrWhiteSpace(input))
            {
                full += input;
                input = Console.ReadLine();
            }
            Console.WriteLine(full);
            Main();
        }

        static void Exercise2()
        {
            {
                Console.WriteLine("Enter an input: ");
                string input = Console.ReadLine();
                for (int x = 0; x < 4; x++)
                {
                    Console.WriteLine(input);
                }

                Console.WriteLine("--------");
            }

            for (int x = 1; x < x + 1; x++)
            {
                {
                    Console.WriteLine("Keep entering words, enter empty when done. ");
                    string input = Console.ReadLine().Trim();
                    string res = "";

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Main();
                    }
                    
                    for (int i = 0; i < x; i++)
                    {
                        res += input;
                    }

                    Console.WriteLine(res);
                    Console.WriteLine("----------");
                }
            }
        }
    }
}