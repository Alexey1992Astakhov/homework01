//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
{
   void Zadacha1()
   {
      Console.WriteLine("Введите число: ");
      int a = Convert.ToInt32(Console.ReadLine());
      int res = Math.Abs(a);
      int res1 = res / 100;
      while (res > 1000)
      {
        res /=10;
      }
      if (res1 == 0)
      {
      Console.WriteLine("Третьей цифры в числе нет");
      }
      else
      {
      Console.WriteLine(($"{a} -> {res % 10}"));
      }
      
    }
      
     Zadacha1(); 
}
   