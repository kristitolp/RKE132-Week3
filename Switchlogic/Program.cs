﻿


Console.WriteLine("Mis hinde said?");



string hinne = Console.ReadLine().ToUpper();

switch (hinne)

{
    case "A":

        Console.WriteLine("Suurepärane!");
        break;

    case "B":

        Console.WriteLine("Väga hea!");
        break;
    case "C":

        Console.WriteLine("Hea!");
        break;
    case "D":

        Console.WriteLine("Rahuldav");
        break;

    case "E":

        Console.WriteLine("Kasin");
        break;

    case "F":

        Console.WriteLine("Puudulik");
        break;

    default:

        Console.WriteLine("Vale väärtus");
        break;
}
