// Задайте значения M и N. 
//Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}

void PrintEvenNumbers (int numberM, int numberN)
{
    if (numberM > numberN) return;
    if (numberN % 2 == 1)
    {
        numberN= numberN-1;
    }
PrintEvenNumbers (numberM, numberN - 2);
System.Console.Write($"{numberN} ");
}

int numberM = Prompt ("Введите число M: ");
int numberN = Prompt ("Введите число N: ");
System.Console.WriteLine();
System.Console.WriteLine($"Четные натуральные числа в промежутке между {numberM} и {numberN}:");
PrintEvenNumbers(numberM,numberN);