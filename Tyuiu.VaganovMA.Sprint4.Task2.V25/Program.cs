using Tyuiu.VaganovMA.Sprint4.Task2.V25.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #25                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int len;
        Console.WriteLine("длина массива");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i < numsArray.Length; i++)
        {
            numsArray[i] = rnd.Next(3,9);
        }
        Console.WriteLine();
        Console.WriteLine("Массив:");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.WriteLine(numsArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        int s = ds.Calculate(numsArray);
        Console.WriteLine(s);
        Console.ReadKey();
    } 
} 
