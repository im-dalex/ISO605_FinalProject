
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
            ((System.ComponentModel.ISupportInitialize)(this.GridRents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(430, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rentas y devoluciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GridRents
            // 
            this.GridRents.AllowUserToAddRows = false;
            this.GridRents.AllowUserToDeleteRows = false;
            this.GridRents.AllowUserToOrderColumns = true;
            this.GridRents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridRents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRents.Location = new System.Drawing.Point(12, 79);
            this.GridRents.Name = "GridRents";
            this.GridRents.ReadOnly = true;
            this.GridRents.RowHeadersVisible = false;
            this.GridRents.RowHeadersWidth = 51;
            this.GridRents.RowTemplate.Height = 29;
            this.GridRents.Size = new System.Drawing.Size(962, 414);
            this.GridRents.TabIndex = 1;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(880, 25);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(94, 29);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "pdf";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PdfBtn_Click);
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 508);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.GridRents);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Rents";
            this.Text = "Rentas";
            ((System.ComponentModel.ISupportInitialize)(this.GridRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridRents;
        private System.Windows.Forms.Button PrintBtn;
    }
}