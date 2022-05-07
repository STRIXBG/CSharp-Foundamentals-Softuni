int smallestNum;
int num1 = int.Parse(Console.ReadLine());
smallestNum = num1;
int num2 = int.Parse(Console.ReadLine());
if(smallestNum > num2) smallestNum = num2;
int num3 = int.Parse(Console.ReadLine());
if (smallestNum > num3) smallestNum = num3;
Console.WriteLine(smallestNum);
