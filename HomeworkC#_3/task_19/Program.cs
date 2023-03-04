// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool PalindromCheck(long num)
{
  List<long> numList = new List<long>();
  string rst = String.Empty;
  int lastIndex = new int();

  while (num > 10)
  {

    numList.Add(num % 10);
    num = num / 10;

  }

  numList.Add(num % 10);
  lastIndex = numList.ToArray().Length - 1;
  numList.Reverse();

  // Получение списка листа
  // foreach (int i in numList){
  //   rst = rst + i + " ";
  // }

  for (int i = 0; i < (numList.ToArray().Length / 2); i++)
  {
    if (numList[i] != numList[lastIndex - i]) return false;
  }
  return true;
}

Console.Write("Введите пятизначное число: ");
long num = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Ваше число " + (PalindromCheck(num) ? "": "не ") + "является палиндромом");