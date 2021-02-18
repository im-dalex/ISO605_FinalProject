
namespace TeteoRentCar
{
    partial class Rents
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
            this.label1 = new System.Windows.Forms.Label();
            this.GridRents = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.tpDesde = new System.Windows.Forms.DateTimePicker();
            this.tpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridRents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rentas y devoluciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GridRents
            // 
            this.GridRents.AllowUserToAddRows = false;
            this.GridRents.AllowUserToDeleteRows = false;
            this.GridRents.AllowUserToOrderColumns = true;
            this.GridRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridRents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRents.Location = new System.Drawing.Point(12, 149);
            this.GridRents.Name = "GridRents";
            this.GridRents.ReadOnly = true;
            this.GridRents.RowHeadersVisible = false;
            this.GridRents.RowHeadersWidth = 51;
            this.GridRents.RowTemplate.Height = 29;
            this.GridRents.Size = new System.Drawing.Size(1030, 409);
            this.GridRents.TabIndex = 1;
            // 
            // PrintBtn
            // 
            this.PrintBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PrintBtn.Location = new System.Drawing.Point(978, 19);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(64, 29);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "PDF";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PdfBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 116);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "Buscar cliente por cedula o nombre";
            this.SearchTextBox.Size = new System.Drawing.Size(251, 27);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // tpDesde
            // 
            this.tpDesde.Location = new System.Drawing.Point(460, 117);
            this.tpDesde.Name = "tpDesde";
            this.tpDesde.Size = new System.Drawing.Size(190, 27);
            this.tpDesde.TabIndex = 4;
            // 
            // tpHasta
            // 
            this.tpHasta.Location = new System.Drawing.Point(736, 116);
            this.tpHasta.Name = "tpHasta";
            this.tpHasta.Size = new System.Drawing.Size(190, 27);
            this.tpHasta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(384, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(660, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tpHasta);
            this.Controls.Add(this.tpDesde);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.GridRents);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Rents";
            this.Text = "Rentas";
            this.Load += new System.EventHandler(this.Rents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridRents;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DateTimePicker tpDesde;
        private System.Windows.Forms.DateTimePicker tpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}