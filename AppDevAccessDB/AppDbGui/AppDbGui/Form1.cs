using System.Data;
using System.Data.OleDb;

namespace AppDbGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tableName = inputQry.Text;

            if (inputQry != null)
            {
                ReadAccessDB(tableName);
            }
        } 

        public void ReadAccessDB(String name)
        {
            String connStr = @"Provider=Microsoft.ACE.OLEDB.12.0; 
                             Data Source = C:\Wintec 2022\AppDev\Practice\FarmInformation\FarmInfomation.accdb; 
                             Persist Security Info = False";
            
            //String errMsg = "No data found.";
            String query = $"select * from [{name}]";
            OleDbConnection connect = new OleDbConnection(connStr);
            OleDbCommand command = new OleDbCommand(query, connect);
            connect.Open();
            OleDbDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            outputQry.DataSource = dataTable.DefaultView;
        }
        
    }
}