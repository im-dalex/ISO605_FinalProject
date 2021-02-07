
namespace TeteoRentCar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenRentasForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenRentasForm
            // 
            this.OpenRentasForm.Location = new System.Drawing.Point(562, 22);
            this.OpenRentasForm.Name = "OpenRentasForm";
            this.OpenRentasForm.Size = new System.Drawing.Size(182, 29);
            this.OpenRentasForm.TabIndex = 0;
            this.OpenRentasForm.Text = "Rentas y devoluciones";
            this.OpenRentasForm.UseVisualStyleBackColor = true;
            this.OpenRentasForm.Click += new System.EventHandler(this.OpenRentasForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenRentasForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenRentasForm;
    }
}

