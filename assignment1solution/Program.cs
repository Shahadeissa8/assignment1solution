using System.ComponentModel.Design;

Console.WriteLine("======Shahad Eissa========");




#region q1
Console.WriteLine("======Simple adding========");
Console.WriteLine("enter num: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 3;
int adding = 0;
int i;
int SimpleAdding(int num)
{
    for (i = 1; i <= num; i++)
    {
        adding = i + adding;
    }
    Console.WriteLine("the total in simple adding is: " + adding);

    return num;
}
Console.WriteLine(SimpleAdding(num));


#endregion

#region q2
Console.WriteLine("=======Vowel count========");

string vowels = "aouieAOUIE";
Console.WriteLine("enter a string to be tested: ");
string str = Convert.ToString(Console.ReadLine());
int count = 0;
//take word
//word .contains 
//for each
foreach (char character in str)
{
    if (vowels.Contains(character))
    {
        count++;
    }
}
Console.WriteLine("The number of vowels is: " + count);
#endregion

#region q3
Console.WriteLine("=======first factorial========");
int FirstFactorial(int number)
{
    int fact = 1;

    for (int i = 1; i <= number; i++)
    {
        fact = fact*i; 
    }
    return fact;  
}
Console.WriteLine("Enter a number to calculate its factorial: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = FirstFactorial(number);
Console.WriteLine("The factorial of " + number + " is: " + result);
#endregion





Console.WriteLine("=======simple evens========");

#region q4
Console.WriteLine("Enter a number to check if all digits are even: ");
string even = Console.ReadLine(); 

bool SimpleEven(string even)
{
    foreach (char digit in even)
    {
        if (digit != '0' && digit != '2' && digit != '4' && digit != '6' && digit != '8')
        {
            return false;
        }
    }
    return true;


    bool result = SimpleEven(even);

    if (result)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }

}
#endregion


Console.WriteLine("=======one decrement========");

#region q5


#endregion