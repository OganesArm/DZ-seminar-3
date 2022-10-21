Console.Clear();
Console.WriteLine("Прогрмма поиска второго числа.");
Console.WriteLine("Пожалуйста, введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int result = (number%100)/10;

if (number > 99 && number<1000)  {
    Console.WriteLine("Второе число: "+ result);
} else {
Console.WriteLine("Ошибка ввода. Пожалуйста, повторите попытку");
} 