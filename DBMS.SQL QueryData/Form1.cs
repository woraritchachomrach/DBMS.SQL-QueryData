using Microsoft.Data.SqlClient;
using System.Data;
namespace DBMS.SQL_QueryData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ประกาศตัวแปล
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void connect()
        {
            string server = @".\SQLEXPRESS";
            string db = "Minimart";
            string strCon = string.Format(@"Data Source={0};Initial Catalog={1};"
                            + "Integrated Security=True;Encrypt=False", server, db);
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        private void close()
        {
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            showData();
           // string sql = "select * from Products";
           // da = new SqlDataAdapter(sql,conn);
           //DataSet ds = new DataSet();
           // da.Fill(ds);
           // dataGridView1.DataSource = ds.Tables[0];

           
        }
        private void showData()
        {
            string sql = "select * from Products";
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
