// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Выходной?");
int a = Convert.ToInt32(Console.ReadLine());

if (a>0 & a<8)
{
    if(a>0 & a<6)
    {
    System.Console.Write(" -> нет");
    }
    else
    {
    System.Console.Write(" -> да");       
    }
}
else
{
    System.Console.Write("Нет такого дня");
}