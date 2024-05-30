namespace SCVZ_Restoraunt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CijenaSuma = new System.Windows.Forms.Label();
            this.IzlazGumb = new System.Windows.Forms.Button();
            this.RegistracijaStudenta = new System.Windows.Forms.Button();
            this.RegistracijaProizvoda = new System.Windows.Forms.Button();
            this.UnosStudenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // CijenaSuma
            // 
            this.CijenaSuma.AutoSize = true;
            this.CijenaSuma.Location = new System.Drawing.Point(507, 204);
            this.CijenaSuma.Name = "CijenaSuma";
            this.CijenaSuma.Size = new System.Drawing.Size(44, 16);
            this.CijenaSuma.TabIndex = 1;
            this.CijenaSuma.Text = "label1";
            // 
            // IzlazGumb
            // 
            this.IzlazGumb.Location = new System.Drawing.Point(592, 60);
            this.IzlazGumb.Name = "IzlazGumb";
            this.IzlazGumb.Size = new System.Drawing.Size(75, 23);
            this.IzlazGumb.TabIndex = 2;
            this.IzlazGumb.Text = "Izlaz";
            this.IzlazGumb.UseVisualStyleBackColor = true;
            this.IzlazGumb.Click += new System.EventHandler(this.IzlazGumb_Click);
            // 
            // RegistracijaStudenta
            // 
            this.RegistracijaStudenta.Location = new System.Drawing.Point(602, 157);
            this.RegistracijaStudenta.Name = "RegistracijaStudenta";
            this.RegistracijaStudenta.Size = new System.Drawing.Size(160, 23);
            this.RegistracijaStudenta.TabIndex = 3;
            this.RegistracijaStudenta.Text = "Registracija Studenta";
            this.RegistracijaStudenta.UseVisualStyleBackColor = true;
            this.RegistracijaStudenta.Click += new System.EventHandler(this.RegistracijaStudenta_Click);
            // 
            // RegistracijaProizvoda
            // 
            this.RegistracijaProizvoda.Location = new System.Drawing.Point(531, 279);
            this.RegistracijaProizvoda.Name = "RegistracijaProizvoda";
            this.RegistracijaProizvoda.Size = new System.Drawing.Size(156, 23);
            this.RegistracijaProizvoda.TabIndex = 4;
            this.RegistracijaProizvoda.Text = "Registracija Proizvoda";
            this.RegistracijaProizvoda.UseVisualStyleBackColor = true;
            this.RegistracijaProizvoda.Click += new System.EventHandler(this.RegistracijaProizvoda_Click);
            // 
            // UnosStudenta
            // 
            this.UnosStudenta.Location = new System.Drawing.Point(411, 341);
            this.UnosStudenta.Name = "UnosStudenta";
            this.UnosStudenta.Size = new System.Drawing.Size(75, 23);
            this.UnosStudenta.TabIndex = 5;
            this.UnosStudenta.Text = "Unos Studenta";
            this.UnosStudenta.UseVisualStyleBackColor = true;
            this.UnosStudenta.Click += new System.EventHandler(this.UnosStudenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnosStudenta);
            this.Controls.Add(this.RegistracijaProizvoda);
            this.Controls.Add(this.RegistracijaStudenta);
            this.Controls.Add(this.IzlazGumb);
            this.Controls.Add(this.CijenaSuma);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CijenaSuma;
        private System.Windows.Forms.Button IzlazGumb;
        private System.Windows.Forms.Button RegistracijaStudenta;
        private System.Windows.Forms.Button RegistracijaProizvoda;
        private System.Windows.Forms.Button UnosStudenta;
    }
}