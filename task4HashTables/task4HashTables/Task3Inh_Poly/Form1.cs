
namespace Task3Inh_Poly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Read data from the Text File Data.Txt
            string path = @"C:\Users\GGPC\Desktop\AppDev\task3Poly\task3Poly\Task3Inh_Poly\data.txt";
            StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            String[] lines = filedata.Split("\r\n");

            // Declare Dictionary
            Dictionary<int, Animal> Dict = new Dictionary<int, Animal>();

            // Create object and insert into dictionary based on data types
            for(int i = 0; i < lines.Length; i++)
            {
                String[] line = lines[i].Split(",");

                // Lines 0 = ID, Line 1 = Milk, Line 2 = Animals
                if (line[2].Equals("Cow"))
                {
                    int id = int.Parse(line[0]);
                    double amtMilk = double.Parse(line[1]);
                    Animal a = new Cow(id, amtMilk);
                    Dict.Add(id, a);
                }
                else if (line[2].Equals("Jersey_Cow"))
                {
                    int id = int.Parse(line[0]);
                    double amtMilk = double.Parse(line[1]);
                    Animal a = new Jersey_Cow(id, amtMilk);
                    Dict.Add(id, a);
                }
                stream.Close();

                // Change the user input into the prices variables in the prices class
                // pass the user input into the price variables in the price class.
                Prices.CowsMilkPrice = double.Parse(cow_milk_input.Text);
                Prices.GoatsMilkPrice = double.Parse(goat_milk_input.Text);
                Prices.CowVaxPrice = double.Parse(cow_vax_input.Text);
                Prices.JerseyCowVaxPrice = double.Parse(jersey_vax_input.Text);
                Prices.GoatVaxPrice = double.Parse(goat_vax_input.Text);

                double total = 0;
                // Total profit
                foreach(KeyValuePair<int, Animal> elm in Dict)
                {
                    total += elm.Value.getProf();
                }
                string ftotal = total.ToString();
                total_prof_output.Text = Convert.ToString(ftotal);
                return;
            }
        }
    }
}