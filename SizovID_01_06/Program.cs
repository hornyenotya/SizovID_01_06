using SizovID_01_06.Models;

Tovar tovar = new Tovar("Игровая консоль", 12999, 50);
tovar.QFunction();
Console.WriteLine(tovar.PrintInfo()); 

TovarChild tovarChild = new TovarChild("Телевизор", 9999, 47, 2012);
tovarChild.QpFunction();
Console.WriteLine(tovarChild.PrintInfo());