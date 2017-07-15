using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProFirst
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database=HMS; user id = root; password=");
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            String uname = textBox1.Text;
            String passwd = textBox2.Text;
            String cpasswd = null;
            con.Open();
            string st = "SELECT * FROM `login` where `Username` ='" + uname + "' ";
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                cpasswd = r.GetString(2);
            }
            con.Close();
            if (passwd.Equals(cpasswd))
            {
                MessageBox.Show("Succesfully logged in ");
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

    }
}