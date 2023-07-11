namespace ravi;

public class Student{

 private int prn;
 private String sname;
 private string mobile;
 private DateTime birthDate;

 public Student(){
   this.prn=117;
   this.sname="ravi";
   this.mobile="12365414";
    this.birthDate = new DateTime();
  }
   
   public Student (int prn,string sname,string mobile, DateTime bDate){

     this.prn=prn;
     this.sname=sname;
     this.mobile=mobile;
     this.birthDate=bDate;
   
   }

   public int GetPrn(){
		return this.prn;
	}
	
	public void SetPrn(int prn){
		this.prn = prn;
	}


   public void SetSname(string sname){
    this.sname=sname;
  }
  public String GetSname(){
    return this.sname;
  }

  public void SetMobile(string mobile){
    this.mobile=mobile;
  }
  public String GetMobile(){
    return this.mobile;
  }

  public void SetBirthDate( DateTime bDate){

    this.birthDate=bDate;
  }
  public DateTime GetBirthDate( ){

    return this.birthDate;
  }
  
  // public String Mobile{
  //   get{return this.mobile;}
  //   set{this.mobile=value;}
  // }


  // private DateTime birthDate;
  // public DateTime BirthDate{
  // get{return this.birthDate;}
  // set{this.birthDate=value;}    
  // }
  
  

   public override string ToString(){
     
      return ("Student PRN--> "+this.prn+", Student Name-> "+this.sname+", Student Mobile-> "+this.mobile);
   }
   
}

  