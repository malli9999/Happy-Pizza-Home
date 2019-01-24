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
 double cost = 0;
double  tax = 1.6;
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
cost=smallpizza;
break;
case "m":
Console.WriteLine($"{name} selected the medium pizza of ${mediumpizza}");
cost=mediumpizza;
break;
case "l":
Console.WriteLine($"{name} selected the large pizza ${largepizza}");
cost=largepizza;
break;
}

Console.WriteLine("choose one   toppings from below  list ");
Console.WriteLine("\th - Ham");
Console.WriteLine("\tb - Beef");
Console.WriteLine("\tc - chicken");
Console.WriteLine("\tp - Pepperoni");
var temp = Console.ReadLine();
if (temp =="h")
{
    Console.WriteLine($"you selected toppings are Ham");
}
else if(temp =="b"){
    Console.WriteLine($"you selected toppings are Beef");
}
else if(temp == "c")
{
        Console.WriteLine($"you selected toppings are Chicken");

}
else if (temp == "p"){
        Console.WriteLine($"you selected toppings are Pepperoni");

}

cost+=tax;


//in an infinite loop, 
bool t = true;
while(t  ){
// Prompt user for a number (or enter q to quit)
Console.WriteLine("Enter q to exit and show the bill");
// Read the input e.g. var str = Console.ReadLine();
var read  = Console.ReadLine();
// If q then write a message and break

if(read == "q"){
    Console.WriteLine("*****************************");
Console.WriteLine("done, your bill is: "+cost);
    Console.WriteLine("*****************************");

 break;
}

} 

        }
    }
}
