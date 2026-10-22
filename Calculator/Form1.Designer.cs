using System;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btmulti = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btresta = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btsum = new System.Windows.Forms.Button();
            this.btpow = new System.Windows.Forms.Button();
            this.btnulo = new System.Windows.Forms.Button();
            this.btcoma = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.IGUAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(12, 142);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 23);
            this.bt7.TabIndex = 0;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(93, 142);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 23);
            this.bt8.TabIndex = 1;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(174, 142);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 23);
            this.bt9.TabIndex = 2;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btmulti
            // 
            this.btmulti.Location = new System.Drawing.Point(255, 142);
            this.btmulti.Name = "btmulti";
            this.btmulti.Size = new System.Drawing.Size(75, 23);
            this.btmulti.TabIndex = 3;
            this.btmulti.Text = "x";
            this.btmulti.UseVisualStyleBackColor = true;
            this.btmulti.Click += new System.EventHandler(this.btmulti_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 171);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(93, 171);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 23);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(174, 171);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 23);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // btresta
            // 
            this.btresta.Location = new System.Drawing.Point(255, 171);
            this.btresta.Name = "btresta";
            this.btresta.Size = new System.Drawing.Size(75, 23);
            this.btresta.TabIndex = 7;
            this.btresta.Text = "-";
            this.btresta.UseVisualStyleBackColor = true;
            this.btresta.Click += new System.EventHandler(this.btresta_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 200);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(93, 200);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 9;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(174, 200);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 10;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btsum
            // 
            this.btsum.Location = new System.Drawing.Point(255, 200);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(75, 23);
            this.btsum.TabIndex = 11;
            this.btsum.Text = "+";
            this.btsum.UseVisualStyleBackColor = true;
            this.btsum.Click += new System.EventHandler(this.btsum_Click);
            // 
            // btpow
            // 
            this.btpow.Location = new System.Drawing.Point(12, 229);
            this.btpow.Name = "btpow";
            this.btpow.Size = new System.Drawing.Size(75, 23);
            this.btpow.TabIndex = 12;
            this.btpow.Text = "n^";
            this.btpow.UseVisualStyleBackColor = true;
            this.btpow.Click += new System.EventHandler(this.btcoma_Click);
            // 
            // btnulo
            // 
            this.btnulo.Location = new System.Drawing.Point(93, 229);
            this.btnulo.Name = "btnulo";
            this.btnulo.Size = new System.Drawing.Size(75, 23);
            this.btnulo.TabIndex = 13;
            this.btnulo.Text = "0";
            this.btnulo.UseVisualStyleBackColor = true;
            this.btnulo.Click += new System.EventHandler(this.btnulo_Click);
            // 
            // btcoma
            // 
            this.btcoma.Location = new System.Drawing.Point(174, 229);
            this.btcoma.Name = "btcoma";
            this.btcoma.Size = new System.Drawing.Size(75, 23);
            this.btcoma.TabIndex = 14;
            this.btcoma.Text = ",";
            this.btcoma.UseVisualStyleBackColor = true;
            this.btcoma.Click += new System.EventHandler(this.btcoma_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(255, 229);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(75, 23);
            this.btdiv.TabIndex = 15;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(12, 116);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(318, 20);
            this.txtb1.TabIndex = 21;
            // 
            // IGUAL
            // 
            this.IGUAL.Location = new System.Drawing.Point(132, 258);
            this.IGUAL.Name = "IGUAL";
            this.IGUAL.Size = new System.Drawing.Size(75, 23);
            this.IGUAL.TabIndex = 22;
            this.IGUAL.Text = "=";
            this.IGUAL.UseVisualStyleBackColor = true;
            this.IGUAL.Click += new System.EventHandler(this.IGUAL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 494);
            this.Controls.Add(this.IGUAL);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btcoma);
            this.Controls.Add(this.btnulo);
            this.Controls.Add(this.btpow);
            this.Controls.Add(this.btsum);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btresta);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btmulti);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btmulti;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btresta;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btsum;
        private System.Windows.Forms.Button btpow;
        private System.Windows.Forms.Button btnulo;
        private System.Windows.Forms.Button btcoma;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Button IGUAL;
    }
}

