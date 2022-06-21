// See https://aka.ms/new-console-template for more information

int num;
string ans;
do
{
    
    Console.WriteLine("Enter a number you want to check");
    num = Convert.ToInt32(Console.ReadLine());
    if (num == 0)
        Console.WriteLine("Number is neither odd nor even");
    else if (num % 2 == 0)
        Console.WriteLine("Number is  EVEN");
    else
    {
        Console.WriteLine("Number is ODD");
    }

        Console.WriteLine("Do you want to continue? Enter Y/N ");
        ans = Console.ReadLine();
} while (ans == "Y" || ans == "y" || ans =="yes");

Console.ReadKey();