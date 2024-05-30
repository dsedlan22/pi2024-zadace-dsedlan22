namespace SCVZ_Restoraunt
{
    partial class RegistrirajStudenta
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
            this.button1 = new System.Windows.Forms.Button();
            this.ImePrezime = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Izlaz = new System.Windows.Forms.Button();
            this.ObrisiStudenta = new System.Windows.Forms.Button();
            this.AzurirajStudenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "RegistrirajStudenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImePrezime
            // 
            this.ImePrezime.Location = new System.Drawing.Point(595, 73);
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.Size = new System.Drawing.Size(154, 22);
            this.ImePrezime.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Izlaz
            // 
            this.Izlaz.Location = new System.Drawing.Point(595, 238);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(75, 23);
            this.Izlaz.TabIndex = 4;
            this.Izlaz.Text = "Izlaz";
            this.Izlaz.UseVisualStyleBackColor = true;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // ObrisiStudenta
            // 
            this.ObrisiStudenta.Location = new System.Drawing.Point(386, 300);
            this.ObrisiStudenta.Name = "ObrisiStudenta";
            this.ObrisiStudenta.Size = new System.Drawing.Size(75, 23);
            this.ObrisiStudenta.TabIndex = 5;
            this.ObrisiStudenta.Text = "Obriši Studenta";
            this.ObrisiStudenta.UseVisualStyleBackColor = true;
            this.ObrisiStudenta.Click += new System.EventHandler(this.ObrisiStudenta_Click);
            // 
            // AzurirajStudenta
            // 
            this.AzurirajStudenta.Location = new System.Drawing.Point(282, 238);
            this.AzurirajStudenta.Name = "AzurirajStudenta";
            this.AzurirajStudenta.Size = new System.Drawing.Size(140, 23);
            this.AzurirajStudenta.TabIndex = 6;
            this.AzurirajStudenta.Text = "Ažuriraj Studenta";
            this.AzurirajStudenta.UseVisualStyleBackColor = true;
            this.AzurirajStudenta.Click += new System.EventHandler(this.AzurirajStudenta_Click);
            // 
            // RegistrirajStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AzurirajStudenta);
            this.Controls.Add(this.ObrisiStudenta);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ImePrezime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrirajStudenta";
            this.Text = "RegistrirajStudenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ImePrezime;
        private System.Windows.Forms.Button Izlaz;
        private System.Windows.Forms.Button ObrisiStudenta;
        private System.Windows.Forms.Button AzurirajStudenta;
        public System.Windows.Forms.TextBox textBox2;
    }
}