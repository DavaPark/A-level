using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите количество элементов в массив (): ");
        int elementsArray = int.Parse(Console.ReadLine());

        // Создание массива 
        int[] myArray = new int[elementsArray];

        Console.Write("Созданный массив: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }

        Console.WriteLine();

        Random random = new Random();

        // Заполняем массив случайными цифрами от 1 до 26
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = random.Next(1, 27);
        }

       
        Console.Write("Заполненый массив: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }

        Console.WriteLine();
    }
}