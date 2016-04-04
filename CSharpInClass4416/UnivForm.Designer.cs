namespace CSharpInClass4416
{
    partial class UnivForm
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
            this.btnGather = new System.Windows.Forms.Button();
            this.tbNameUniv = new System.Windows.Forms.TextBox();
            this.tbDoCreditsTransfer = new System.Windows.Forms.TextBox();
            this.tbCostPerSemester = new System.Windows.Forms.TextBox();
            this.tbFieldOfStudy = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblFieldOfStudy = new System.Windows.Forms.Label();
            this.lblCostPerSemester = new System.Windows.Forms.Label();
            this.lblDoCreditsTransfer = new System.Windows.Forms.Label();
            this.tbDisplayOutput = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGather
            // 
            this.btnGather.Location = new System.Drawing.Point(144, 152);
            this.btnGather.Name = "btnGather";
            this.btnGather.Size = new System.Drawing.Size(75, 23);
            this.btnGather.TabIndex = 6;
            this.btnGather.Text = "Gather Info";
            this.btnGather.UseVisualStyleBackColor = true;
            this.btnGather.Click += new System.EventHandler(this.btnGather_Click);
            // 
            // tbNameUniv
            // 
            this.tbNameUniv.Location = new System.Drawing.Point(144, 12);
            this.tbNameUniv.Name = "tbNameUniv";
            this.tbNameUniv.Size = new System.Drawing.Size(206, 20);
            this.tbNameUniv.TabIndex = 1;
            // 
            // tbDoCreditsTransfer
            // 
            this.tbDoCreditsTransfer.Location = new System.Drawing.Point(177, 116);
            this.tbDoCreditsTransfer.Name = "tbDoCreditsTransfer";
            this.tbDoCreditsTransfer.Size = new System.Drawing.Size(173, 20);
            this.tbDoCreditsTransfer.TabIndex = 5;
            // 
            // tbCostPerSemester
            // 
            this.tbCostPerSemester.Location = new System.Drawing.Point(144, 90);
            this.tbCostPerSemester.Name = "tbCostPerSemester";
            this.tbCostPerSemester.Size = new System.Drawing.Size(206, 20);
            this.tbCostPerSemester.TabIndex = 4;
            // 
            // tbFieldOfStudy
            // 
            this.tbFieldOfStudy.Location = new System.Drawing.Point(144, 64);
            this.tbFieldOfStudy.Name = "tbFieldOfStudy";
            this.tbFieldOfStudy.Size = new System.Drawing.Size(206, 20);
            this.tbFieldOfStudy.TabIndex = 3;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(144, 38);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(206, 20);
            this.tbLocation.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name of Univ.";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 41);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(88, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location of Univ.";
            // 
            // lblFieldOfStudy
            // 
            this.lblFieldOfStudy.AutoSize = true;
            this.lblFieldOfStudy.Location = new System.Drawing.Point(12, 67);
            this.lblFieldOfStudy.Name = "lblFieldOfStudy";
            this.lblFieldOfStudy.Size = new System.Drawing.Size(71, 13);
            this.lblFieldOfStudy.TabIndex = 8;
            this.lblFieldOfStudy.Text = "Field of Study";
            // 
            // lblCostPerSemester
            // 
            this.lblCostPerSemester.AutoSize = true;
            this.lblCostPerSemester.Location = new System.Drawing.Point(12, 93);
            this.lblCostPerSemester.Name = "lblCostPerSemester";
            this.lblCostPerSemester.Size = new System.Drawing.Size(94, 13);
            this.lblCostPerSemester.TabIndex = 9;
            this.lblCostPerSemester.Text = "Cost Per Semester";
            // 
            // lblDoCreditsTransfer
            // 
            this.lblDoCreditsTransfer.AutoSize = true;
            this.lblDoCreditsTransfer.Location = new System.Drawing.Point(12, 119);
            this.lblDoCreditsTransfer.Name = "lblDoCreditsTransfer";
            this.lblDoCreditsTransfer.Size = new System.Drawing.Size(152, 13);
            this.lblDoCreditsTransfer.TabIndex = 10;
            this.lblDoCreditsTransfer.Text = "Do Credits Transfer (true/false)";
            // 
            // tbDisplayOutput
            // 
            this.tbDisplayOutput.Location = new System.Drawing.Point(93, 181);
            this.tbDisplayOutput.Multiline = true;
            this.tbDisplayOutput.Name = "tbDisplayOutput";
            this.tbDisplayOutput.Size = new System.Drawing.Size(257, 118);
            this.tbDisplayOutput.TabIndex = 11;
            this.tbDisplayOutput.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UnivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbDisplayOutput);
            this.Controls.Add(this.lblDoCreditsTransfer);
            this.Controls.Add(this.lblCostPerSemester);
            this.Controls.Add(this.lblFieldOfStudy);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbFieldOfStudy);
            this.Controls.Add(this.tbCostPerSemester);
            this.Controls.Add(this.tbDoCreditsTransfer);
            this.Controls.Add(this.tbNameUniv);
            this.Controls.Add(this.btnGather);
            this.Name = "UnivForm";
            this.Text = "UnivForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGather;
        private System.Windows.Forms.TextBox tbNameUniv;
        private System.Windows.Forms.TextBox tbDoCreditsTransfer;
        private System.Windows.Forms.TextBox tbCostPerSemester;
        private System.Windows.Forms.TextBox tbFieldOfStudy;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblFieldOfStudy;
        private System.Windows.Forms.Label lblCostPerSemester;
        private System.Windows.Forms.Label lblDoCreditsTransfer;
        private System.Windows.Forms.TextBox tbDisplayOutput;
        private System.Windows.Forms.Button btnExit;
    }
}