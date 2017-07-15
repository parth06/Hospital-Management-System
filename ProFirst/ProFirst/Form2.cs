using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProFirst
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Database=HMS; user id = root; password=;Convert Zero Datetime=True");
        MySqlDataAdapter sda;
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
            listPanel.Add(panel9);
            listPanel.Add(panel10);
            listPanel.Add(panel11);
            listPanel.Add(panel12);
            index = 0;
            listPanel[index].BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string st = "SELECT * FROM `patientreg`";
            int did = 0;
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                did = r.GetInt16(0);
            }
            r.Close();
            con.Close();
            did += 1;
            textBox1.Text = did.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string st = "SELECT * FROM `doctorreg`";
            int did = 0, lid = 0;
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                did = r.GetInt16(0);
            }
            r.Close();
            string st1 = "SELECT * FROM `login`";
            MySqlCommand cmd = new MySqlCommand(st1, con);
            MySqlDataReader r1 = cmd.ExecuteReader();
            while (r1.Read())
            {
                lid = r1.GetInt16(0);
            }
            r1.Close();
            con.Close();
            did += 1;
            lid += 1;
            textBox12.Text = did.ToString();
            textBox13.Text = lid.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string st = "SELECT * FROM `staff`";
            int did = 0, lid = 0;
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                did = r.GetInt16(0);
            }
            r.Close();
            string st1 = "SELECT * FROM `login`";
            MySqlCommand cmd = new MySqlCommand(st1, con);
            MySqlDataReader r1 = cmd.ExecuteReader();
            while (r1.Read())
            {
                lid = r1.GetInt16(0);
            }
            r1.Close();
            con.Close();
            did += 1;
            lid += 1;
            textBox20.Text = did.ToString();
            textBox14.Text = lid.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String gender=null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
                radioButton2.Checked = false;
            }
            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
                radioButton1.Checked = false;
            }
            string Query = "INSERT INTO `patientreg`(`Pid`, `Name`, `Gender`, `DoB`, `BloodGroup`, `allergy`, `phone`, `Address`) VALUES ('" + Convert.ToInt32(this.textBox1.Text) + "','" + this.textBox2.Text + "','" + gender + "','" + this.dateTimePicker1.Text + "','"+this.textBox3.Text+ "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "')";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            String gender = null;
            if (radioButton4.Checked)
            {
                gender = radioButton4.Text;
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked)
            {
                gender = radioButton4.Text;
                radioButton3.Checked = false;
            }
            string Query = "INSERT INTO `doctorreg`(`Did`, `Name`, `Login_id`, `Gender`, `Department`, `DoB`, `Email`, `Mno`, `Qualification`) VALUES ('" + Convert.ToInt32(this.textBox12.Text) + "','" + this.textBox11.Text + "','" + this.textBox13.Text + "','" + gender + "','" + this.textBox10.Text + "','" + this.dateTimePicker2.Text + "','" + this.textBox9.Text + "','" + this.textBox8.Text + "','" + this.textBox7.Text + "')";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
            signup sup = new signup(textBox13.Text, "Doctor");
            sup.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();

            string Query = "INSERT INTO `staff`(`Sid`, `name`, `Login_id`, `phone`, `DoB`, `Address`) VALUES ('" + Convert.ToInt32(this.textBox12.Text) + "','" + this.textBox19.Text + "','" + this.textBox14.Text + "','" + this.textBox16.Text + "','" + this.dateTimePicker3.Text + "','" + this.textBox15.Text + "')";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
            signup sup = new signup(textBox14.Text, "Staff");
            sup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            dateTimePicker1.Value = DateTime.Parse("4/4/2017");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            dateTimePicker2.Value = DateTime.Parse("4/4/2017");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox12.Text = null;
            textBox19.Text = null;
            textBox14.Text = null;
            textBox16.Text = null;
            dateTimePicker3.Value = DateTime.Parse("4/4/2017");
            textBox15.Text = null;
        }



        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 0;
            listPanel[index].BringToFront();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            index = 1;
            listPanel[index].BringToFront();   
        }
        
        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            index = 2;
            listPanel[index].BringToFront();
            
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 3;
            listPanel[index].BringToFront();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 4;
            listPanel[index].BringToFront();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            index = 5;
            listPanel[index].BringToFront();
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string CmdString = "SELECT * FROM `patientreg`";
            sda = new MySqlDataAdapter(CmdString, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string CmdString = "SELECT * FROM `doctorreg`";
            sda = new MySqlDataAdapter(CmdString, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string CmdString = "SELECT * FROM `staff`";
            sda = new MySqlDataAdapter(CmdString, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            int dsid = Convert.ToInt16(textBox23.Text);
            string st = "SELECT * FROM `staff` where `Sid`='" + dsid + "'";
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                textBox23.Text = r.GetInt16(0).ToString();
                textBox22.Text = r.GetString(1);
                textBox18.Text = r.GetInt16(2).ToString();
                textBox21.Text = r.GetString(3);
                dateTimePicker4.Value = r.GetDateTime(4);
                textBox17.Text = r.GetString(5);
            }
            r.Close();
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            int dsid = Convert.ToInt16(textBox23.Text);
            string Query = "UPDATE `staff` SET `phone`='" + textBox21.Text + "',`DoB`='" + this.dateTimePicker4.Text + "',`Address`='" + textBox17.Text + "'WHERE `Sid`='" + dsid + "'";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox23.Text = null;
            textBox22.Text = null;
            textBox18.Text = null;
            textBox21.Text = null;
            dateTimePicker4.Value = DateTime.Parse("4/4/2017");
            textBox17.Text = null;
        }

        private void updateStaffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 8;
            listPanel[index].BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            int dpid=Convert.ToInt16(textBox28.Text);
            string st = "SELECT * FROM `patientreg` where `pid`='" + dpid + "' ";
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                textBox28.Text = r.GetInt16(0).ToString();
                textBox27.Text = r.GetString(1);
                if (r.GetString(2).Equals("Male"))
                {
                    radioButton6.Checked = true;
                }
                else
                    radioButton5.Checked = true;
                dateTimePicker5.Value = r.GetDateTime(3);
                textBox26.Text = r.GetString(4);
                textBox25.Text = r.GetString(5);
                textBox29.Text = r.GetString(6);
                textBox24.Text = r.GetString(7);
            }
            r.Close();
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            con.Open();
            String gender = null;
            int dpid = Convert.ToInt16(textBox28.Text);
            if (radioButton6.Checked)
            {
                gender = radioButton6.Text;
                radioButton5.Checked = false;
            }
            if (radioButton5.Checked)
            {
                gender = radioButton5.Text;
                radioButton6.Checked = false;
            }
            string Query = "UPDATE `patientreg` SET `DoB`='" + this.dateTimePicker5.Text + "',`BloodGroup`='" + this.textBox26.Text + "',`allergy`='" + this.textBox25.Text + "',`phone`='" + this.textBox29.Text + "',`Address`='" + this.textBox24.Text + "' WHERE `Pid`='" + dpid + "'";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox28.Text = null;
            textBox27.Text = null;
            radioButton6.Checked = true;
            dateTimePicker5.Value = DateTime.Parse("4/4/2017");
            textBox26.Text = null;
            textBox25.Text = null;
            textBox29.Text = null;
            textBox24.Text = null;
        }


        private void updatePatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 6;
            listPanel[index].BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            con.Open();
            int ddid = Convert.ToInt16(textBox36.Text);
            string st = "SELECT * FROM `doctorreg` where `Did`='" + ddid + "'";
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                textBox36.Text = r.GetInt16(0).ToString();
                textBox35.Text = r.GetString(1);
                textBox30.Text = r.GetInt16(2).ToString();
                if (r.GetString(3).Equals("Male"))
                {
                    radioButton8.Checked = true;
                }
                else
                    radioButton7.Checked = true;
                textBox34.Text = r.GetString(4);
                dateTimePicker6.Value = r.GetDateTime(5);
                textBox33.Text = r.GetString(6);
                textBox32.Text = r.GetString(7);
                textBox31.Text = r.GetString(8);
            }
            r.Close();
            con.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            con.Open();
            String gender = null;
            int ddid = Convert.ToInt16(textBox36.Text);
            if (radioButton8.Checked)
            {
                gender = radioButton8.Text;
                radioButton7.Checked = false;
            }
            if (radioButton7.Checked)
            {
                gender = radioButton7.Text;
                radioButton8.Checked = false;
            }
            string Query = "UPDATE `doctorreg` SET `Department`='" + textBox34.Text + "',`DoB`='" + this.dateTimePicker6.Text + "',`Email`='" + textBox33.Text + "',`Mno`='" + textBox32.Text + "',`Qualification`='" + textBox31.Text + "' WHERE `did`='" + ddid + "' ";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox36.Text = null;
            textBox35.Text = null;
            textBox30.Text = null;
            radioButton8.Checked = true;
            textBox34.Text = null;
            dateTimePicker6.Value = DateTime.Parse("4/4/2017");
            textBox33.Text = null;
            textBox32.Text = null;
            textBox31.Text = null;
        }

        private void updateDoctorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 7;
            listPanel[index].BringToFront();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string st = "SELECT * FROM `inpatient`";
            int cid = 0;
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                cid = r.GetInt16(0);
            }
            r.Close();
            con.Close();
            cid += 1;
            textBox40.Text = cid.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "INSERT INTO `inpatient`(`id`, `P_id`, `DateOfAdmit`, `diseases`, `Roomno`) VALUES ('" + Convert.ToInt32(this.textBox40.Text) + "','" + Convert.ToInt16(this.textBox38.Text) + "','" + this.dateTimePicker7.Text + "','" + this.textBox39.Text + "','" + Convert.ToInt16(this.textBox37.Text)+ "')";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
            MessageBox.Show("Sucessfully Submitted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox37.Text = null;
            textBox38.Text = null;
            textBox39.Text = null;
            textBox40.Text = null;
            dateTimePicker7.Value = DateTime.Parse("4/4/2017");
        }

        private void admitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 9;
            listPanel[index].BringToFront();
        }

        private void dischargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 10;
            listPanel[index].BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox42.Text = null;
            textBox43.Text = null;
            textBox44.Text = null;
            dateTimePicker8.Value = DateTime.Parse("4/4/2017"); 
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string st = "SELECT * FROM `outpatient`";
            int cid = 0;
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                cid = r.GetInt16(0);
            }
            r.Close();
            con.Close();
            cid += 1;
            textBox44.Text = cid.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "INSERT INTO `outpatient`(`id`, `cid`, `OutDate`, `Remarks`) VALUES ('" + Convert.ToInt32(this.textBox44.Text) + "','" + Convert.ToInt16(this.textBox42.Text) + "','" + this.dateTimePicker8.Text + "','" + this.textBox43.Text + "')";
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            con.Close();
            MessageBox.Show("Sucessfully Submitted");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt16(textBox41.Text);
            con.Open();
            panel13.Visible = true;
            DateTime doa = DateTime.Parse("4/4/2017");
            DateTime dod ;
            int pid = 0, rno = 0, days=0 ,amount = 0 ;

            string st = "SELECT * FROM `inpatient` where `id`='" + cid + "'";
            MySqlCommand cmd1 = new MySqlCommand(st, con);
            MySqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                pid = r.GetInt16(1);
                doa = r.GetDateTime(2);
                rno = r.GetInt16(4);
                textBox46.Text = doa.ToString();
                textBox49.Text = pid.ToString();
            }
            r.Close();

            st = "SELECT * FROM `outpatient` where `cid`='" + cid + "'";
            cmd1 = new MySqlCommand(st, con);
            r = cmd1.ExecuteReader();
            while (r.Read())
            {
                dod = r.GetDateTime(2);
                textBox47.Text = dod.ToString();
                days = Convert.ToInt16((dod - doa).TotalDays);
                textBox50.Text = days.ToString();
            }
            r.Close();

            st = "SELECT * FROM `room` where `id`='" + rno + "'";
            cmd1 = new MySqlCommand(st, con);
            r = cmd1.ExecuteReader();
            while (r.Read())
            {
                amount = r.GetInt16(2);
                textBox51.Text = r.GetString(1);
            }
            r.Close();
            amount = days *amount;
            textBox48.Text = amount.ToString();

            st = "SELECT * FROM `patientreg` where `Pid`='" + pid + "'";
            cmd1 = new MySqlCommand(st, con);
            r = cmd1.ExecuteReader();
            while (r.Read())
            {
                textBox45.Text = r.GetString(1);
            }
            r.Close();
            con.Close();
        }

        private void showBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 11;
            listPanel[index].BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
