using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class RegisterStartForm : Form
    {
        public int quater, nickel, dime, penny = 0;
        public string filename = "C:\\Users\\prash\\Desktop\\New folder\\Cash Register\\Register.txt"; 



        public RegisterStartForm()
        {
            InitializeComponent();
            readData();
            printTheLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(!String.IsNullOrEmpty(quaterBox.Text))
                  quater += Convert.ToInt32(quaterBox.Text);

            if(!String.IsNullOrEmpty(dimeBox.Text))
                dime += Convert.ToInt32(dimeBox.Text);

            if(!String.IsNullOrEmpty(niceklBox.Text))
                nickel += Convert.ToInt32(niceklBox.Text);

            if(!String.IsNullOrEmpty(pennyBox.Text))
             penny += Convert.ToInt32(pennyBox.Text);

            StreamWriter outputFile = new StreamWriter(@filename);
           
            outputFile.WriteLine("Quater " + quater);
            outputFile.WriteLine("Dime " + dime);
            outputFile.WriteLine("Nickel " + nickel);
            outputFile.WriteLine("Penny " + penny);

            clearAllField();

            outputFile.Close();
            readData();
            printTheLabel();
        }

        private void readData(){
        StreamReader sd = new StreamReader(@filename);

           string text = sd.ReadLine();
           string[] lines = text.Split(' ');
           quater = int.Parse(lines[1]);
            text = sd.ReadLine();
            lines = text.Split(' ');
            dime = int.Parse(lines[1]);
            text = sd.ReadLine();
            lines = text.Split(' ');
            nickel = int.Parse(lines[1]);

            text = sd.ReadLine();
           lines = text.Split(' ');
            penny = int.Parse(lines[1]);


            sd.Close();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransictionDetail transc = new TransictionDetail();
            transc.ShowDialog();

        }

        private void printTheLabel()
        {
            quaterLabel.Text = quater.ToString();
            nickelLabel.Text = nickel.ToString();
            dimeLabel.Text = dime.ToString();
            pennyLabel.Text = penny.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();

            register.ShowDialog();
        }

        private void clearAllField()
        {
            quaterBox.Text = "";
            dimeBox.Text = "";
            niceklBox.Text = "";
            pennyBox.Text = "";
        }
    }
}
