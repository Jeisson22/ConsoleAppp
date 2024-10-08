// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hola, como vamos");
Console.WriteLine("------------- \n");

Console.WriteLine("What's your name? Please Write your full name");
String   fullUserName = Console.ReadLine();

Console.WriteLine("Hello " + fullUserName + ", Welcome to Platzi");
Console.WriteLine("------------- \n");

int number1, number2;

Console.WriteLine("Input the first number");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 * number2;
Console.WriteLine("The result Is: " + result);

Console.WriteLine("------------- \n");

bool value1 = true;
bool value2 = false;    

// && and , || or, ! diferente

bool resultado = value1 && value2;
Console.WriteLine("The result to operation is: " + resultado);

