namespace CriadorDePastas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int quantidade))
            {
                MessageBox.Show("Por favor, insira um número válido na quantidade.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else { 
            string caminhoBase = textBox4.Text;
            string nomePasta = textBox1.Text;
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(textBox2.Text) <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }
            // Verifica se o caminho base existe
            if (!Directory.Exists(caminhoBase))
            {
                MessageBox.Show("O caminho base não existe.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            // Verifica se o nome da pasta já existe

            else if (Directory.Exists(Path.Combine(caminhoBase, nomePasta)))
            {
                MessageBox.Show("Uma pasta com esse nome já existe.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            // Verifica se o nome da pasta contém caracteres inválidos
            else if (nomePasta.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("O nome da pasta contém caracteres inválidos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            // Verifica se o caminho base é um diretório
            else if (!Directory.Exists(caminhoBase))
            {
                MessageBox.Show("O caminho base não é um diretório.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else { 
                string caminhoPasta = Path.Combine(caminhoBase, nomePasta);
            
            for (int i = 0; i < quantidade; i++)
                {
                    // Cria o nome da pasta com o número sequencial
                    string nomePastaCompleto = $"{nomePasta} {i + 1}";
                    // Cria o caminho completo da pasta
                    string caminhoCompleto = Path.Combine(caminhoBase, nomePastaCompleto);
                    // Cria a pasta
                    Directory.CreateDirectory(caminhoCompleto);
                }
                    // Exibe uma mensagem de sucesso
                    MessageBox.Show($"Foram criadas {nomePasta} {quantidade} no local: {caminhoBase}",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

        }
        }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox4.Text = fbd.SelectedPath;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
