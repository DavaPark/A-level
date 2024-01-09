using System;

class Program
{
    static void Main()
    {
        
        int elelemntsArray = 28; 

        // Создаём массив для четных чисел
        int[] evenArray = new int[elelemntsArray];
        // Создаём массив для нечетных чисел
        int[] oddArray = new int[elelemntsArray];

        // Заполняем массивы четными и нечетными числами
         for (int i = 0; i < elelemntsArray; i++)
         {
             evenArray[i] = 2 * i;
             oddArray[i] = 2 * i + 1;

         }

        
         Console.WriteLine("Массив четных чисел: " + "[ " + string.Join(", ",evenArray) + " ]");
         Console.WriteLine("Массив нечетных чисел: " + "[ " + string.Join(", ", oddArray) + " ]");
        
        Console.WriteLine();

        // Создаём массив для четных чисел (буквы A, C, E, ...)
        char[] alfavitArray = new char[elelemntsArray];
        // Создаём массив для нечетных чисел (буквы B, D, F, ...)
        char[] alphabetArray = new char[elelemntsArray];

        // Заполняем массивы буквами английского алфавита
        for (int i = 0; i < elelemntsArray; i++)
        {
            alfavitArray[i] = (char)('A' + 2 * i);
            alphabetArray[i] = (char)('A' + 2 * i + 1);
        }

        Console.WriteLine("Массив букв: " + string.Join(", ", alfavitArray));
        Console.WriteLine("Массив букв: " + string.Join(", ", alphabetArray));

        Console.WriteLine();

        // Преобразовываем буквы нижнего регестра в большие 
        for (int i = 0; i < elelemntsArray;i++)
        {
            alfavitArray[i] = char.ToUpper(alfavitArray[i]);
            alphabetArray[i] = char.ToUpper(alphabetArray[i]);
        }

        Console.WriteLine("Массив букв: " + string.Join(", ", alfavitArray));
        Console.WriteLine("Массив букв: " + string.Join(", ", alphabetArray));

        Console.WriteLine();

        //Проверяем в каком массиве больше заглавніх букв
        if(CountUpperLeters(alfavitArray)> CountUpperLeters(alphabetArray))
        {
            Console.WriteLine("Первый массив имеет больше заглавных букв");
        }
        else if(CountUpperLeters(alfavitArray) < CountUpperLeters(alphabetArray))
        {
            Console.WriteLine("Второй массив имеет больше заглавных букв");
        } 
        else
        {
            Console.WriteLine("Оба массива имеет одинаковое колличкство заглавных букв");
        }

        Console.WriteLine("Массив букв: " + string.Join(", ", alfavitArray));
        Console.WriteLine("Массив букв: " + string.Join(", ", alphabetArray));

        Console.WriteLine();

        //Подсчитываем сколько заглавных букв в массиве
        static int CountUpperLeters(char[] array)
         {
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {

                if (char.IsUpper(array[i]))
                {
                    counter++;
                }
            }
            return counter;
         }

        Console.WriteLine("Массивы в одну строчку ");

        Console.WriteLine("Массивы " + string.Join("", alfavitArray) + " " + string.Join("", alphabetArray));


        Console.WriteLine();
        Console.WriteLine("Также массив числе в одну строчку ");
        Console.WriteLine("Массивы чисел: " + string.Join("", evenArray) + " " + string.Join("", oddArray));
        Console.WriteLine();


    }
}