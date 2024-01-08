using System.Reflection.Emit;

namespace EventosDoPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToUpper();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Minute % 2 == 0)
            {
                label1.Text = "Par";
            }
            else
            {
                label1.Text = "Ímpar";
            }
        }

       
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }
    }
}
