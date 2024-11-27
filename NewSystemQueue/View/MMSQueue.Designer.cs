namespace NewSystemQueue.View
{
    partial class MMSQueue
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
            this.lblMMSReultP0 = new System.Windows.Forms.Label();
            this.txtP0 = new System.Windows.Forms.TextBox();
            this.txtServicesCount = new System.Windows.Forms.TextBox();
            this.txtMho = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.btnCalcP0 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMMSReultP0
            // 
            this.lblMMSReultP0.AutoSize = true;
            this.lblMMSReultP0.Location = new System.Drawing.Point(449, 267);
            this.lblMMSReultP0.Name = "lblMMSReultP0";
            this.lblMMSReultP0.Size = new System.Drawing.Size(24, 17);
            this.lblMMSReultP0.TabIndex = 26;
            this.lblMMSReultP0.Text = "P0";
            // 
            // txtP0
            // 
            this.txtP0.Location = new System.Drawing.Point(238, 260);
            this.txtP0.Name = "txtP0";
            this.txtP0.Size = new System.Drawing.Size(193, 24);
            this.txtP0.TabIndex = 21;
            // 
            // txtServicesCount
            // 
            this.txtServicesCount.Location = new System.Drawing.Point(238, 144);
            this.txtServicesCount.Name = "txtServicesCount";
            this.txtServicesCount.Size = new System.Drawing.Size(193, 24);
            this.txtServicesCount.TabIndex = 22;
            // 
            // txtMho
            // 
            this.txtMho.Location = new System.Drawing.Point(238, 85);
            this.txtMho.Name = "txtMho";
            this.txtMho.Size = new System.Drawing.Size(193, 24);
            this.txtMho.TabIndex = 19;
            // 
            // txtLambda
            // 
            this.txtLambda.BackColor = System.Drawing.Color.White;
            this.txtLambda.Location = new System.Drawing.Point(238, 36);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(193, 24);
            this.txtLambda.TabIndex = 17;
            // 
            // btnCalcP0
            // 
            this.btnCalcP0.Location = new System.Drawing.Point(238, 199);
            this.btnCalcP0.Name = "btnCalcP0";
            this.btnCalcP0.Size = new System.Drawing.Size(193, 28);
            this.btnCalcP0.TabIndex = 25;
            this.btnCalcP0.Text = "Calc P";
            this.btnCalcP0.UseVisualStyleBackColor = true;
            this.btnCalcP0.Click += new System.EventHandler(this.btnCalcP0_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Services Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "mho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(462, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "lambda";
            // 
            // MMSQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMMSReultP0);
            this.Controls.Add(this.txtP0);
            this.Controls.Add(this.txtServicesCount);
            this.Controls.Add(this.txtMho);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.btnCalcP0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "MMSQueue";
            this.Text = "MMSQueue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMMSReultP0;
        private System.Windows.Forms.TextBox txtP0;
        private System.Windows.Forms.TextBox txtServicesCount;
        private System.Windows.Forms.TextBox txtMho;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Button btnCalcP0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}