using System;

namespace w01
{
    

    class Program
    {
    static void Main(string[] args)
    {
double smallpizza = 6.5;
 int mediumpizza = 9;
 int largepizza = 13;

Console.WriteLine("Hello World!");
Console.WriteLine("Happy pizza Home");
Console.WriteLine("enter your name");
var name = Console.ReadLine();
Console.WriteLine("select the ype of pizza");
Console.WriteLine("\ts - small");
Console.WriteLine("\tm - medium");
Console.WriteLine("\tl - large");

switch(Console.ReadLine()){
case "s":
Console.WriteLine($"{name} selected the small pizza of ${smallpizza} ");
break;
case "m":
Console.WriteLine($"{name} selected the medium pizza of ${mediumpizza}");
break;
case "l":
Console.WriteLine($"{name} selected the large pizza ${largepizza}");
break;
}

Console.WriteLine("choose one   toppings from below  list ");
Console.WriteLine("\th - Ham");
Console.WriteLine("\tb - Beef");
Console.WriteLine("\ts - Salami");
Console.WriteLine("\tp - Pepperoni");
if (Console.ReadLine()=="h" || Console.ReadLine()=="b" || Console.ReadLine()=="s"|| Console.ReadLine()=="p" )
{
    Console.WriteLine($"you selected toppings are {Console.ReadLine()}");
}


var SUM =0;
//in an infinite loop, 

while(true){
// Prompt user for a number (or enter q to quit)
Console.WriteLine("enter a number or q to exist");
// Read the input e.g. var str = Console.ReadLine();
var read  = Console.ReadLine();
// If q then write a message and break

if(read == "q"){
Console.WriteLine("done");
 break;
}

// Echo the number
Console.WriteLine($"you entered {read}");
// Convert.ToInt32(str)
var  i = Convert.ToInt32(read);
// Update sum
SUM += i;
// Display the sum
Console.WriteLine($" your sum is {SUM}");
} 

        }
    }
}
