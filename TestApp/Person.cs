namespace HR;
public class Person{
    //data members
    private string firstName;
    public void SetFirstName(string name){
        this.firstName=name;
    }
    public string GetFirstName(){
        return this.firstName;
    }
    private String lastName;
    //Property LastName  VB syntax
    public string LastName{
        get{return this.lastName;}
        set{this.lastName=value;}
    }
    private string email;
    public  string Email{
        get{return this.email;}
        set{this.email=value;}
    }
    private string contactNumber;
    private DateTime birthDate;


    //member functions
    //constructor overloading
    public Person(){
        this.firstName="Jagan";
        this.lastName="Malave";
        this.birthDate=new DateTime(1990,4,4);
        this.email="jagan.m@gmail.com";
        this.contactNumber="9881735801";
    }

    public Person(string fName, string lName, DateTime bDate, 
                  string contact, string email ){
        this.firstName=fName;
        this.lastName=lName;
        this.birthDate=bDate;
        this.email=email;
        this.contactNumber=contact;
    }


    ~Person(){
         //logic for releasing resources which are 
         //acquired during life time of object
        //it will be automatically called by Garbage Collector
    }

    public override string ToString()
    {
        return base.ToString() + " "+
          this.firstName + " "+ this.lastName;
    }

}