namespace UE02_Adresse
{
    public partial class Form1 : Form
    {
 
        private int plz = 8411;
        //not changeable 
        const int MAXWERT = 75; 
        //Aufzählungen 
        enum farbe : int
        {
            rot = 1, 
            gelb = 2, 
            blau = 3
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAddress_Click(object sender, EventArgs e)
        {
            //int, float, double, short, long, string, byte, boolean

            String firstname = "Michi";
            
            String lastname;
            lastname = "Mayer";

            String street = "Schrötten";
            String city = "Hengsberg";
            int streetNr = 9;
            
            

            lblAddress.Text = firstname + " " + lastname + "\n"
                            + street + " " + streetNr.ToString() + "\n" 
                            + plz.ToString() + " " +  city;

           // <, >, <=, >=, == gleich, != ungleich 
           // == --> Werte vergleichen
           // = --> Werte zuweisen

            //&& und; || oder; ^ XOR; ! NOT;
            
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            plz += 1;
            
        }
    }
}