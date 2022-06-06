namespace proiect
{
    partial class Form3
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
            this.btnExplicatie = new System.Windows.Forms.Button();
            this.btnEnunt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntrare = new System.Windows.Forms.TextBox();
            this.txtIesire = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExplicatie
            // 
            this.btnExplicatie.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplicatie.Location = new System.Drawing.Point(847, 426);
            this.btnExplicatie.Name = "btnExplicatie";
            this.btnExplicatie.Size = new System.Drawing.Size(150, 75);
            this.btnExplicatie.TabIndex = 9;
            this.btnExplicatie.Text = "Explicatie si exemplu";
            this.btnExplicatie.UseVisualStyleBackColor = true;
            // 
            // btnEnunt
            // 
            this.btnEnunt.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnunt.Location = new System.Drawing.Point(29, 426);
            this.btnEnunt.Name = "btnEnunt";
            this.btnEnunt.Size = new System.Drawing.Size(150, 75);
            this.btnEnunt.TabIndex = 8;
            this.btnEnunt.Text = "Enunt\r\n";
            this.btnEnunt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Intrare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Iesire:";
            // 
            // txtIntrare
            // 
            this.txtIntrare.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntrare.Location = new System.Drawing.Point(323, 118);
            this.txtIntrare.Name = "txtIntrare";
            this.txtIntrare.Size = new System.Drawing.Size(172, 45);
            this.txtIntrare.TabIndex = 12;
            this.txtIntrare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cifre_KeyPress);
            // 
            // txtIesire
            // 
            this.txtIesire.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIesire.Location = new System.Drawing.Point(323, 249);
            this.txtIesire.Name = "txtIesire";
            this.txtIesire.Size = new System.Drawing.Size(172, 45);
            this.txtIesire.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(671, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 14;
            this.button1.Text = "Rezolva!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1031, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIesire);
            this.Controls.Add(this.txtIntrare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExplicatie);
            this.Controls.Add(this.btnEnunt);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1047, 564);
            this.MinimumSize = new System.Drawing.Size(1047, 564);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExplicatie;
        private System.Windows.Forms.Button btnEnunt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntrare;
        private System.Windows.Forms.TextBox txtIesire;
        private System.Windows.Forms.Button button1;
    }
}