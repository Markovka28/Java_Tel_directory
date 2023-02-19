﻿/*ЗАДАЧА: Написать программу, которая из имеющегося массива строк,
 формирует массив из строк, длина которых <= 3 символа*/

internal class Program
{
    private static void Main(string[] args)
    {
        string[] ArrText ={"Она", "почти", "слышала", "как", "двери", "её", "тюрьмы", "захлопываются.",
        "Свобода", "ушла", "навсегда", "теперь", "её", "судьба", "в", "чужих", "руках", "и", "никогда", "ей", "не",
        "увидеть", "воли.", "В", "голове", "её", "замелькали", "безумные", "мысли", "о", "том", "как", "хорошо",
        "бы", "сейчас", "улететь", "далеко-далеко.", "Но", "она", "знала", "что", "скрыться", "невозможно.",
        "Она", "с", "улыбкой", "повернулась", "к", "жениху", "и", "повторила:", "Да", "я", "согласна", ":-)" };
        var result = ArrText.Where(p => p.Length <= 3);
        foreach (string text in result)
            Console.Write($" {text}");    
    }
}