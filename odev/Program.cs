namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Kaç tane sayıyı sıralamak istiyorsunuz?");
                byte count = byte.Parse(Console.ReadLine());
                Console.WriteLine("Başlangıç sayısı griniz");
                byte start = byte.Parse(Console.ReadLine());
                Console.WriteLine("Bitiş sayısı seçiniz");
                byte end = byte.Parse(Console.ReadLine());

                if (count > (end - start))
                {
                    Console.WriteLine("Bu sayımda aynı sayılar tekrar girilemez");
                    return;
                }

                int[] numbers = new int[count];
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    int newNumber;
                    do
                    {
                        newNumber = rnd.Next(start, end);
                    } while (Array.IndexOf(numbers, newNumber) != -1);

                    numbers[i] = newNumber;
                }
                Array.Sort(numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

        }
    }
}   

