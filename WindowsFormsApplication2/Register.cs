using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Register : Form
    {
        int quaterCount = 0, dimeCount = 0, nickelCount = 0, pennyCount = 0;
        decimal  tempCash ;
        decimal change, cash, amount;
        public int quaterEnd, nickelEnd, dimeEnd, pennyEnd;

        public string filename = "C:\\Users\\prash\\Desktop\\New folder\\Cash Register\\Register.txt";

        public string transiction_file = "C:\\Users\\prash\\Desktop\\New folder\\Cash Register\\TransactionDetails.txt";

        public Register()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterStartForm r2 = new RegisterStartForm();
            r2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

             cash = decimal.Parse(textBox2.Text);
             amount = decimal.Parse(textBox1.Text);
             
             change = (cash - amount);

             label8.Text = (change.ToString());

             tempCash = (change);
             

             MessageBox.Show("\nChange: " + tempCash.ToString() + "\nCash: " + cash.ToString() + "\nAmount: " + amount.ToString());

             if (quaterCheckBox.Checked || dimeCheckBox.Checked || nickelCheckBox.Checked || pennyCheckBox.Checked)
             {

                                  
                     if (quaterCheckBox.Checked)
                     {
                         checkQuater();
                     }

                     if (dimeCheckBox.Checked)
                     {
                         checkDime();
                     }

                     if (nickelCheckBox.Checked)
                     {
                         checkNickel();
                     }

                     if(pennyCheckBox.Checked)
                     {
                         checkPenny();
                     }
                 
             }
             else
             {
                 MessageBox.Show("Enter Your Preferences. ");
             }

            quaterLabelDisplay.Text = quaterCount.ToString();
            nickelLabelDisplay.Text = nickelCount.ToString();
            dimeLabelDisplay.Text = dimeCount.ToString();
            pennyLabelDisplay.Text = pennyCount.ToString();

            readData();
            updateTheFile();
            
        }


        private void checkQuater()
        {

            while (tempCash >= 0.25M)
            {
                  tempCash = tempCash - 0.25M;
                    ++quaterCount;
            }
        }

        private void checkDime()
        {
            while (tempCash >= 0.10M)
            {
                    tempCash = tempCash - 0.10M;
                    ++dimeCount;
                
            }
        }

        private void checkNickel()
        {
            while (tempCash >= 0.05M)
            {
                  tempCash = tempCash - 0.05M;
                  ++nickelCount;
                
            }
        }

        private void checkPenny(){
            while (tempCash >= 0.01M)
                         {
                             tempCash = tempCash - 0.01M;
                             ++pennyCount;
                         }
        }

        private void updateTheFile()
        {
            quaterEnd -= quaterCount;
            dimeEnd -= dimeCount;
            nickelEnd -= nickelCount;
            pennyEnd -= nickelCount;

            StreamWriter outputFile = new StreamWriter(@filename);


            outputFile.WriteLine("Quater " + quaterEnd);
            outputFile.WriteLine("Dime " + dimeEnd);
            outputFile.WriteLine("Nickel " + nickelEnd);
            outputFile.WriteLine("Penny " + pennyEnd);

            outputFile.Close();
            readData();
            printInTheLog();
        }

        private void readData()
        {
            StreamReader sd = new StreamReader(@filename);

            string text = sd.ReadLine();
            string[] lines = text.Split(' ');
            quaterEnd = int.Parse(lines[1]);
            text = sd.ReadLine();
            lines = text.Split(' ');
            nickelEnd = int.Parse(lines[1]);
            text = sd.ReadLine();
            lines = text.Split(' ');
            dimeEnd = int.Parse(lines[1]);

            text = sd.ReadLine();
            lines = text.Split(' ');
            pennyEnd = int.Parse(lines[1]);


            sd.Close();


        }

        private void printInTheLog()
        {
            StreamWriter writeTrans = new StreamWriter(@transiction_file, true);

            string dd = DateTime.Today.ToString("MM/dd/yyyy");

            writeTrans.WriteLine("");
            writeTrans.Write(textBox2.Text + "\t");
            writeTrans.Write(textBox1.Text + "\t");
            writeTrans.Write(change.ToString() + "\t");
            writeTrans.WriteLine(dd);
            writeTrans.Write("------------------------------------------------------------");

            writeTrans.Close();

        }
    }

   


}
