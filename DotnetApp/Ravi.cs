namespace r;

class Ravi{
	private String name;
	private int rollNum;
	
	public Ravi(){
		this.name = "asd";
		this.rollNum = 3;
	}
	
	public Ravi(String name, int rollNum){
		this.name = name;
		this.rollNum = rollNum;
	}
	
	public String GetName(){
		return this.name;
	}
	
	public void SetName(String name){
		this.name = name;
	}
	
	public int GetRollNum(){
		return this.rollNum;
	}
	
	public void SetRollNum(int rollNum){
		this.rollNum = rollNum;
	}
	
	public override string ToString(){
        return base.ToString() + " "+
          this.rollNum + " "+ this.name;
    }
}