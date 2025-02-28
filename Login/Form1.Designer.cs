namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Usuario = new TextBox();
            Senha = new TextBox();
            Login = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            resultado = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.Location = new Point(329, 180);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(113, 23);
            Usuario.TabIndex = 0;

         
            // 
            // Senha
            // 
            Senha.Location = new Point(329, 221);
            Senha.Name = "Senha";
            Senha.Size = new Size(113, 23);
            Senha.TabIndex = 1;
            // 
            // Login
            // 
            Login.Location = new Point(348, 281);
            Login.Name = "Login";
            Login.Size = new Size(75, 23);
            Login.TabIndex = 2;
            Login.Text = "Entrar";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 183);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 227);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(103, 347);
            resultado.Name = "resultado";
            resultado.Size = new Size(38, 15);
            resultado.TabIndex = 5;
            resultado.Text = "label3";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(Senha);
            Controls.Add(Usuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usuario;
        private TextBox Senha;
        private Button Login;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
        private Label resultado;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}
