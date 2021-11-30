// See https://aka.ms/new-console-template for more information


//Create a dotnet console application to emulate a calculator.

static void Main()

{
char Operators;
double fun1, fun2;

Console.WriteLine("Choose Operation method (+, -, *, /)");
Operators = Console.ReadLine()[0];

Console.WriteLine("Enter the two number values to calculate");
fun1 = Convert.ToDouble(Console.ReadLine());
fun2 = Convert.ToDouble(Console.ReadLine());


    switch(Operators)
     {
        case '+':
            Console.WriteLine("{0} + {1} = {2}", fun1, fun2,(fun1 + fun2));
        break;

        case '-':
            Console.WriteLine("{0} - {1} = {2}", fun1, fun2, (fun1 - fun2));
         break;

        case '*':
            Console.WriteLine("{0} * {1} = {2}", fun1, fun2, (fun1 * fun2));
        break;
        
        case '/':
            Console.WriteLine("{0} / {1} = {2}", fun1, fun2, (fun1 / fun2));
        break;
        default:
            Console.WriteLine("Not a valid operation");
        break;

        }  


Console.WriteLine("Press any key to exit the calculator");
Console.ReadKey();
}
Main();


//Your application should (mvp):
//-Be able to accept multiple numbers
//-Perform a selected operation on those numbers
//-Display the result of the operation
//-Repeat until the user chooses to exit