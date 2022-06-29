Console.WriteLine("Введите 2 числа : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if ( a < b)
{
    Console.WriteLine("min : " + a + " max : " + b );
}
if (a > b)
{
    Console.WriteLine("min : " + b + " max : " + a );
}