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

namespace upisivanje_podataka2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string godina_Rodjenja = textBox3.Text;
            string email = textBox4.Text;

            if (string.IsNullOrEmpty(ime) && string.IsNullOrEmpty(prezime)  && string.IsNullOrEmpty(godina_Rodjenja) && string.IsNullOrEmpty(email))
            {
                MessageBox.Show(" unesite podatke koje vas traze.", "ovo je upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
           if (!IsValidEmail(email))
            {
                MessageBox.Show("upisite vas ispravni e-mail.", "ovo je upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;

            } 
           string csvData = $"{ime},{prezime},{godina_Rodjenja}, {email}";
            string filePath = "korisnicki_podaci.csv";
        
        try
            {
                using (StreamWriter streamwriter = File.AppendText(filePath))
                {
                    streamwriter.WriteLine(csvData);
                }
                
            }
        private bool IsValidEmail(string email)
        {
            string
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
