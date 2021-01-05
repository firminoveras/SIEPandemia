
namespace SIEPandemia {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.GroupBox groupBox4;
            this.NumeroAulas = new System.Windows.Forms.NumericUpDown();
            this.NumeroAlunos = new System.Windows.Forms.NumericUpDown();
            this.AlunosLista = new System.Windows.Forms.CheckedListBox();
            this.NumeroDelay = new System.Windows.Forms.NumericUpDown();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonColar = new System.Windows.Forms.Button();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.ButtonNenhum = new System.Windows.Forms.Button();
            this.ButtonTodos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroAulas)).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroAlunos)).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.pictureBox2);
            groupBox1.Controls.Add(this.NumeroAulas);
            groupBox1.Font = new System.Drawing.Font("Agency FB", 8F);
            groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            groupBox1.Location = new System.Drawing.Point(14, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(135, 51);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Quantidade de aulas/dia";
            // 
            // NumeroAulas
            // 
            this.NumeroAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.NumeroAulas.Font = new System.Drawing.Font("Agency FB", 8F);
            this.NumeroAulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.NumeroAulas.Location = new System.Drawing.Point(34, 20);
            this.NumeroAulas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumeroAulas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumeroAulas.Name = "NumeroAulas";
            this.NumeroAulas.Size = new System.Drawing.Size(94, 20);
            this.NumeroAulas.TabIndex = 0;
            this.NumeroAulas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.pictureBox3);
            groupBox2.Controls.Add(this.NumeroAlunos);
            groupBox2.Font = new System.Drawing.Font("Agency FB", 8F);
            groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            groupBox2.Location = new System.Drawing.Point(154, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(134, 51);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. Quantidade de Alunos";
            // 
            // NumeroAlunos
            // 
            this.NumeroAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.NumeroAlunos.Font = new System.Drawing.Font("Agency FB", 8F);
            this.NumeroAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.NumeroAlunos.Location = new System.Drawing.Point(33, 20);
            this.NumeroAlunos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumeroAlunos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumeroAlunos.Name = "NumeroAlunos";
            this.NumeroAlunos.Size = new System.Drawing.Size(94, 20);
            this.NumeroAlunos.TabIndex = 0;
            this.NumeroAlunos.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumeroAlunos.ValueChanged += new System.EventHandler(this.NumeroAlunos_ValueChanged);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.ButtonColar);
            groupBox3.Controls.Add(this.ButtonLimpar);
            groupBox3.Controls.Add(this.ButtonNenhum);
            groupBox3.Controls.Add(this.ButtonTodos);
            groupBox3.Controls.Add(this.AlunosLista);
            groupBox3.Font = new System.Drawing.Font("Agency FB", 8F);
            groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            groupBox3.Location = new System.Drawing.Point(14, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(274, 380);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "3. Alunos que ficarão com falta justificada";
            // 
            // AlunosLista
            // 
            this.AlunosLista.AllowDrop = true;
            this.AlunosLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.AlunosLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlunosLista.CheckOnClick = true;
            this.AlunosLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlunosLista.Font = new System.Drawing.Font("Agency FB", 10F);
            this.AlunosLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.AlunosLista.FormattingEnabled = true;
            this.AlunosLista.Items.AddRange(new object[] {
            "Aluno 1",
            "Aluno 2",
            "Aluno 3",
            "Aluno 4",
            "Aluno 5",
            "Aluno 6",
            "Aluno 7",
            "Aluno 8",
            "Aluno 9",
            "Aluno 10"});
            this.AlunosLista.Location = new System.Drawing.Point(8, 17);
            this.AlunosLista.Name = "AlunosLista";
            this.AlunosLista.Size = new System.Drawing.Size(262, 306);
            this.AlunosLista.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(this.pictureBox4);
            groupBox4.Controls.Add(this.NumeroDelay);
            groupBox4.Font = new System.Drawing.Font("Agency FB", 8F);
            groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            groupBox4.Location = new System.Drawing.Point(14, 548);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(135, 51);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "4. Milisegundos";
            // 
            // NumeroDelay
            // 
            this.NumeroDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.NumeroDelay.Font = new System.Drawing.Font("Agency FB", 8F);
            this.NumeroDelay.ForeColor = System.Drawing.Color.White;
            this.NumeroDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumeroDelay.Location = new System.Drawing.Point(34, 20);
            this.NumeroDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumeroDelay.Name = "NumeroDelay";
            this.NumeroDelay.Size = new System.Drawing.Size(94, 20);
            this.NumeroDelay.TabIndex = 0;
            this.NumeroDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.InfoLabel.Font = new System.Drawing.Font("Agency FB", 9F);
            this.InfoLabel.Location = new System.Drawing.Point(165, 584);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(116, 15);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "CTRL + B para Iniciar o MACRO";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::SIEPandemia.Properties.Resources.Timer_16x;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(8, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackgroundImage = global::SIEPandemia.Properties.Resources.Run_16x;
            this.ButtonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Calibri", 12F);
            this.ButtonSalvar.Location = new System.Drawing.Point(154, 554);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(134, 27);
            this.ButtonSalvar.TabIndex = 6;
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // ButtonColar
            // 
            this.ButtonColar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonColar.BackgroundImage = global::SIEPandemia.Properties.Resources.Paste_16x;
            this.ButtonColar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonColar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColar.Font = new System.Drawing.Font("Calibri", 8F);
            this.ButtonColar.Location = new System.Drawing.Point(8, 343);
            this.ButtonColar.Name = "ButtonColar";
            this.ButtonColar.Size = new System.Drawing.Size(62, 29);
            this.ButtonColar.TabIndex = 6;
            this.ButtonColar.UseVisualStyleBackColor = false;
            this.ButtonColar.Click += new System.EventHandler(this.ButtonColar_Click);
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.BackgroundImage = global::SIEPandemia.Properties.Resources.DeleteAllRows_16x;
            this.ButtonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLimpar.Font = new System.Drawing.Font("Calibri", 8F);
            this.ButtonLimpar.Location = new System.Drawing.Point(74, 343);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(62, 29);
            this.ButtonLimpar.TabIndex = 7;
            this.ButtonLimpar.UseVisualStyleBackColor = true;
            this.ButtonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // ButtonNenhum
            // 
            this.ButtonNenhum.BackgroundImage = global::SIEPandemia.Properties.Resources.CheckBoxFieldColumnUnchecked_16x;
            this.ButtonNenhum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonNenhum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNenhum.Font = new System.Drawing.Font("Calibri", 8F);
            this.ButtonNenhum.Location = new System.Drawing.Point(141, 343);
            this.ButtonNenhum.Name = "ButtonNenhum";
            this.ButtonNenhum.Size = new System.Drawing.Size(62, 29);
            this.ButtonNenhum.TabIndex = 5;
            this.ButtonNenhum.UseVisualStyleBackColor = true;
            this.ButtonNenhum.Click += new System.EventHandler(this.ButtonNenhum_Click);
            // 
            // ButtonTodos
            // 
            this.ButtonTodos.BackgroundImage = global::SIEPandemia.Properties.Resources.CheckBoxFieldColumnChecked_16x;
            this.ButtonTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTodos.Font = new System.Drawing.Font("Calibri", 8F);
            this.ButtonTodos.Location = new System.Drawing.Point(208, 343);
            this.ButtonTodos.Name = "ButtonTodos";
            this.ButtonTodos.Size = new System.Drawing.Size(62, 29);
            this.ButtonTodos.TabIndex = 4;
            this.ButtonTodos.UseVisualStyleBackColor = true;
            this.ButtonTodos.Click += new System.EventHandler(this.ButtonTodos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SIEPandemia.Properties.Resources.UserDefinedTableType_16x;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(6, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SIEPandemia.Properties.Resources.Calendar_16x;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(8, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.DarkGray;
            this.Logo.BackgroundImage = global::SIEPandemia.Properties.Resources.Sem_título_211;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Help;
            this.Logo.Location = new System.Drawing.Point(14, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(274, 86);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 610);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(groupBox4);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.Logo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SIEPandemia";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumeroAulas)).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumeroAlunos)).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumeroDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.NumericUpDown NumeroAulas;
        private System.Windows.Forms.NumericUpDown NumeroAlunos;
        private System.Windows.Forms.CheckedListBox AlunosLista;
        private System.Windows.Forms.Button ButtonNenhum;
        private System.Windows.Forms.Button ButtonTodos;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.NumericUpDown NumeroDelay;
        private System.Windows.Forms.Button ButtonColar;
        private System.Windows.Forms.Button ButtonLimpar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label InfoLabel;
    }
}

