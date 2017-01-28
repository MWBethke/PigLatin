//Written By Matthew Bethke
//01/28/17
//Program Translates an Input Word into Pig Latin
// No Real Issues Encountered
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    public partial class pigLatinForm : Form
    {
        public pigLatinForm()
        {
            InitializeComponent();
        }

        private void translate_Click(object sender, EventArgs e)
        {
            string baseWord = wordInput.Text;
            string firstLetter = (baseWord.Substring(0,1));
            string latinWord = (baseWord.Substring(1) + firstLetter + "ay");
            latinOutput.Text = string.Format("{0} in Pig Latin is {1}", baseWord, latinWord);
        }
    }
}
