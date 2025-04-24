using System.Threading;

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
            // Valida se a quantidade � um n�mero v�lido
            if (!int.TryParse(textBox2.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Por favor, insira um n�mero v�lido maior que zero na quantidade.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string caminhoBase = textBox4.Text;
            string nomePasta = textBox1.Text;

            // Valida se os campos obrigat�rios est�o preenchidos
            if (string.IsNullOrEmpty(caminhoBase) || string.IsNullOrEmpty(nomePasta))
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Verifica se o caminho base existe
            if (!Directory.Exists(caminhoBase))
            {
                MessageBox.Show("O caminho base n�o existe.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Verifica se o nome da pasta j� existe
            if (Directory.Exists(Path.Combine(caminhoBase, nomePasta)))
            {
                MessageBox.Show("Uma pasta com esse nome j� existe.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Verifica se o nome da pasta cont�m caracteres inv�lidos
            if (nomePasta.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("O nome da pasta cont�m caracteres inv�lidos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Confirma��o para grandes quantidades
            if (quantidade >= 20)
            {
                DialogResult result = MessageBox.Show($"Voc� est� prestes a criar {quantidade} pastas. Deseja continuar?",
                                                      "Aten��o",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // Cria��o das pastas
            for (int i = 0; i < quantidade; i++)
            {
                string nomePastaCompleto = $"{nomePasta} {i + 1}";
                string caminhoCompleto = Path.Combine(caminhoBase, nomePastaCompleto);
                Directory.CreateDirectory(caminhoCompleto);
            }

            // Mensagem de sucesso
            MessageBox.Show($"Foram criadas {quantidade} pastas com o nome '{nomePasta}' no local: {caminhoBase}",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
