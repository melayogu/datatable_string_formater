using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableServerSideStrFormater
{
    public partial class StrFormater : Form
    {


        IList<TextBox> arrayList=new List<TextBox>();

        int y = 0;


        public StrFormater()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //TextBox newBox = new TextBox();

            //newBox.Location = new Point(0, y);
            //newBox.Visible = true;

            //y += 30;

            //Controls.Add(newBox);

            ////newBox.Text = "{ data: '' " + newBox.Text + " '' },";

            //arrayList.Add(newBox);


            

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //string temp="";


            //foreach(TextBox t in arrayList)
            //{

            //    string t1 = "{ data:''"+t.Text+"''},";
            //    temp += t1;
            //}


            //this.textBox1.Text = temp;

            string[] temp = textBox1.Text.Replace("\r\n", ",").Split(',');

            string a = "";

            foreach(string t1 in temp)
            {
                //a += "{ data: \"" + t1.Trim() + "\"}," + Environment.NewLine;
                a += "<th>" + t1.Trim() + "</th>" + Environment.NewLine;
            }

            //{ data: "ChnName" },

            textBox2.Text = a;

            textBox2.Focus();
            textBox2.SelectAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string temp="";


            //foreach(TextBox t in arrayList)
            //{

            //    string t1 = "{ data:''"+t.Text+"''},";
            //    temp += t1;
            //}


            //this.textBox1.Text = temp;

            //string[] temp = textBox1.Text.Split(',');
            string[] temp = textBox1.Text.Replace("\r\n", ",").Split(',');

            string a = "";

            foreach (string t1 in temp)
            {
                a += "{ data: \"" + t1.Trim() + "\"}," + Environment.NewLine;                
            }

            //{ data: "ChnName" },

            textBox2.Text = a;

            textBox2.Focus();
            textBox2.SelectAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] temp = textBox1.Text.Replace("\r\n", ",").Split(',');
            //string[] temp = textBox1.Text.Split(',');
            //textBox1.Text.Replace("\r\n","")


            string a = "";

            foreach (string t1 in temp)
            {
                //a += "{ data: \"" + t1.Trim() + "\"}," + Environment.NewLine;
                a += "<td>@app." + t1.Trim() + "</td>" + Environment.NewLine;
            }

            //{ data: "ChnName" },

            textBox2.Text = a;

            textBox2.Focus();
            textBox2.SelectAll();
        }
    }
}
