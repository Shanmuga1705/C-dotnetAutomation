int x = 10, y = 5;
string a = "abcd", b = "efgh";

Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x>y || y>=5);

Console.WriteLine("------Basic Math-----");
Console.WriteLine((x/y)*x);
Console.WriteLine(a+b);

Console.WriteLine("------Shorthand-----");
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);

a += b;
Console.WriteLine(a);

String str = null;
Console.WriteLine(str??"Unknown string");

//The ??= operator assigns the right operand if the left one is null
str ??= "New String";
Console.WriteLine(str);
