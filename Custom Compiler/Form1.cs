using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Custom_Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string evaluate()
        {
            object result = CSharpScript.EvaluateAsync(textBox1.Text);
            return result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                textBox2.Text = evaluate();
            }
            catch (Exception ex)
            {
                textBox2.Text=ex.Message;
            }
            
        }
    }
}
