namespace MeuPrimeiroProjeto.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlaMundo_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Olá Mundo!";
        }

        private void btnAdeusMundo_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Adeus Mundo!";
        }

        private void btnOlaMundo_MouseUp(object sender, MouseEventArgs e)
        {
            btnOlaMundo.BackColor = Color.Blue;
        }

        private void btnOlaMundo_MouseHover(object sender, EventArgs e)
        {
            btnOlaMundo.BackColor = Color.Green;
        }
    }
}
