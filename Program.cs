//Вот такой вариант для 2 и 4 задачи
//ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Max());

//Задача 2
/* internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Введите два числа : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("{0} наибольшее число", a);
        }
        else
        {
            Console.WriteLine("{0} наибольшее число ", b);
        }
        Console.ReadLine();
    }
} */

//________________________________________________________________________________

//Задача 4


/* internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Введите три числа : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        var max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine("{0} наибольшее число", max);
    }
} */

//____________________________________________________________________________________

//Задача 6
/* 
internal class Program
{
    private static void Main(string[] args)
    {
        int i;
        Console.WriteLine("Введите число : ");
        i = Convert.ToInt32(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine("Введенное число является четным");
        }
        else
        {
            Console.WriteLine("Введенное число нечетное");
        }

    }
} 

или

internal class Program
{
    private static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int n = Convert.ToInt32(s);
        Console.WriteLine(n % 2 == 0 ? "Четное" : "Не четное");
    }
}





*/
//_________________________________________________________________________________________

// Задача 8
/* internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число : ");
        foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1))
            Console.WriteLine(i << 1);
    }
} */


