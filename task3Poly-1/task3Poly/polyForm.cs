
namespace task3Poly
{
    public partial class ProfibilityCalculator : Form
    {
        public ProfibilityCalculator()
        {
            InitializeComponent();
        }

        private Animals[] myFarm = new Animals[10]; // Creating an Array [10] objects
        private void btnPoly_Click(object sender, EventArgs e) // Button
        {
            // Reading and grabbing data from Txt file
            string path = @"C:\Users\GGPC\Desktop\task3Poly\TextFile.txt"; // Find TextFile Direectory
            StreamReader stream = new StreamReader(path);
            string fileData = stream.ReadToEnd();
            cowMilk.Text = fileData.ToString();
            String [] lines = fileData.Split("\r\n");

            for (int i=0; i < myFarm.Length; i++)
            {
                String[] words = lines[i].Split(',');

                if (words[2].Equals("Cow")) {

                    myFarm[i] = new Cow(int.Parse(words[0]), double.Parse(words[1]));
                }
                else if (words[2].Equals("Goat"))
                {
                    myFarm[i] = new Goat(int.Parse(words[0]), double.Parse(words[1]));
                }
                else if (words[2].Equals("JerseyCow"))
                {
                    myFarm[i] = new JerseyCow(int.Parse(words[0]), double.Parse(words[1]));
                }
            }
            stream.Close(); // Stop Reading

            // user input being passed into price variable
            Prices.CowsMilkPrice = double.Parse(cowMilk.Text);
            Prices.GoatsMilkPrice = double.Parse(GoatMilk.Text);
            Prices.CowVaxPrice = double.Parse(cowVax.Text);
            Prices.JerseyCowVaxPrice = double.Parse(JerseyCowVax.Text);
            Prices.GoatVaxPrice = double.Parse(goatVax.Text);

            // Calculate Total profit
            double totProf = 0.0;
            for (int i=0; i < myFarm.Length; i++)
            {
                totProf += myFarm[i].getProf();
            }
            total_prof.Text = Convert.ToString(totProf);
            return;
        }

    }
}