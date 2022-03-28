using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<char, char> skobki = new Dictionary<char, char>()
        {
            { ')','(' },
            { ']','[' },
            { '}','{' }
        };
        string openskobki = "([{", closeskobki = ")]}";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<char> mystack = new Stack<char>();
            bool isOK = true;
            char temp;
            foreach (var c in tbSource.Text)
            {
                if (openskobki.Contains(c)) mystack.Push(c);
                if(closeskobki.Contains(c))
                {
                    if (mystack.Count == 0 || mystack.Peek() != skobki[c])
                    {
                        isOK = false;
                        break;
                    }
                    else
                    {
                       mystack.Pop();
                       
                    }
                }

            }
            if (!isOK || mystack.Count > 0) lresult.Text = "Неверно";
            else lresult.Text = "МегаХорош";
        }
    }
}
