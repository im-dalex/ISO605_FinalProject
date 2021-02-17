
namespace TeteoRentCar.Views.Maintenance
{
    partial class VehicleCRUD
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
            this.btnSave = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 133);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(490, 477);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 29);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(712, 477);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripcion:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 133);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 66);
            this.txtDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cbStatus.Location = new System.Drawing.Point(134, 440);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 28);
            this.cbStatus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(391, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vehiculos";
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(134, 401);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(160, 28);
            this.cbModel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modelo:";
            // 
            // cbFuel
            // 
            this.cbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(134, 361);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(160, 28);
            this.cbFuel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Combustible:";
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(134, 226);
            this.txtChassis.MaxLength = 20;
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(160, 27);
            this.txtChassis.TabIndex = 13;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(134, 319);
            this.txtLicense.MaxLength = 20;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(160, 27);
            this.txtLicense.TabIndex = 14;
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(134, 273);
            this.txtMotor.MaxLength = 20;
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(160, 27);
            this.txtMotor.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Licencia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "No. Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "No. Chassis:";
            // 
            // VehicleCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.txtChassis);
            this.Controls.Add(this.cbFuel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VehicleCRUD";
            this.Text = "VehicleCRUD";
            this.Load += new System.EventHandler(this.VehicleCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}