﻿namespace CarStoreApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.Brand = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Mileage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(12, 28);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(416, 335);
            this.listBox.TabIndex = 0;
            this.listBox.UseCompatibleStateImageBehavior = false;
            this.listBox.View = System.Windows.Forms.View.Tile;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Brand
            // 
            this.Brand.Location = new System.Drawing.Point(587, 48);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(201, 22);
            this.Brand.TabIndex = 3;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(587, 76);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(201, 22);
            this.Year.TabIndex = 4;
            this.Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_KeyPress);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(587, 104);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(201, 22);
            this.Price.TabIndex = 5;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // Mileage
            // 
            this.Mileage.Location = new System.Drawing.Point(587, 132);
            this.Mileage.Name = "Mileage";
            this.Mileage.Size = new System.Drawing.Size(201, 22);
            this.Mileage.TabIndex = 6;
            this.Mileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mileage_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mileage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Database:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Mileage);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Mileage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

