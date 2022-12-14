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

int num = 3;
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
double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
Console.WriteLine(desconto);
Console.WriteLine(preco -= desconto);

string original = "abcde FGHIJ ABC abc DEFG ";
string s1 = original.ToUpper();
string s2 = original.ToLower();
string s3 = original.Trim();
int n1 = original.IndexOf("bc");
int n2 = original.LastIndexOf("bc");
string s4 = original.Substring(3);
string s5 = original.Substring(3, 5);
string s6 = original.Replace('a', 'x');
string s7 = original.Replace("abc", "xy");
bool b1 = String.IsNullOrEmpty(original);
bool b2 = String.IsNullOrWhiteSpace(original);


Console.WriteLine("Original: -" + original + "-");
Console.WriteLine("ToUpper: -" + s1 + "-");
Console.WriteLine("ToLower: -" + s2 + "-");
Console.WriteLine("Trim: -" + s3 + "-");
Console.WriteLine("IndexOf('bc'): " + n1);
Console.WriteLine("LastIndexOf('bc'): " + n2);
Console.WriteLine("Substring(3): -" + s4 + "-");
Console.WriteLine("Substring(3, 5): -" + s5 + "-");
Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
Console.WriteLine("IsNullOrEmpty: " + b1);
Console.WriteLine("IsNullOrWhiteSpace: " + b2);