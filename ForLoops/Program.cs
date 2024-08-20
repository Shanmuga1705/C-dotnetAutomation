int myVal = 15;
int[] nums = new int[] { 3, 14, 15, 91, 6 };
String str = "The quick brown fox";

Console.WriteLine("The basic for loop");
/*for (int i = 0; i < myVal; i++)
{
   // Console.WriteLine(nums[i]);
    Console.WriteLine("i is currently {0}",i);
}*/

foreach (int i in nums) {
    Console.WriteLine("i is currently {0}", i);
}

// To count the number of o's in the string
var count = 0;
foreach (char c in str )
{
    if (c == 'o')
        count++;
}
Console.WriteLine("Counted {0} o characters in the given string",count);


