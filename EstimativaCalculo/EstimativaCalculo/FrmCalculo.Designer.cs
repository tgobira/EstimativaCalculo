namespace EstimativaCalculo
{
    partial class frmCalculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculo));
            this.txtConsumoMensal = new System.Windows.Forms.TextBox();
            this.tbVlrConsumoEstimado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbConsumoMensal = new System.Windows.Forms.Label();
            this.lbVlrConsumoMensal = new System.Windows.Forms.Label();
            this.lbFaixa1 = new System.Windows.Forms.Label();
            this.lbFaixa2 = new System.Windows.Forms.Label();
            this.lbFaixa3 = new System.Windows.Forms.Label();
            this.lbFaixa4 = new System.Windows.Forms.Label();
            this.lbFaixa5 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa1 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa2 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa3 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa4 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa5 = new System.Windows.Forms.Label();
            this.gbFaixas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVlrFaixa5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVlrFaixa4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbVlrFaixa3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbVlrFaixa2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbVlrFaixa1 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa6 = new System.Windows.Forms.Label();
            this.lbFaixa6 = new System.Windows.Forms.Label();
            this.lbVlrFaixa6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMedidaFaixa7 = new System.Windows.Forms.Label();
            this.lbFaixa7 = new System.Windows.Forms.Label();
            this.lbVlrFaixa7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbFaixas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsumoMensal
            // 
            this.txtConsumoMensal.Location = new System.Drawing.Point(13, 37);
            this.txtConsumoMensal.Name = "txtConsumoMensal";
            this.txtConsumoMensal.Size = new System.Drawing.Size(130, 20);
            this.txtConsumoMensal.TabIndex = 0;
            // 
            // tbVlrConsumoEstimado
            // 
            this.tbVlrConsumoEstimado.Enabled = false;
            this.tbVlrConsumoEstimado.Location = new System.Drawing.Point(13, 81);
            this.tbVlrConsumoEstimado.Name = "tbVlrConsumoEstimado";
            this.tbVlrConsumoEstimado.Size = new System.Drawing.Size(130, 20);
            this.tbVlrConsumoEstimado.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(197, 18);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.CalcularVlrFaixas);
            // 
            // lbConsumoMensal
            // 
            this.lbConsumoMensal.AutoSize = true;
            this.lbConsumoMensal.Location = new System.Drawing.Point(13, 18);
            this.lbConsumoMensal.Name = "lbConsumoMensal";
            this.lbConsumoMensal.Size = new System.Drawing.Size(141, 13);
            this.lbConsumoMensal.TabIndex = 3;
            this.lbConsumoMensal.Text = "Medida de Consumo Mensal";
            // 
            // lbVlrConsumoMensal
            // 
            this.lbVlrConsumoMensal.AutoSize = true;
            this.lbVlrConsumoMensal.Location = new System.Drawing.Point(13, 64);
            this.lbVlrConsumoMensal.Name = "lbVlrConsumoMensal";
            this.lbVlrConsumoMensal.Size = new System.Drawing.Size(176, 13);
            this.lbVlrConsumoMensal.TabIndex = 4;
            this.lbVlrConsumoMensal.Text = "Valor de Consumo Mensal Estimado";
            // 
            // lbFaixa1
            // 
            this.lbFaixa1.AutoSize = true;
            this.lbFaixa1.Location = new System.Drawing.Point(6, 16);
            this.lbFaixa1.Name = "lbFaixa1";
            this.lbFaixa1.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa1.TabIndex = 5;
            this.lbFaixa1.Text = "Faixa 1:";
            // 
            // lbFaixa2
            // 
            this.lbFaixa2.AutoSize = true;
            this.lbFaixa2.Location = new System.Drawing.Point(6, 33);
            this.lbFaixa2.Name = "lbFaixa2";
            this.lbFaixa2.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa2.TabIndex = 6;
            this.lbFaixa2.Text = "Faixa 2:";
            // 
            // lbFaixa3
            // 
            this.lbFaixa3.AutoSize = true;
            this.lbFaixa3.Location = new System.Drawing.Point(6, 50);
            this.lbFaixa3.Name = "lbFaixa3";
            this.lbFaixa3.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa3.TabIndex = 7;
            this.lbFaixa3.Text = "Faixa 3:";
            // 
            // lbFaixa4
            // 
            this.lbFaixa4.AutoSize = true;
            this.lbFaixa4.Location = new System.Drawing.Point(6, 67);
            this.lbFaixa4.Name = "lbFaixa4";
            this.lbFaixa4.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa4.TabIndex = 8;
            this.lbFaixa4.Text = "Faixa 4:";
            // 
            // lbFaixa5
            // 
            this.lbFaixa5.AutoSize = true;
            this.lbFaixa5.Location = new System.Drawing.Point(6, 84);
            this.lbFaixa5.Name = "lbFaixa5";
            this.lbFaixa5.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa5.TabIndex = 9;
            this.lbFaixa5.Text = "Faixa 5:";
            // 
            // lbMedidaFaixa1
            // 
            this.lbMedidaFaixa1.AutoSize = true;
            this.lbMedidaFaixa1.Location = new System.Drawing.Point(56, 16);
            this.lbMedidaFaixa1.Name = "lbMedidaFaixa1";
            this.lbMedidaFaixa1.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa1.TabIndex = 10;
            this.lbMedidaFaixa1.Text = "-";
            // 
            // lbMedidaFaixa2
            // 
            this.lbMedidaFaixa2.AutoSize = true;
            this.lbMedidaFaixa2.Location = new System.Drawing.Point(56, 33);
            this.lbMedidaFaixa2.Name = "lbMedidaFaixa2";
            this.lbMedidaFaixa2.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa2.TabIndex = 11;
            this.lbMedidaFaixa2.Text = "-";
            // 
            // lbMedidaFaixa3
            // 
            this.lbMedidaFaixa3.AutoSize = true;
            this.lbMedidaFaixa3.Location = new System.Drawing.Point(56, 50);
            this.lbMedidaFaixa3.Name = "lbMedidaFaixa3";
            this.lbMedidaFaixa3.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa3.TabIndex = 12;
            this.lbMedidaFaixa3.Text = "-";
            // 
            // lbMedidaFaixa4
            // 
            this.lbMedidaFaixa4.AutoSize = true;
            this.lbMedidaFaixa4.Location = new System.Drawing.Point(56, 67);
            this.lbMedidaFaixa4.Name = "lbMedidaFaixa4";
            this.lbMedidaFaixa4.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa4.TabIndex = 13;
            this.lbMedidaFaixa4.Text = "-";
            // 
            // lbMedidaFaixa5
            // 
            this.lbMedidaFaixa5.AutoSize = true;
            this.lbMedidaFaixa5.Location = new System.Drawing.Point(56, 84);
            this.lbMedidaFaixa5.Name = "lbMedidaFaixa5";
            this.lbMedidaFaixa5.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa5.TabIndex = 14;
            this.lbMedidaFaixa5.Text = "-";
            // 
            // gbFaixas
            // 
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa7);
            this.gbFaixas.Controls.Add(this.lbFaixa7);
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa6);
            this.gbFaixas.Controls.Add(this.lbFaixa6);
            this.gbFaixas.Controls.Add(this.lbFaixa1);
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa5);
            this.gbFaixas.Controls.Add(this.lbFaixa2);
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa4);
            this.gbFaixas.Controls.Add(this.lbFaixa3);
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa3);
            this.gbFaixas.Controls.Add(this.lbFaixa4);
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa2);
            this.gbFaixas.Controls.Add(this.lbFaixa5);
            this.gbFaixas.Controls.Add(this.lbMedidaFaixa1);
            this.gbFaixas.Location = new System.Drawing.Point(16, 120);
            this.gbFaixas.Name = "gbFaixas";
            this.gbFaixas.Size = new System.Drawing.Size(118, 146);
            this.gbFaixas.TabIndex = 15;
            this.gbFaixas.TabStop = false;
            this.gbFaixas.Text = "Consumo por Faixa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbVlrFaixa7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbVlrFaixa6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbVlrFaixa5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbVlrFaixa4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbVlrFaixa3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbVlrFaixa2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbVlrFaixa1);
            this.groupBox1.Location = new System.Drawing.Point(154, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 146);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor por Faixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Faixa 1:";
            // 
            // lbVlrFaixa5
            // 
            this.lbVlrFaixa5.AutoSize = true;
            this.lbVlrFaixa5.Location = new System.Drawing.Point(56, 84);
            this.lbVlrFaixa5.Name = "lbVlrFaixa5";
            this.lbVlrFaixa5.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa5.TabIndex = 14;
            this.lbVlrFaixa5.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Faixa 2:";
            // 
            // lbVlrFaixa4
            // 
            this.lbVlrFaixa4.AutoSize = true;
            this.lbVlrFaixa4.Location = new System.Drawing.Point(56, 67);
            this.lbVlrFaixa4.Name = "lbVlrFaixa4";
            this.lbVlrFaixa4.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa4.TabIndex = 13;
            this.lbVlrFaixa4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Faixa 3:";
            // 
            // lbVlrFaixa3
            // 
            this.lbVlrFaixa3.AutoSize = true;
            this.lbVlrFaixa3.Location = new System.Drawing.Point(56, 50);
            this.lbVlrFaixa3.Name = "lbVlrFaixa3";
            this.lbVlrFaixa3.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa3.TabIndex = 12;
            this.lbVlrFaixa3.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Faixa 4:";
            // 
            // lbVlrFaixa2
            // 
            this.lbVlrFaixa2.AutoSize = true;
            this.lbVlrFaixa2.Location = new System.Drawing.Point(56, 33);
            this.lbVlrFaixa2.Name = "lbVlrFaixa2";
            this.lbVlrFaixa2.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa2.TabIndex = 11;
            this.lbVlrFaixa2.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Faixa 5:";
            // 
            // lbVlrFaixa1
            // 
            this.lbVlrFaixa1.AutoSize = true;
            this.lbVlrFaixa1.Location = new System.Drawing.Point(56, 16);
            this.lbVlrFaixa1.Name = "lbVlrFaixa1";
            this.lbVlrFaixa1.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa1.TabIndex = 10;
            this.lbVlrFaixa1.Text = "-";
            // 
            // lbMedidaFaixa6
            // 
            this.lbMedidaFaixa6.AutoSize = true;
            this.lbMedidaFaixa6.Location = new System.Drawing.Point(56, 100);
            this.lbMedidaFaixa6.Name = "lbMedidaFaixa6";
            this.lbMedidaFaixa6.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa6.TabIndex = 16;
            this.lbMedidaFaixa6.Text = "-";
            // 
            // lbFaixa6
            // 
            this.lbFaixa6.AutoSize = true;
            this.lbFaixa6.Location = new System.Drawing.Point(6, 100);
            this.lbFaixa6.Name = "lbFaixa6";
            this.lbFaixa6.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa6.TabIndex = 15;
            this.lbFaixa6.Text = "Faixa 6:";
            // 
            // lbVlrFaixa6
            // 
            this.lbVlrFaixa6.AutoSize = true;
            this.lbVlrFaixa6.Location = new System.Drawing.Point(56, 100);
            this.lbVlrFaixa6.Name = "lbVlrFaixa6";
            this.lbVlrFaixa6.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa6.TabIndex = 16;
            this.lbVlrFaixa6.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Faixa 6:";
            // 
            // lbMedidaFaixa7
            // 
            this.lbMedidaFaixa7.AutoSize = true;
            this.lbMedidaFaixa7.Location = new System.Drawing.Point(56, 116);
            this.lbMedidaFaixa7.Name = "lbMedidaFaixa7";
            this.lbMedidaFaixa7.Size = new System.Drawing.Size(10, 13);
            this.lbMedidaFaixa7.TabIndex = 18;
            this.lbMedidaFaixa7.Text = "-";
            // 
            // lbFaixa7
            // 
            this.lbFaixa7.AutoSize = true;
            this.lbFaixa7.Location = new System.Drawing.Point(6, 116);
            this.lbFaixa7.Name = "lbFaixa7";
            this.lbFaixa7.Size = new System.Drawing.Size(44, 13);
            this.lbFaixa7.TabIndex = 17;
            this.lbFaixa7.Text = "Faixa 7:";
            // 
            // lbVlrFaixa7
            // 
            this.lbVlrFaixa7.AutoSize = true;
            this.lbVlrFaixa7.Location = new System.Drawing.Point(56, 116);
            this.lbVlrFaixa7.Name = "lbVlrFaixa7";
            this.lbVlrFaixa7.Size = new System.Drawing.Size(10, 13);
            this.lbVlrFaixa7.TabIndex = 18;
            this.lbVlrFaixa7.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Faixa 7:";
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 289);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFaixas);
            this.Controls.Add(this.lbVlrConsumoMensal);
            this.Controls.Add(this.lbConsumoMensal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbVlrConsumoEstimado);
            this.Controls.Add(this.txtConsumoMensal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 328);
            this.Name = "frmCalculo";
            this.Text = "Calculadora - Valor Estimado";
            this.Click += new System.EventHandler(this.CalcularVlrFaixas);
            this.gbFaixas.ResumeLayout(false);
            this.gbFaixas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsumoMensal;
        private System.Windows.Forms.TextBox tbVlrConsumoEstimado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbConsumoMensal;
        private System.Windows.Forms.Label lbVlrConsumoMensal;
        private System.Windows.Forms.Label lbFaixa1;
        private System.Windows.Forms.Label lbFaixa2;
        private System.Windows.Forms.Label lbFaixa3;
        private System.Windows.Forms.Label lbFaixa4;
        private System.Windows.Forms.Label lbFaixa5;
        private System.Windows.Forms.Label lbMedidaFaixa1;
        private System.Windows.Forms.Label lbMedidaFaixa2;
        private System.Windows.Forms.Label lbMedidaFaixa3;
        private System.Windows.Forms.Label lbMedidaFaixa4;
        private System.Windows.Forms.Label lbMedidaFaixa5;
        private System.Windows.Forms.GroupBox gbFaixas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVlrFaixa5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVlrFaixa4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbVlrFaixa3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbVlrFaixa2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbVlrFaixa1;
        private System.Windows.Forms.Label lbMedidaFaixa6;
        private System.Windows.Forms.Label lbFaixa6;
        private System.Windows.Forms.Label lbVlrFaixa6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMedidaFaixa7;
        private System.Windows.Forms.Label lbFaixa7;
        private System.Windows.Forms.Label lbVlrFaixa7;
        private System.Windows.Forms.Label label10;
    }
}

