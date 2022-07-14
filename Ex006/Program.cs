//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

{
    void Zadacha2()
    {
        Console.WriteLine("Введите число от 1 до 7 : ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 6 && number > 0)
        {
            Console.WriteLine("Рабочий день");
        }   
        else if (number == 6)
        {
            Console.WriteLine("Суббота , выходной день");
        }
        else if (number == 7)
        {
            Console.WriteLine("Воскресенье, выходной день");
        }
        else
        {
            Console.WriteLine("Задано неверное значение");
        }
    }
    Zadacha2();
}