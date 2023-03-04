class ComaparingIntegers
{
    static void Main(string[] args)
    {
        // declaring variables 
        int firstNumber;
        int secondNumber;

        // prompting user and taking input for firstNumber
        Console.Write("Enter First Number:  ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for secondNumber
        Console.Write("Enter Second Number:  ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // if firstNumber is greater than secondNumber
        if (firstNumber > secondNumber) 
        {
            Console.Write(firstNumber + " Is Larger");
        }

        // if firstNumber is smaller than secondNumber
        else if (firstNumber < secondNumber)
        {
            Console.Write(secondNumber + " Is Larger");
        }

        // both numbers are equal
        else
        {
            Console.Write("These Numbers Are Equal");
        }

        Console.WriteLine();    // just for spacing purpose
    }
}
