using Tyuiu.VaganovMA.Sprint4.Task3.V8.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        int[,] array = new int[5, 5] { {4, 8, 3, 4, 8 },
                                       {5, 3, 5, 7, 8 },
                                       {3, 7, 2, 7, 7 },
                                       {5, 2, 4, 6, 4 },
                                       {4, 4, 6, 7, 2 } };

        int rows = array.GetUpperBound(0) + 1;//кол строк
        int stolb = array.Length / rows;      //кол столбцов

        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #8                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine();
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        int minzn = ds.Calculate(array);
        Console.WriteLine(minzn);
        Console.ReadKey();
    }
}
//int len;
        //Console.WriteLine("длина массива");
//   len = Convert.ToInt32(Console.ReadLine());

  // int[] numsArray = new int[len];

 //    for (int i = 0; i < numsArray.Length; i++)
 //   {
//   numsArray[i] = rnd.Next(3, 9);
 // }