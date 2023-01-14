//Чиннов 22-ИСП-2/1 Задание 81

namespace AbstractClassLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AndArray andArray = new(new double[] { 1, 2, 3, 4, 5 });
            OrArray orArray = new(new double[] { 1, 2, 3, 4, 5 });

            
            Console.WriteLine($"{String.Join(" " ,andArray.Arr)} ");
            Console.WriteLine();

            for (int item_index = 0; item_index < orArray.Arr.Length; item_index++)
            {
                Console.Write($"{orArray.Arr[item_index]:F0} ");
            }
            Console.WriteLine();

            //сложение
            Console.WriteLine("Сложение с {4,5,6,7,8}");

            double[] sumAnd = andArray.Sum(new double[] { 4, 5, 6, 7, 8 });
            for (int item_index = 0; item_index < sumAnd.Length; item_index++)
            {
                Console.Write($"{sumAnd[item_index]:F0} ");
            }
            Console.WriteLine();

            double[] sumOr = orArray.Sum(new double[] { 4, 5, 6, 7, 8 });
            for (int item_index = 0; item_index < sumOr.Length; item_index++)
            {
                Console.Write($"{sumOr[item_index]:F0} ");
            }
            Console.WriteLine();

            //почленная обработка
            Console.WriteLine("Почленная обработка");
            andArray.ElemByElem();
            orArray.ElemByElem();

            for (int item_index = 0; item_index < andArray.Arr.Length; item_index++)
            {
                Console.Write($"{andArray.Arr[item_index]:F2} ");
            }
            Console.WriteLine();

            for (int item_index = 0; item_index < orArray.Arr.Length; item_index++)
            {
                Console.Write($"{orArray.Arr[item_index]:F2} ");
            }
            Console.WriteLine();

            Console.WriteLine($"{String.Join(" ", andArray.Arr)} ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}