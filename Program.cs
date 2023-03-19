namespace compareWith10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Berilgan son 10 dan katta bo'lsa unga 3 ni qo'shib konsolga chiqaring.
            //Agar 10 dan kichik bo'lsa 2ga ko'paytirib natijani konsolga chiqaring.
            //Agar 10 ga teng bo'lsa 22 sonini konsolga chiqaring.

            while (true)
            {
                Console.Write("Sonni kiriting => ");
                int son = Convert.ToInt32(Console.ReadLine());

                if (son > 10)
                {
                    Console.WriteLine($"{son + 3}");
                }
                else if (son < 10)
                {
                    Console.WriteLine($"{son * 2}");
                }
                else
                {
                    Console.WriteLine($"{son + 12}");
                }
            }
        }
    }
}