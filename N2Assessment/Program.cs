// See https://aka.ms/new-console-template for more information


//2) დაწერეთ პროგრამა, რომელიც კონსოლიდან შეყვანილ რიცხვს გადაიყვანს ორობით ფორმატში.
//შედეგი დაბეჭდეთ კონსოლზე


Console.Write("Enter number:");
int num = int.Parse(Console.ReadLine());

if (num < 0) //check if number is negative
{
    Console.WriteLine("Please enter positive number"); //shows message to enter positive number and exits program 
}
else
{
    string binary = "";
    // use a do-while loop to convert the number to binary
    do
    {
        int bit = num % 2;
        binary = bit + binary;
        num /= 2;
    }
    while (num != 0); //when i enter 0 loop still makes one iteration.
    Console.WriteLine($"given number converted to binary is {binary}");
}