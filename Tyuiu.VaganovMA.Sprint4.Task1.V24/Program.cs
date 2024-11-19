using Tyuiu.VaganovMA.Sprint4.Task1.V24.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #24                                                          *"); 
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
            Console.WriteLine("Введите значение"+i+"Элемента массива");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Массив:");
        for (int i = 0;i < numsArray.Length; i++)
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
