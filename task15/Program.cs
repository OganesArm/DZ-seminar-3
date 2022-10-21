Console.Clear();
Console.WriteLine("Прогрмма поиска выходных.");
Console.WriteLine("Пожалуйста, введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number== 6 | number == 7){ 
Console.WriteLine("Сегодня выходной!");
} else if (number >0 && number <6) {
Console.WriteLine("Сегодня будний день :(");
} else 
Console.WriteLine("Ошибочный ввод, введите цифру от 1 до 7 в зависимости от дня недели");
