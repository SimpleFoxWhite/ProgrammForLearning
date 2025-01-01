using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProDictionary
{
    public partial class Form2 : Form
    {
        Dictionary<string, string> NewDictionary = new Dictionary<string, string>();
        Random rnd = new Random();
        bool Tester = false;
        string CurrentWord = "";
        string CurrentTranslate = "";

        public Form2(Dictionary<string, string> dictionary)
        {
            InitializeComponent();
            int randInt = dictionary.Count;
            NewDictionary = dictionary;
            
        }

        private void button1_Click(object sender, EventArgs e) //CheckWord
        {
            if(Tester == false) 
            {
                int randomNumber = rnd.Next(0, NewDictionary.Count);
                int CurrentNumber = 0;
                foreach (var i in NewDictionary)
                {
                    if (CurrentNumber == randomNumber)
                    {
                        CurrentWord = i.Key;
                        CurrentTranslate = i.Value;
                    }
                    CurrentNumber = CurrentNumber + 1;
                }
                label1.Text = CurrentWord;
                Tester = true;
            }
            else 
            {
                if (textBox1.Text == CurrentTranslate) 
                {
                    int randomNumber = rnd.Next(0, NewDictionary.Count);
                    int CurrentNumber = 0;
                    foreach (var i in NewDictionary)
                    {
                        if (CurrentNumber == randomNumber)
                        {
                            CurrentWord = i.Key;
                            CurrentTranslate = i.Value;
                        }
                        CurrentNumber = CurrentNumber + 1;
                    }
                    label2.Text = "Подсказка";
                    label1.Text = CurrentWord;
                }
                else 
                {
                    label2.Text = CurrentTranslate;
                }
            }
        }
    }
}
