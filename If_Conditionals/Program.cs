﻿
int theVal = 48;
/*
if (theVal == 50)
    Console.WriteLine("theVal is 50");
else if (theVal >=51 && theVal <= 60)
    Console.WriteLine("theVal is between 51 and 60");
else
    Console.WriteLine("theVal is something else");
*/

//If else can also be replaced by ternary operator ?:
Console.WriteLine(theVal<50 ? "theVal is small" : "theVal is large");