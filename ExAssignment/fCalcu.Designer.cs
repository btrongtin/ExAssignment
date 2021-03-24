namespace ExAssignment
{
    partial class fCalcu
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
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn N";
            // 
            // cbInput
            // 
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Location = new System.Drawing.Point(46, 48);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(144, 21);
            this.cbInput.TabIndex = 1;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(241, 48);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(147, 225);
            this.lstResult.TabIndex = 2;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(55, 85);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(126, 50);
            this.btnWork.TabIndex = 3;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(55, 151);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 50);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(55, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // fCalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.cbInput);
            this.Controls.Add(this.label1);
            this.Name = "fCalcu";
            this.Text = "fCalcu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}