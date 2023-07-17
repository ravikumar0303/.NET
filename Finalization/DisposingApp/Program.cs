using IET;



Console.WriteLine("Hello Welcome To IET ACTs");

Console.WriteLine("Before Person object is created....");

// Student s1=new Student{prn=117,FirstName="ravi",LastName="kumar"};
// Console.WriteLine("prn--> "+s1.prn+" FirstName-->"+s1.FirstName+" LastName-->"+s1.LastName);

//Apply Disposing Technique

using(Student s1=new Student{prn=117,FirstName="ravi",LastName="kumar"})
{
 Console.WriteLine("prn--> "+s1.prn+" FirstName-->"+s1.FirstName+" LastName-->"+s1.LastName);
}
