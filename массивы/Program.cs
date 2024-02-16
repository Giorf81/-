namespace массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            var imya = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам в обратном порядке:");

            for(int i = imya.Length-1; i >=0; i--)
            {
                Console.Write(imya[i] + " ");
            } 
            Console.WriteLine("Последняя буква вашего имени: {0}",
                imya[imya.Length - 1]);

            Console.ReadKey();

        }
    }
}
