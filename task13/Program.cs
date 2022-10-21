Console.Clear();
Console.WriteLine("Прогрмма поиска третьего числа.");
Console.WriteLine("Пожалуйста, введите цифры: ");
int number = int.Parse(Console.ReadLine());
string numberText=Convert.ToString(number);
if (numberText.Length > 2){
  Console.WriteLine("Третья цифра " + numberText[2]);
}
else {
  Console.WriteLine("Ошибка ввода. Введено менее трех цифр.");
}