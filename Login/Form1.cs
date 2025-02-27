namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Usuario.Text;
            string senha = Senha.Text;

            if (user == null || user == "")
            { 
                resultado.Text = "O usuario é obrigatorio";
                return;

            }

            if (user == "Duda" || senha == "1234")
            {
                resultado.Text = "Usuario e senha corretos";
            }

            else 
            {
                resultado.Text = "Usuario e senha incorretos";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
