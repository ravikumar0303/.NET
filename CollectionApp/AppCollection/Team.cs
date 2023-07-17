namespace ICC {

    public class Team { 
    
    private List<Player> pl=new List<Player> ();


        public Team() {

            this.pl.Add(new Player { Name = "Dhoni", Score ="10000" });
            this.pl.Add(new Player { Name = "Vitar", Score = "45000" });
            this.pl.Add(new Player { Name = "mithali Raj", Score = "25000" });
        }
    

        public Player this[int index] {
            get { return this.pl[index]; }
            set { this.pl[index] = value;}
             
        }
    
    }


}