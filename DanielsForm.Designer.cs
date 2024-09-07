namespace PixisAir_Team3_dg
{
    partial class DanielsForm
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
            this.DB2DataListBox = new System.Windows.Forms.ListBox();
            this.ResHistButton = new System.Windows.Forms.Button();
            this.ResHistGroupBox = new System.Windows.Forms.GroupBox();
            this.CarTableGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.CarsButton = new System.Windows.Forms.Button();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResHistGroupBox.SuspendLayout();
            this.CarTableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DB2DataListBox
            // 
            this.DB2DataListBox.FormattingEnabled = true;
            this.DB2DataListBox.ItemHeight = 14;
            this.DB2DataListBox.Location = new System.Drawing.Point(13, 12);
            this.DB2DataListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DB2DataListBox.Name = "DB2DataListBox";
            this.DB2DataListBox.Size = new System.Drawing.Size(588, 242);
            this.DB2DataListBox.TabIndex = 0;
            // 
            // ResHistButton
            // 
            this.ResHistButton.Location = new System.Drawing.Point(15, 21);
            this.ResHistButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResHistButton.Name = "ResHistButton";
            this.ResHistButton.Size = new System.Drawing.Size(175, 25);
            this.ResHistButton.TabIndex = 1;
            this.ResHistButton.Text = "List All Reservations";
            this.ResHistButton.UseVisualStyleBackColor = true;
            this.ResHistButton.Click += new System.EventHandler(this.RESHISTButton_Click);
            // 
            // ResHistGroupBox
            // 
            this.ResHistGroupBox.Controls.Add(this.ResHistButton);
            this.ResHistGroupBox.Location = new System.Drawing.Point(400, 260);
            this.ResHistGroupBox.Name = "ResHistGroupBox";
            this.ResHistGroupBox.Size = new System.Drawing.Size(202, 62);
            this.ResHistGroupBox.TabIndex = 2;
            this.ResHistGroupBox.TabStop = false;
            this.ResHistGroupBox.Text = "Reservation History";
            // 
            // CarTableGroupBox
            // 
            this.CarTableGroupBox.Controls.Add(this.ModelTextBox);
            this.CarTableGroupBox.Controls.Add(this.CarsButton);
            this.CarTableGroupBox.Controls.Add(this.MakeTextBox);
            this.CarTableGroupBox.Controls.Add(this.IDTextBox);
            this.CarTableGroupBox.Controls.Add(this.ModelLabel);
            this.CarTableGroupBox.Controls.Add(this.MakeLabel);
            this.CarTableGroupBox.Controls.Add(this.IDLabel);
            this.CarTableGroupBox.Controls.Add(this.AddCarButton);
            this.CarTableGroupBox.Location = new System.Drawing.Point(12, 260);
            this.CarTableGroupBox.Name = "CarTableGroupBox";
            this.CarTableGroupBox.Size = new System.Drawing.Size(381, 95);
            this.CarTableGroupBox.TabIndex = 3;
            this.CarTableGroupBox.TabStop = false;
            this.CarTableGroupBox.Text = "Cars Table";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(192, 26);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(84, 22);
            this.ModelTextBox.TabIndex = 10;
            // 
            // CarsButton
            // 
            this.CarsButton.Location = new System.Drawing.Point(130, 60);
            this.CarsButton.Name = "CarsButton";
            this.CarsButton.Size = new System.Drawing.Size(120, 23);
            this.CarsButton.TabIndex = 0;
            this.CarsButton.Text = "List All Cars";
            this.CarsButton.UseVisualStyleBackColor = true;
            this.CarsButton.Click += new System.EventHandler(this.CarsButton_Click);
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(102, 26);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(84, 22);
            this.MakeTextBox.TabIndex = 9;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(12, 26);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(84, 22);
            this.IDTextBox.TabIndex = 8;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(208, 12);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(42, 14);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(125, 12);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(35, 14);
            this.MakeLabel.TabIndex = 6;
            this.MakeLabel.Text = "Make";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(34, 12);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(49, 14);
            this.IDLabel.TabIndex = 5;
            this.IDLabel.Text = "Car ID";
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(282, 26);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(84, 22);
            this.AddCarButton.TabIndex = 4;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(415, 332);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(515, 332);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DanielsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 367);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CarTableGroupBox);
            this.Controls.Add(this.ResHistGroupBox);
            this.Controls.Add(this.DB2DataListBox);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DanielsForm";
            this.Text = "DanielsForm";
            this.ResHistGroupBox.ResumeLayout(false);
            this.CarTableGroupBox.ResumeLayout(false);
            this.CarTableGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DB2DataListBox;
        private System.Windows.Forms.Button ResHistButton;
        private System.Windows.Forms.GroupBox ResHistGroupBox;
        private System.Windows.Forms.GroupBox CarTableGroupBox;
        private System.Windows.Forms.Button CarsButton;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
