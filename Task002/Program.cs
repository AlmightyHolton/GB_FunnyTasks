// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.WriteLine("Задача 13 ");

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
*/

// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

/*
Console.WriteLine("Задача 'Дополнительная' ");

int randomNumber = RandomNumber(0, 1000);

int RandomNumber(int min, int max){   
  return new Random().Next(min, max);
}

void CheckingTheNumber(int myNumber, int randomNumber) {

  if (myNumber > randomNumber) {
    Console.WriteLine("Не угадал, твоё число великовато");
  }
  else Console.WriteLine("Не угадал, твоё число маловато");
}

void AttemptCounter(int maxCounter){

  int counter = 1;
  while (counter <= maxCounter) {

    Console.Write("Попытка номер " + counter);
    Console.Write(".   Введи число: ");
    int myNumber = Convert.ToInt32(Console.ReadLine());

    if (myNumber == randomNumber){
      Console.WriteLine("Поздравляю, ты угадал! ");
      break;
    }
    else {
      CheckingTheNumber(myNumber, randomNumber);
      counter++;
    }
  }
}

Console.WriteLine("Игра до 3 попыток");
AttemptCounter(3);

Console.WriteLine("В основные попытки не уложился. Продолжим ? (напиши да/нет)");

string? yesNo = Console.ReadLine();

if (yesNo == "да"){
AttemptCounter(1000);
}
else Console.Write("Загаданное число было: " + randomNumber);
*/
