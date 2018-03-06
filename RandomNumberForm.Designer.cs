namespace RandomNumber
{
    partial class frmRandomNumber
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblStateAnswer = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblText.Location = new System.Drawing.Point(12, 30);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(639, 26);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Click the button to generate a random number between 1 and 25.";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCalc.Location = new System.Drawing.Point(233, 93);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(218, 35);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Generate Number";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblStateAnswer
            // 
            this.lblStateAnswer.AutoSize = true;
            this.lblStateAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStateAnswer.Location = new System.Drawing.Point(213, 192);
            this.lblStateAnswer.Name = "lblStateAnswer";
            this.lblStateAnswer.Size = new System.Drawing.Size(156, 26);
            this.lblStateAnswer.TabIndex = 2;
            this.lblStateAnswer.Text = "The number is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAnswer.Location = new System.Drawing.Point(375, 192);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(85, 26);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer";
            // 
            // frmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 261);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblStateAnswer);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblText);
            this.Name = "frmRandomNumber";
            this.Text = "Random Number";
            this.Load += new System.EventHandler(this.frmRandomNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblStateAnswer;
        private System.Windows.Forms.Label lblAnswer;
    }
}

