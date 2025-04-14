namespace CriadorDePastas
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crie Suas Pastas";
            // 
            // button2
            // 
            button2.Location = new Point(13, 151);
            button2.Name = "button2";
            button2.Size = new Size(96, 31);
            button2.TabIndex = 5;
            button2.Text = "Gerar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 31);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 98);
            label3.Name = "label3";
            label3.Size = new Size(362, 25);
            label3.TabIndex = 1;
            label3.Text = "Digite o número de pastas a serem geradas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 45);
            label2.Name = "label2";
            label2.Size = new Size(219, 25);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome das pastas:";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 146);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Onde Criar";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(646, 31);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(251, 42);
            button1.Name = "button1";
            button1.Size = new Size(93, 33);
            button1.TabIndex = 1;
            button1.Text = "Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 0;
            label1.Text = "Onde deseja gerar as pastas:";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 31);
            textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 388);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gerador de Pastas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button2;
        private GroupBox groupBox2;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox3;
        private TextBox localPastas;
        private TextBox textBox4;
        private Button button1;
    }
}
