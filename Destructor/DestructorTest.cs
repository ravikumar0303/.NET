namespace CSharpDestructor{

   class Person{

            int id;
           String name;

    public Person(){
        id=117;
        name="ravi";
    }


      public Person(int id, String name){
            this.id=id;
            this.name=name;
        }


        // public int id{get;set;}
        // public String Name{get;set;}

      public void getId(){
           Console.WriteLine("id--"+id);

       }
        
        public void getName(){
           Console.WriteLine("Name-->"+name);
           
       }

//      public Person(){
//        Console.WriteLine("Constructor called");
//    }

    ~Person(){

        Console.WriteLine("Destructure called");
    }

   }
}