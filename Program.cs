//inferência de tipo
//var reconhece o tipo de dado da variável e o compilador reconhece
var x = 10;//inteiro
var y = 20.0;//double
var z = "Maria";//string

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

//switch-case
//possibilidade de if's

int num = int.Parse(Console.ReadLine());
string day;

if(num == 1)
{
    Console.WriteLine("Sunday");
}
else if(num == 2)
{
    Console.WriteLine("Monday");
}
else if (num == 3)
{
    Console.WriteLine("Tuesday");
}
else if (num == 4)
{
    Console.WriteLine("Wednesday");
}
else if (num == 5)
{
    Console.WriteLine("Thursday");
}
else if (num == 6)
{
    Console.WriteLine("Friday");
}
else if (num == 7)
{
    Console.WriteLine("Saturday");
}
else
{
    Console.WriteLine("Invalid Value");
}