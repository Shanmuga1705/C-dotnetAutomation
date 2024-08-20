// See https://aka.ms/new-console-template for more information
int i = 10;
float f = 2.0f;
decimal d = 10.0m;
bool b = true;
char c = 'a';

string s = "Vignesh";

//Declare an implicit variable
var x = 10;
var y = "Hello!";

int[] vals= new int[10];
string[] vals2 = { "one", "two", "three" };

//Print the values using a formatting string
//Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,c,b, s,f,x,y,d);

//object obj = null;
//Console.WriteLine(obj);

//Implicit data conversion
long l;
l = i;

//Explicit data conversions
float i_to_f = (float)i;
Console.WriteLine("{0}",i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}", f_to_i);
