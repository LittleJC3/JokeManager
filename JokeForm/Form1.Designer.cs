
namespace JokeForm
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
            this.jokeTB = new System.Windows.Forms.TextBox();
            this.sixtwoTB = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.JokeLBL = new System.Windows.Forms.Label();
            this.sixtwoLBL = new System.Windows.Forms.Label();
            this.storedLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jokeTB
            // 
            this.jokeTB.Location = new System.Drawing.Point(225, 264);
            this.jokeTB.Name = "jokeTB";
            this.jokeTB.Size = new System.Drawing.Size(243, 22);
            this.jokeTB.TabIndex = 0;
            // 
            // sixtwoTB
            // 
            this.sixtwoTB.Location = new System.Drawing.Point(693, 264);
            this.sixtwoTB.Name = "sixtwoTB";
            this.sixtwoTB.Size = new System.Drawing.Size(265, 22);
            this.sixtwoTB.TabIndex = 1;
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(489, 355);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(191, 32);
            this.submitBTN.TabIndex = 2;
            this.submitBTN.Text = "Submit Hilarious Joke";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // JokeLBL
            // 
            this.JokeLBL.AutoSize = true;
            this.JokeLBL.Location = new System.Drawing.Point(314, 244);
            this.JokeLBL.Name = "JokeLBL";
            this.JokeLBL.Size = new System.Drawing.Size(76, 17);
            this.JokeLBL.TabIndex = 3;
            this.JokeLBL.Text = "Enter Joke";
            // 
            // sixtwoLBL
            // 
            this.sixtwoLBL.AutoSize = true;
            this.sixtwoLBL.Location = new System.Drawing.Point(792, 244);
            this.sixtwoLBL.Name = "sixtwoLBL";
            this.sixtwoLBL.Size = new System.Drawing.Size(70, 17);
            this.sixtwoLBL.TabIndex = 4;
            this.sixtwoLBL.Text = "Enter 6+2";
            // 
            // storedLBL
            // 
            this.storedLBL.AutoSize = true;
            this.storedLBL.Location = new System.Drawing.Point(450, 92);
            this.storedLBL.Name = "storedLBL";
            this.storedLBL.Size = new System.Drawing.Size(0, 17);
            this.storedLBL.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 480);
            this.Controls.Add(this.storedLBL);
            this.Controls.Add(this.sixtwoLBL);
            this.Controls.Add(this.JokeLBL);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.sixtwoTB);
            this.Controls.Add(this.jokeTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jokeTB;
        private System.Windows.Forms.TextBox sixtwoTB;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Label JokeLBL;
        private System.Windows.Forms.Label sixtwoLBL;
        private System.Windows.Forms.Label storedLBL;
    }
}

