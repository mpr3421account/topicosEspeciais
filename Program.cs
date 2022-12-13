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

switch (num)
{
    case 1:
        day = "Sunday";
        break;
    case 2:
        day = "Monday";
        break;
    case 3:
        day = "Tuesday";
        break;
    case 4:
        day = "Wednesday";
        break;
    case 5:
        day = "Thursday";
        break;
    case 6:
        day = "Friday";
        break;
    case 7:
        day = "Saturday";
        break;
    default:
        day = "Invalid value";
        break;
}
Console.WriteLine(day);

//Condição ternária
double preco = 34.5;
double desconto = (preco < 35.0) ? preco * 0.1 : preco * 0.05;
Console.WriteLine(desconto);
Console.WriteLine(preco += desconto);