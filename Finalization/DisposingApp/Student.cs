namespace IET{

  public class Student:IDisposable{


     public Student(){

     }
         public int prn{get;set;}
         public String FirstName{get;set;}
         public String LastName{get;set;}


         public override string ToString()
         {
             return base.ToString ();

         }

         public void Dispose(){

              Console.WriteLine("Resources are relased instantly....");
            
            //    GC.SuppressFinalize(this);

         }
     
       //Destructor---one class Only one Destructor
   ~Student(){

       //Releasing resources which have been allocated
        //during lifetime of this object

   }


  }


}
