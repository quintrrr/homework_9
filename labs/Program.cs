﻿using System;
using labs.interfaces;
using labs.classes;

class Program
{
    public static void Main()
    {
        Task1();
    }

    static void Task1()
    {
        /* Создать интерфейс ICipher, который определяет методы поддержки
           шифрования строк. В интерфейсе объявляются два метода encode() и decode(), которые
           используются для шифрования и дешифрования строк, соответственно. Создать класс
           ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига
           каждого символа на одну «алфавитную» позицию выше. Например, в результате такого
           сдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс
           ICipher. Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й
           позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца
           алфавита. Например, буква В заменяется на букву Э. Написать программу,
           демонстрирующую функционирование классов. */
        Console.WriteLine("Упражнение 10.1");
        ICipher aCipher = new ACipher();
        ICipher bCipher = new BCipher();

        string originalText = "абв АБВ эюя ЭЮЯ";
        
        string encodedA = aCipher.encode(originalText);
        string decodedA = aCipher.decode(encodedA);
        Console.WriteLine($"ACipher - Исходный текст: {originalText}");
        Console.WriteLine($"ACipher - Закодированный текст: {encodedA}");
        Console.WriteLine($"ACipher - Декодированный текст: {decodedA}");
        
        string encodedB = bCipher.encode(originalText);
        string decodedB = bCipher.decode(encodedB);
        Console.WriteLine($"\nBCipher - Исходный текст: {originalText}");
        Console.WriteLine($"BCipher - Закодированный текст: {encodedB}");
        Console.WriteLine($"BCipher - Декодированный текст: {decodedB}");
    }

    static void Task2()
    {
        /* Создать класс Figure для работы с геометрическими фигурами. В
           качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать
           операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение
           цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить
           состояние всех полей объекта. Создать класс Point (точка) как потомок геометрической
           фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle добавить
           метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник)
           как потомок точки, реализовать метод вычисления площади прямоугольника. Точка,
           окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и
           вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно
           ли объявлять абстрактный класс, какие методы и поля будут в абстрактном классе, какие
           методы будут виртуальными, какие перегруженными. */
        
    }
}