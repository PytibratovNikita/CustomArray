using CustomArray;

var array = new CustomArray<int>();
array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);
array.Add(5);
array.Add(6);
array.Add(7);

Console.WriteLine("Инициализация массива :");
array.Print();

array.Delete(5);

Console.WriteLine("Массив после удаления индекса 5 :");
array.Print();

int first = array.FindFirst(x => x % 2 == 0);
Console.WriteLine($"Первое чётное число: {first}");

array.Swap(2, 4);

Console.WriteLine("Массив после замены индексов 2 и 4 :");
array.Print();

Console.ReadKey();
