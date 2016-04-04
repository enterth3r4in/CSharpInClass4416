namespace CSharpInClass4416
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
            this.tbDiceResult = new System.Windows.Forms.TextBox();
            this.btnRollOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDiceResult
            // 
            this.tbDiceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiceResult.Location = new System.Drawing.Point(65, 12);
            this.tbDiceResult.Name = "tbDiceResult";
            this.tbDiceResult.Size = new System.Drawing.Size(83, 26);
            this.tbDiceResult.TabIndex = 0;
            // 
            // btnRollOne
            // 
            this.btnRollOne.Location = new System.Drawing.Point(65, 105);
            this.btnRollOne.Name = "btnRollOne";
            this.btnRollOne.Size = new System.Drawing.Size(83, 35);
            this.btnRollOne.TabIndex = 1;
            this.btnRollOne.Text = "Roll One";
            this.btnRollOne.UseVisualStyleBackColor = true;
            this.btnRollOne.Click += new System.EventHandler(this.btnRollOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 152);
            this.Controls.Add(this.btnRollOne);
            this.Controls.Add(this.tbDiceResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDiceResult;
        private System.Windows.Forms.Button btnRollOne;
    }
}

