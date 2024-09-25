CalculatorApp();

void CalculatorApp()
{
    // Declating intergers and initialzing as 0
    int firstNumber = 0;
    int secondNumber = 0;
    int sumTotal = 0;
    int choice = 0;

    // Obtaining first interger input
    Console.WriteLine("Type in the first number followed by the enter key.");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    // Obtaining second interger input
    Console.WriteLine("Type in the second number followed by the enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //Using a loop to obtain operator for sum
    Console.WriteLine("Please select an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    //Convert choice selection into integer
    choice = Convert.ToInt32(Console.ReadLine());

    // creating the sum for two interger inputs based on operator chosen
    if (choice == 1)
    {
        sumTotal = firstNumber + secondNumber;
        Console.WriteLine($"The sum of {0}+{1}={2}", firstNumber + secondNumber, sumTotal);
    }
    else if (choice == 2)
    {
        sumTotal = firstNumber - secondNumber;
        Console.WriteLine($"The sum of {firstNumber}-{secondNumber}={sumTotal}", firstNumber - secondNumber, sumTotal);
    }
    else if (choice == 3)
    {
        sumTotal = firstNumber / secondNumber;
        Console.WriteLine($"The sum of {firstNumber}/{secondNumber}={sumTotal}", firstNumber / secondNumber, sumTotal);
    }
    else if (choice == 4)
    {
        sumTotal = firstNumber * secondNumber;
        Console.WriteLine($"The sum of {firstNumber}*{secondNumber}={sumTotal}", firstNumber * secondNumber, sumTotal);
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }
}