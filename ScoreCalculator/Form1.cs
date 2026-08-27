using System.Windows.Forms.VisualStyles;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int score = 0;

        int scoreTotal = 0;

        int scoreCount = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            scoreTotal += score;
            scoreCount++;
            textBox2.Text = Convert.ToString(scoreTotal);
            textBox3.Text = Convert.ToString(scoreCount);
            textBox4.Text = Convert.ToString(scoreTotal/scoreCount);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0; scoreTotal = 0; scoreCount = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int parsedScore))
            {
                score = parsedScore;
            }
            else
            {
                score = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
