namespace MathApp
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.subRadio = new System.Windows.Forms.RadioButton();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.multiRadio = new System.Windows.Forms.RadioButton();
            this.divRadio = new System.Windows.Forms.RadioButton();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.lblMath = new System.Windows.Forms.Label();
            this.correctLbl = new System.Windows.Forms.Label();
            this.beginBtn = new System.Windows.Forms.Button();
            this.quesAskLbl = new System.Windows.Forms.Label();
            this.finalScoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(249, 187);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(100, 23);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // subRadio
            // 
            this.subRadio.AutoSize = true;
            this.subRadio.Location = new System.Drawing.Point(103, 12);
            this.subRadio.Name = "subRadio";
            this.subRadio.Size = new System.Drawing.Size(77, 17);
            this.subRadio.TabIndex = 1;
            this.subRadio.TabStop = true;
            this.subRadio.Text = "subtraction";
            this.subRadio.UseVisualStyleBackColor = true;
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(12, 12);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(62, 17);
            this.addRadio.TabIndex = 1;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "addition";
            this.addRadio.UseVisualStyleBackColor = true;
            // 
            // multiRadio
            // 
            this.multiRadio.AutoSize = true;
            this.multiRadio.Location = new System.Drawing.Point(194, 12);
            this.multiRadio.Name = "multiRadio";
            this.multiRadio.Size = new System.Drawing.Size(85, 17);
            this.multiRadio.TabIndex = 1;
            this.multiRadio.TabStop = true;
            this.multiRadio.Text = "multiplication";
            this.multiRadio.UseVisualStyleBackColor = true;
            // 
            // divRadio
            // 
            this.divRadio.AutoSize = true;
            this.divRadio.Location = new System.Drawing.Point(285, 12);
            this.divRadio.Name = "divRadio";
            this.divRadio.Size = new System.Drawing.Size(60, 17);
            this.divRadio.TabIndex = 1;
            this.divRadio.TabStop = true;
            this.divRadio.Text = "division";
            this.divRadio.UseVisualStyleBackColor = true;
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(249, 161);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(100, 20);
            this.answerTxtBox.TabIndex = 2;
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Location = new System.Drawing.Point(167, 168);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(0, 13);
            this.lblMath.TabIndex = 3;
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Location = new System.Drawing.Point(180, 332);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(11, 13);
            this.correctLbl.TabIndex = 4;
            this.correctLbl.Text = "*";
            // 
            // beginBtn
            // 
            this.beginBtn.Location = new System.Drawing.Point(12, 35);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(100, 23);
            this.beginBtn.TabIndex = 0;
            this.beginBtn.Text = "Begin";
            this.beginBtn.UseVisualStyleBackColor = true;
            this.beginBtn.Click += new System.EventHandler(this.BeginBtn_Click);
            // 
            // quesAskLbl
            // 
            this.quesAskLbl.AutoSize = true;
            this.quesAskLbl.Location = new System.Drawing.Point(180, 278);
            this.quesAskLbl.Name = "quesAskLbl";
            this.quesAskLbl.Size = new System.Drawing.Size(11, 13);
            this.quesAskLbl.TabIndex = 4;
            this.quesAskLbl.Text = "*";
            // 
            // finalScoreLbl
            // 
            this.finalScoreLbl.AutoSize = true;
            this.finalScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLbl.Location = new System.Drawing.Point(123, 110);
            this.finalScoreLbl.Name = "finalScoreLbl";
            this.finalScoreLbl.Size = new System.Drawing.Size(21, 25);
            this.finalScoreLbl.TabIndex = 4;
            this.finalScoreLbl.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalScoreLbl);
            this.Controls.Add(this.quesAskLbl);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.addRadio);
            this.Controls.Add(this.divRadio);
            this.Controls.Add(this.multiRadio);
            this.Controls.Add(this.subRadio);
            this.Controls.Add(this.beginBtn);
            this.Controls.Add(this.enterBtn);
            this.Name = "Form1";
            this.Text = "Nolting Mathematics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.RadioButton subRadio;
        private System.Windows.Forms.RadioButton addRadio;
        private System.Windows.Forms.RadioButton multiRadio;
        private System.Windows.Forms.RadioButton divRadio;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.Label quesAskLbl;
        private System.Windows.Forms.Label finalScoreLbl;
    }
}

