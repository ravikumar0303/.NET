namespace Drawing;

public sealed class Line:Shape{

    public Point startPoint;
    public Point endPoint;

    //Constructor overloading

    //Static Polymorphism
    public Line():base(){
        this.startPoint=new Point(1,4);
        this.endPoint=new Point(45,67);
    }
    public Line(Point pt1, Point pt2, string c, int w):base(c,w){
        this.startPoint=pt1;
        this.endPoint=pt2;
       // this.color=c;
       // this.width=w;
    }

    //Runtime Polymorphism
    //Method overrding
    public override void Draw()
    {
       
       Console.WriteLine("Drawing Line");
       Console.WriteLine(this.color + " "+ this.width+" "
                         +"(" +this.startPoint.x+ ","+ this.startPoint.y +"),"+
                         "(" +this.endPoint.x+ ","+ this.endPoint.y +")");         
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("(" +this.startPoint.x+ ","+ this.startPoint.y +"),"+
                         "(" +this.endPoint.x+ ","+ this.endPoint.y +")");         

    }
}