using Drawing;
using TeamBuilding;

int width=5;
string color="red";
Point start_point1=new Point(34,56);
Point end_point1=new Point(234,546);
Console.WriteLine("Hello, World!");

Line l1=new Line(start_point1,end_point1,color, width );

Point start_point2=new Point(56,5);
Point end_point2=new Point(100,100);
Line l2=new Line(start_point2,end_point2,color, width );

Shape shape1=l1;
Shape shape2=l2;
l1.Draw();
l2.Draw();

shape1.Draw();
shape2.Draw();



Leader ldr1=Leader.GetLeader();
Leader ldr2=Leader.GetLeader();


Console.WriteLine( "no. of leaders= "+Leader.count);
