namespace AvaliacaoPOO
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
            label1 = new Label();
            txtSigla = new TextBox();
            label2 = new Label();
            txtPeríodo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCadastro = new Button();
            cboNivel = new ComboBox();
            btnConsultar = new Button();
            cbbcurso = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(80, 47);
            label1.Name = "label1";
            label1.Size = new Size(94, 38);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // txtSigla
            // 
            txtSigla.BorderStyle = BorderStyle.FixedSingle;
            txtSigla.Font = new Font("Segoe UI", 12F);
            txtSigla.Location = new Point(173, 120);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(171, 39);
            txtSigla.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(91, 120);
            label2.Name = "label2";
            label2.Size = new Size(82, 38);
            label2.TabIndex = 2;
            label2.Text = "Sigla:";
            // 
            // txtPeríodo
            // 
            txtPeríodo.BorderStyle = BorderStyle.FixedSingle;
            txtPeríodo.Font = new Font("Segoe UI", 12F);
            txtPeríodo.Location = new Point(171, 272);
            txtPeríodo.Name = "txtPeríodo";
            txtPeríodo.Size = new Size(201, 39);
            txtPeríodo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(57, 278);
            label3.Name = "label3";
            label3.Size = new Size(118, 38);
            label3.TabIndex = 4;
            label3.Text = "Período:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(67, 202);
            label4.Name = "label4";
            label4.Size = new Size(86, 38);
            label4.TabIndex = 6;
            label4.Text = "Nível:";
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCadastro.Location = new Point(63, 363);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(201, 68);
            btnCadastro.TabIndex = 8;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // cboNivel
            // 
            cboNivel.FormattingEnabled = true;
            cboNivel.Items.AddRange(new object[] { "Básico", "Médio", "Superior" });
            cboNivel.Location = new Point(171, 210);
            cboNivel.Margin = new Padding(4, 5, 4, 5);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(171, 33);
            cboNivel.TabIndex = 10;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConsultar.Location = new Point(349, 363);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(201, 68);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cbbcurso
            // 
            cbbcurso.FormattingEnabled = true;
            cbbcurso.Items.AddRange(new object[] { "Administração", "Desenvolv. Sistemas", "Enfermagem", "Ensino Médio", "Informática", "Mecânica", "Recursos Humanos" });
            cbbcurso.Location = new Point(180, 47);
            cbbcurso.Margin = new Padding(4, 5, 4, 5);
            cbbcurso.Name = "cbbcurso";
            cbbcurso.Size = new Size(214, 33);
            cbbcurso.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(cbbcurso);
            Controls.Add(btnConsultar);
            Controls.Add(cboNivel);
            Controls.Add(btnCadastro);
            Controls.Add(label4);
            Controls.Add(txtPeríodo);
            Controls.Add(label3);
            Controls.Add(txtSigla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "---- DADOS CURSO ----";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeríodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastro;
        private ComboBox cboNivel;
        private Button btnConsultar;
        private ComboBox cbbcurso;
    }
}
