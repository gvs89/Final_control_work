using System;
//using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Задаем исходный массив строк
        string[] initialArray = { "Привет", "-9", "Это", "C#", "7865" };

        // Вычисляем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
                count++;
        }

        // Создаем новый массив для хранения коротких строк
        string[] shortStrings = new string[count];

        // Заполняем новый массив
        int index = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                shortStrings[index++] = str;
            }
        }

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < initialArray.Length; i++) // пробежка по массиву
        {

            if (i == 0) // проверка, начальный элемент или нет
            {
                Console.Write("[" + initialArray[i] + " ");
            }
            else if (i == initialArray.Length - 1) // проверка, конечный элемент или нет
            {
                Console.Write(" " + initialArray[i] + "]");
            }
            else    //исключение
            {
                Console.Write(", " + initialArray[i] + ", ");
            }
        }
        // Вывод нового массива
        Console.WriteLine("\nНовый массив:");


        for (int i = 0; i < shortStrings.Length; i++) // пробежка по массиву
        {

            if (i == 0) // проверка , начальный элемент или нет
            {
                Console.Write("[" + shortStrings[i] + " ");
            }
            else if (i == shortStrings.Length - 1) // проверка , конченый элемент или нет
            {
                Console.Write(" " + shortStrings[i] + "]");
            }
            else    //исключение, обьект находится не на крае
            {
                Console.Write(", " + shortStrings[i] + ", ");
            }
        }
    }
}