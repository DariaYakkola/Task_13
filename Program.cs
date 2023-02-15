Console.Write("Введите семизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
  if (number <= 99)
  {
    Console.WriteLine("В данном числе нет третьей цифры! ");
  }
  else
  {
    if ((number > 99) && (number < 1000000))
    {
      string message = number.ToString();
      Console.WriteLine($"Данное число не является семизначным, но у него есть третья цифра - это {message[2]}");
    }
    else
    {
      if (number >= 10000000)
      {
      string message = number.ToString();
      Console.WriteLine($"Данное число не является семизначным, но у него есть третья цифра - это {message[2]}");
      }
      else
      {
      int mediumResult1 = number % 1000000;
      int mediumResult2 = mediumResult1 % 100000;
      int result = mediumResult2 / 10000;
      Console.WriteLine($"Число является семизначным и его третья цифра - это {result} ");
      }
    }
  }
}
else
{
  int positiveNumber = number * -1;
    if (positiveNumber <= 99)
    {
    Console.WriteLine("В данном числе нет третьей цифры! ");
    }
    else
    {
      if ((positiveNumber > 99) && (positiveNumber < 1000000))
      {
      string message = positiveNumber.ToString();
      Console.WriteLine($"Данное число не является семизначным, но у него есть третья цифра - это {message[2]}");
      }
      else
      {
        if (positiveNumber >= 10000000)
        {
        string message = positiveNumber.ToString();
        Console.WriteLine($"Данное число не является семизначным, но у него есть третья цифра - это {message[2]}");
        }
        else
        {
        int mediumResult1 = positiveNumber % 1000000;
        int mediumResult2 = mediumResult1 % 100000;
        int result = mediumResult2 / 10000;
        Console.WriteLine($"Число является семизначным и его третья цифра - это {result} ");
        }
      }
    }
}