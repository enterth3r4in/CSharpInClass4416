namespace CSharpInClass4416
{
    partial class DiceTwo
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
            this.btnRollTwo = new System.Windows.Forms.Button();
            this.tbDiceResultTwo = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRollTwo
            // 
            this.btnRollTwo.Location = new System.Drawing.Point(101, 160);
            this.btnRollTwo.Name = "btnRollTwo";
            this.btnRollTwo.Size = new System.Drawing.Size(83, 35);
            this.btnRollTwo.TabIndex = 3;
            this.btnRollTwo.Text = "Roll Two";
            this.btnRollTwo.UseVisualStyleBackColor = true;
            this.btnRollTwo.Click += new System.EventHandler(this.btnRollTwo_Click);
            // 
            // tbDiceResultTwo
            // 
            this.tbDiceResultTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiceResultTwo.Location = new System.Drawing.Point(101, 67);
            this.tbDiceResultTwo.Name = "tbDiceResultTwo";
            this.tbDiceResultTwo.Size = new System.Drawing.Size(83, 26);
            this.tbDiceResultTwo.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(101, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DiceTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRollTwo);
            this.Controls.Add(this.tbDiceResultTwo);
            this.Name = "DiceTwo";
            this.Text = "DiceTwo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollTwo;
        private System.Windows.Forms.TextBox tbDiceResultTwo;
        private System.Windows.Forms.Button btnExit;
    }
}