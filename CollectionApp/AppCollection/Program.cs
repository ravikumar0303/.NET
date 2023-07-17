using ICC;


using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Student s1 = new Student { prn = 117, FirstName = "ravi", LastName = "kumar" };
 Console.WriteLine("prn--> "+s1.prn+" FirstName-->"+s1.FirstName+" LastName-->"+s1.LastName);

Team india = new Team();

Player thePlayer = india[0];
Console.WriteLine(thePlayer);

india[0]= new Player { Name = "VVS Laxman", Score = "89890" };
Player thePlayer1 = india[0];
Console.WriteLine(thePlayer1.Name);

/////////////////////////////////Array................///

int [] marks = { 45,58,65,25,45,85,46,48,85};
Array.Sort(marks);
foreach (var mark in marks) { 

Console.WriteLine(mark);
}
Console.WriteLine("jerami bhai........");

Array.Reverse(marks);
foreach (var j in marks) {

    Console.WriteLine(j);
}
    
