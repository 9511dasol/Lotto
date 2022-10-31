using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace OSS_HomeWork
{
    public partial class Form1 : Form
    {
        int count = 0;
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsNullString(string str)
        {
            return string.IsNullOrEmpty(str); 
        }
        private int IsInt(object obj)
        {
            if(obj == null) return 0;

            int check = 0;
            bool bch = int.TryParse(obj.ToString(), out check);

            if(!bch) return 0;

            return 0;
        }

        private string
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
