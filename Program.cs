using System;
using indexers;

// Simple Index in a For Loop
// int[] theNumbers = { 1, 3, 5, 7, 9, 11 };

// for (int index = 0; index < theNumbers.Length; index++)
// {
//   Console.WriteLine($"Index {index} = {theNumbers[index]}");
// }

// Custom int Index in a Class
DragonCollection dc = new();

dc.AddDragon(new Dragon("Smaug", 1_000));
// Console.WriteLine(dc.GetDragon(0));

dc[1] = new Dragon("Shenron", 1_000_000);
// Console.WriteLine(dc[1]);

// for (int newIndex = 0; newIndex < dc.Count; newIndex++)
// {
//   Console.WriteLine(dc[newIndex]);
// }

// foreach (Dragon d in dc)
// {
//   Console.WriteLine(d);
// }


// Custom String Index

DragonStringCollection dsc = new();

dsc["Shenron"] = new Dragon("Shenron", 1_000_000);
dsc["Smaug"] = new Dragon("Smaug", 1_000);

Dragon Shenron = dsc["Shenron"];

Dragon Donkey = new Dragon("Donkey", 10);

dsc["Donkey"] = Donkey;

Console.WriteLine(Shenron);
Console.WriteLine(dsc["Donkey"]);
