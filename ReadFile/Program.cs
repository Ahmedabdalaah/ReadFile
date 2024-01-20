// See https://aka.ms/new-console-template for more information
using ReadFile;

Read r;
Console.WriteLine(" Enter the file name");

String name = Console.ReadLine();
if((name!=null))
{
    r = new Read();
    r.readf(name);
}
else
{
    Console.WriteLine( " Invalid name");
}

