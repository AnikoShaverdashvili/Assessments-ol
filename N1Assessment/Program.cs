// See https://aka.ms/new-console-template for more information


//1) დაწერეთ შემდეგი პროგრამა:
//კონსოლიდან შეიყვანეთ იუზერის სახელი და პაროლი. თუ დაემთხვა თქვენს მიერ შექმნილ
//იუზერს და პაროლს, კონსოლზე დაიბეჭდოს წარმატება. 5 ცდის შემდეგ კი დააბრუნოს
//შეცდომის შეტყობინება.



//set initial values for username , password and attempt count variables.
string username = "username";
string password = "password";
int attempts = 0;    


//create loop that allows to input username and password 5 times max.
while (attempts < 5)
{
    Console.Write("Enter username:");
    string myUsername = Console.ReadLine();
    Console.Write("Enter password:");
    string myPassword = Console.ReadLine();

    // If the username and password are correct print success message and break the loop
    if (username == myUsername && password == myPassword)
    {
        Console.WriteLine("Success!");
        break;
    }
    // If the username and password are incorrect attempts increases by 1 and message is counting how many tries left.
    attempts++;
    Console.WriteLine("Incorrect password or username, Attempts {0}", 5 - attempts);
}
//when attempts is 5 it shows fail message.
if (attempts == 5)
{
    Console.WriteLine("Fail");
}

