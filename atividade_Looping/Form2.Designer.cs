namespace atividade_Looping
{
    partial class FrmTabuada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox4 = new GroupBox();
            btnLimpar = new Button();
            btnVoltar = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            lstTabuada = new ListBox();
            groupBox2 = new GroupBox();
            btnFor = new Button();
            btnDoWhile = new Button();
            btnWhile = new Button();
            groupBox1 = new GroupBox();
            lblNum = new Label();
            txtNum = new TextBox();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLimpar);
            groupBox4.Controls.Add(btnVoltar);
            groupBox4.Location = new Point(480, 316);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(306, 119);
            groupBox4.TabIndex = 59;
            groupBox4.TabStop = false;
            groupBox4.Text = "Outros Botôes";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(7, 49);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 61);
            btnLimpar.TabIndex = 43;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(179, 49);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 61);
            btnVoltar.TabIndex = 44;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lstTabuada);
            groupBox3.Location = new Point(480, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(306, 292);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = "Áreas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(7, 26);
            label2.Name = "label2";
            label2.Size = new Size(320, 28);
            label2.TabIndex = 51;
            label2.Text = "Essas são as áreas de cada comodo:";
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.Location = new Point(7, 56);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(292, 164);
            lstTabuada.TabIndex = 36;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFor);
            groupBox2.Controls.Add(btnDoWhile);
            groupBox2.Controls.Add(btnWhile);
            groupBox2.Location = new Point(14, 316);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(459, 119);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Botões Calcular";
            // 
            // btnFor
            // 
            btnFor.Location = new Point(7, 53);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(120, 59);
            btnFor.TabIndex = 45;
            btnFor.Text = "Calcular For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(333, 52);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(120, 59);
            btnDoWhile.TabIndex = 39;
            btnDoWhile.Text = "Calcular Do-While";
            btnDoWhile.UseVisualStyleBackColor = true;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(173, 53);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(120, 59);
            btnWhile.TabIndex = 46;
            btnWhile.Text = "Calcular While";
            btnWhile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNum);
            groupBox1.Controls.Add(txtNum);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(459, 292);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 12F);
            lblNum.Location = new Point(7, 26);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(417, 28);
            lblNum.TabIndex = 40;
            lblNum.Text = "Digite o numero de 1 a 9 que deseja adicionar:";
            // 
            // txtNum
            // 
            txtNum.CausesValidation = false;
            txtNum.Font = new Font("Segoe UI", 12F);
            txtNum.Location = new Point(7, 56);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(183, 34);
            txtNum.TabIndex = 35;
            // 
            // FrmTabuada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmTabuada";
            Text = "Form2";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnLimpar;
        private Button btnVoltar;
        private GroupBox groupBox3;
        private Label label2;
        private ListBox lstTabuada;
        private GroupBox groupBox2;
        private Button btnFor;
        private Button btnDoWhile;
        private Button btnWhile;
        private GroupBox groupBox1;
        private Label lblNum;
        private TextBox txtNum;
    }
}