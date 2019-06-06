namespace VigenereCipher
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.txtDekripto = new System.Windows.Forms.TextBox();
            this.txtRezultati = new System.Windows.Forms.TextBox();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelesi = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnGjenero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(186, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vigènere Cipher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Texti i Dekriptuar:";
            // 
            // lblRezultati
            // 
            this.lblRezultati.AutoSize = true;
            this.lblRezultati.Location = new System.Drawing.Point(53, 253);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(95, 13);
            this.lblRezultati.TabIndex = 19;
            this.lblRezultati.Text = "Teksti i Enkriptuar:";
            // 
            // txtDekripto
            // 
            this.txtDekripto.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtDekripto.Location = new System.Drawing.Point(157, 349);
            this.txtDekripto.Name = "txtDekripto";
            this.txtDekripto.Size = new System.Drawing.Size(367, 20);
            this.txtDekripto.TabIndex = 18;
            // 
            // txtRezultati
            // 
            this.txtRezultati.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtRezultati.Location = new System.Drawing.Point(157, 250);
            this.txtRezultati.Name = "txtRezultati";
            this.txtRezultati.ReadOnly = true;
            this.txtRezultati.Size = new System.Drawing.Size(367, 20);
            this.txtRezultati.TabIndex = 17;
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEnkripto.ForeColor = System.Drawing.Color.Snow;
            this.btnEnkripto.Location = new System.Drawing.Point(441, 296);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(83, 34);
            this.btnEnkripto.TabIndex = 16;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = false;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDekripto.ForeColor = System.Drawing.Color.Snow;
            this.btnDekripto.Location = new System.Drawing.Point(441, 388);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(83, 34);
            this.btnDekripto.TabIndex = 15;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = false;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Celesi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plaintext:";
            // 
            // txtCelesi
            // 
            this.txtCelesi.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtCelesi.Location = new System.Drawing.Point(157, 165);
            this.txtCelesi.Name = "txtCelesi";
            this.txtCelesi.Size = new System.Drawing.Size(367, 20);
            this.txtCelesi.TabIndex = 12;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtPlaintext.Location = new System.Drawing.Point(157, 122);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(367, 20);
            this.txtPlaintext.TabIndex = 11;
            this.txtPlaintext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaintext_KeyPress);
            // 
            // btnGjenero
            // 
            this.btnGjenero.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGjenero.ForeColor = System.Drawing.Color.Snow;
            this.btnGjenero.Location = new System.Drawing.Point(441, 196);
            this.btnGjenero.Name = "btnGjenero";
            this.btnGjenero.Size = new System.Drawing.Size(83, 34);
            this.btnGjenero.TabIndex = 22;
            this.btnGjenero.Text = "Gjenero Çelesin";
            this.btnGjenero.UseVisualStyleBackColor = false;
            this.btnGjenero.Click += new System.EventHandler(this.btnGjenero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.btnGjenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.txtDekripto);
            this.Controls.Add(this.txtRezultati);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCelesi);
            this.Controls.Add(this.txtPlaintext);
            this.Name = "Form1";
            this.Text = "Vigenère Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRezultati;
        private System.Windows.Forms.TextBox txtDekripto;
        private System.Windows.Forms.TextBox txtRezultati;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCelesi;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Button btnGjenero;
    }
}

