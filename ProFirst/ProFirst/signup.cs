using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProFirst
{
    public partial class signup : Form
    {
        string lid = null;
        string type = null;
        MySqlConnection con = new MySqlConnection("server = localhost; Database=HMS; user id = root; password=");

        public signup()
        {
            InitializeComponent();
        }

        public signup(string txt1, string txt2)
        {
            InitializeComponent();
            lid = txt1;
            type = txt2;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string Query = "INSERT INTO `login`(`id`, `Username`, `Password`, `UserType`) VALUES ('" + Convert.ToInt32(this.textBox3.Text) + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox4.Text + "')";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
            MessageBox.Show("Sucessfully Registered");
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            textBox3.Text = lid;
            textBox3.ReadOnly = true;
            textBox4.Text = type;
            textBox4.ReadOnly = true;
        }
    }
}
