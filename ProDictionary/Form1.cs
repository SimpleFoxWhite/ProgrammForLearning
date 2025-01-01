using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace ProDictionary
{
    

    public partial class Form1 : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //FunctionAddNewWordInDictionary
        {
            dictionary.Add(textBox2.Text,  textBox1.Text);
            listBox1.Items.Clear();
            foreach(var item in dictionary) 
            {
                listBox1.Items.Add(item.Key + " " + item.Value);
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //FunctionDeleteOneSelectedWord
        {
            string SelectedWord = listBox1.SelectedItem as string;
            if (SelectedWord != null) 
            {
                listBox1.Items.Remove(SelectedWord);
                string RealWord = "";
                bool flagChecker = false;
                foreach(var lit in SelectedWord) 
                {
                    if(flagChecker == false) 
                    {
                        if(lit == ' ') 
                        {
                            flagChecker = true;
                        }
                        else 
                        {
                            RealWord = RealWord + lit;
                        }
                    }
                }

                dictionary.Remove(RealWord);
            }

        }

        private void button2_Click(object sender, EventArgs e) //FunctionDeleteAllWords
        {
            listBox1.Items.Clear();
            dictionary.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //FunctionStartLearn
        {
            Form2 newForm = new Form2(dictionary);
            newForm.Show();
        }
    }
    class WordForLearn
    {
        public string Word { get; }
        public string Translate { get; }
        public WordForLearn(string word, string translate)
        {
            Word = word;
            Translate = translate;
        }
    }
}
