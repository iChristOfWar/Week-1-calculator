// Obtaining first interger input
Console.WriteLine("Type in the first number followed by the enter key.");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// Obtaining second interger input
Console.WriteLine("Type in the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// creating the sum for two interger inputs
int sumTotal = firstNumber + secondNumber;

//Outputting the total sum & result
Console.WriteLine(" The sum of {0}+{1}={2}" , firstNumber , secondNumber , sumTotal);
