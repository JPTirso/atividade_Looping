namespace atividade_Looping
{
    partial class FrmTemperatura
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
            lstGraus = new ListBox();
            groupBox2 = new GroupBox();
            btnFor = new Button();
            btnDoWhile = new Button();
            btnWhile = new Button();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLimpar);
            groupBox4.Controls.Add(btnVoltar);
            groupBox4.Location = new Point(20, 316);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(766, 119);
            groupBox4.TabIndex = 63;
            groupBox4.TabStop = false;
            groupBox4.Text = "Outros Botôes";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(203, 37);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 61);
            btnLimpar.TabIndex = 43;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(442, 37);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 61);
            btnVoltar.TabIndex = 44;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lstGraus);
            groupBox3.Location = new Point(480, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(306, 292);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            groupBox3.Text = "Áreas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(7, 27);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 51;
            label2.Text = "Resultado da tabuada:";
            // 
            // lstGraus
            // 
            lstGraus.FormattingEnabled = true;
            lstGraus.Location = new Point(7, 56);
            lstGraus.Name = "lstGraus";
            lstGraus.Size = new Size(292, 224);
            lstGraus.TabIndex = 36;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFor);
            groupBox2.Controls.Add(btnDoWhile);
            groupBox2.Controls.Add(btnWhile);
            groupBox2.Location = new Point(14, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(459, 295);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "Botões Calcular";
            // 
            // btnFor
            // 
            btnFor.Location = new Point(6, 125);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(120, 59);
            btnFor.TabIndex = 45;
            btnFor.Text = "Calcular For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(165, 125);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(120, 59);
            btnDoWhile.TabIndex = 39;
            btnDoWhile.Text = "Calcular Do-While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(319, 125);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(120, 59);
            btnWhile.TabIndex = 46;
            btnWhile.Text = "Calcular While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // FrmTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "FrmTemperatura";
            Text = "Conversor de graus";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnLimpar;
        private Button btnVoltar;
        private GroupBox groupBox3;
        private Label label2;
        private ListBox lstGraus;
        private GroupBox groupBox2;
        private Button btnFor;
        private Button btnDoWhile;
        private Button btnWhile;
    }
}