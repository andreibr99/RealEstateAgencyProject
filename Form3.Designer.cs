
namespace WindowsFormsApp1
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
            this.button_iesire = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_oferte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_apartamente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_detalii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_iesire
            // 
            this.button_iesire.Location = new System.Drawing.Point(55, 361);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(76, 34);
            this.button_iesire.TabIndex = 0;
            this.button_iesire.Text = "Ieșire";
            this.button_iesire.UseVisualStyleBackColor = true;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listă Agenții";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_oferte
            // 
            this.button_oferte.Location = new System.Drawing.Point(34, 157);
            this.button_oferte.Name = "button_oferte";
            this.button_oferte.Size = new System.Drawing.Size(128, 34);
            this.button_oferte.TabIndex = 2;
            this.button_oferte.Text = "Listă Oferte";
            this.button_oferte.UseVisualStyleBackColor = true;
            this.button_oferte.Click += new System.EventHandler(this.button_oferte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ce doriți să vedeți?";
            // 
            // button_apartamente
            // 
            this.button_apartamente.Location = new System.Drawing.Point(34, 216);
            this.button_apartamente.Name = "button_apartamente";
            this.button_apartamente.Size = new System.Drawing.Size(128, 45);
            this.button_apartamente.TabIndex = 5;
            this.button_apartamente.Text = "Listă Spații";
            this.button_apartamente.UseVisualStyleBackColor = true;
            this.button_apartamente.Click += new System.EventHandler(this.button_apartamente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 338);
            this.dataGridView1.TabIndex = 6;
            // 
            // button_detalii
            // 
            this.button_detalii.Location = new System.Drawing.Point(34, 287);
            this.button_detalii.Name = "button_detalii";
            this.button_detalii.Size = new System.Drawing.Size(128, 39);
            this.button_detalii.TabIndex = 7;
            this.button_detalii.Text = "Detalii";
            this.button_detalii.UseVisualStyleBackColor = true;
            this.button_detalii.Click += new System.EventHandler(this.button_detalii_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.agentie1;
            this.ClientSize = new System.Drawing.Size(1137, 474);
            this.Controls.Add(this.button_detalii);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_apartamente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_oferte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_iesire);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_iesire;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_oferte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_apartamente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_detalii;
    }
}