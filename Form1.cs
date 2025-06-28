namespace _1_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Sentence
        {
            private string Name { get; }

            public Sentence()
            {
                Name = "NoName";
            }

            public Sentence(string Name)
            {
                this.Name = Name;
            }

            public string Sentencemade()
            {
                if (string.IsNullOrEmpty(Name))
                    return Name;

                if (Name.Length % 2 == 0)
                {
                    int halfLength = Name.Length / 2;
                    string firstHalf = Name.Substring(0, halfLength);
                    string secondHalf = Name.Substring(halfLength);

                    char[] firstArray = firstHalf.ToCharArray();
                    Array.Reverse(firstArray);
                    char[] secondArray = secondHalf.ToCharArray();
                    Array.Reverse(secondArray);

                    return new string(firstArray) + new string(secondArray);
                }
                else
                {
                    char[] array = Name.ToCharArray();
                    Array.Reverse(array);
                    string reversed = new string(array);

                    return reversed + Name;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sentence sentence = new Sentence(textBox1.Text);
            label4.Text = sentence.Sentencemade();
        }
    }
}
