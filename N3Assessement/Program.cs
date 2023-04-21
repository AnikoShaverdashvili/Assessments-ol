// See https://aka.ms/new-console-template for more information

//3) შექმენით ორი გადატვირთული მეთოდი.
//პირველი მეთოდი უნდა ითვლიდეს ფართობს (სიგრძე * სიგანეზე), მეორე მეთოდი
//მოცულობას (სიგრძე * სიგანე * სიმაღლე). გადაეცით მეთოდებს შესაბამისი რაოდენობის
//პარამეტრები.


using N3Assessement;

Calculator overload = new Calculator();   //create instance of Calculator class
double area = overload.Calculate(10, 5); //call Calcumate method and give it two arguments and calculate area
double volume = overload.Calculate(10, 2, 6); //call Calcumate method and give it three arguments to calculate volume
Console.WriteLine($"Area: {area}, Volume: {volume}"); //print in console