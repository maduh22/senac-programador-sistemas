namespace Login

{

    public partial class Form1 : Form

    {

        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

        // ney posi��o 0; pablo posi��o 1; sukuna posi��o 2.

        public Form1()

        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            string user = Usuario.Text;
            string senha = Senha.Text;

            if (string.IsNullOrWhiteSpace(user))

            {

                resultado.Text = "Usu�rio � obrigat�rio!";
                resultado.ForeColor = Color.Red;
                return;

            }

            if (senha == null || senha == "")

            {
                resultado.Text = "Senha � obrigat�ria!";
                resultado.ForeColor = Color.Red;
                return;

            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)

            {

                if (user == listaUsuarios[i])

                {

                    posicaoUsuarioEncontrado = i;

                }

            }

            if (posicaoUsuarioEncontrado > -1 && senha == "12345")

            {

                resultado.Text = "Autenticado com sucesso!";
                resultado.ForeColor = Color.Green;

            }

            else

            {

                resultado.Text = "Usuario ou Senha incorretos...";
                resultado.ForeColor = Color.Red;

            }

        }

        private void Form1_Load(object sender, EventArgs e)

        {

        }

    }

}

