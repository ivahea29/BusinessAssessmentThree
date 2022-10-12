namespace GuiAppTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
        private Boolean isPrime(int n)
        {
            Boolean b = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if ((n % i) == 0)
                {
                    b = false;
                    break;
                }
            }
            return (b);
        }
        private void btnPrime_Click(object sender, EventArgs e)
        {
 
            int low = int.Parse(textBox1.Text);
            int high = int.Parse(textBox2.Text);
            int count = 0;

            for (int i = low; i <= high; i = i + 1)
            {
                if (isPrime(i))                    
                {                  
                    outputPrime.Text += i.ToString() + " ";
                    count++;
                    if (count == 5)
                    {
                        outputPrime.Text += "\r\n";
                        count=0;
                    }
                }
            }

            return;
        }
    }
}