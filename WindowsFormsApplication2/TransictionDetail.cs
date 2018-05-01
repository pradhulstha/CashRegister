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
    public partial class TransictionDetail : Form
    {
      
        public string transiction_file = "C:\\Users\\prash\\Desktop\\New folder\\Cash Register\\TransactionDetails.txt";
        


        public TransictionDetail()
        {
            InitializeComponent();

            readtheFile();
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterStartForm rStart = new RegisterStartForm();
            rStart.ShowDialog();
        }

        public void readtheFile()
        {
            TextReader sd = new StreamReader(@transiction_file);

            textBoxFile.Text = sd.ReadToEnd();


           
            sd.Close();
        }
     
    }
}
