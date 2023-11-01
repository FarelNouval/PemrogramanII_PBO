namespace P6_1_1214070
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
            this.label1 = new System.Windows.Forms.Label();
            this.vbButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which do you think is better, Visual Basic or C#?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vbButton
            // 
            this.vbButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vbButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton.ForeColor = System.Drawing.Color.Green;
            this.vbButton.Location = new System.Drawing.Point(208, 204);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(116, 43);
            this.vbButton.TabIndex = 1;
            this.vbButton.Text = "Visual Basic";
            this.vbButton.UseVisualStyleBackColor = false;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // csButton
            // 
            this.csButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.csButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton.ForeColor = System.Drawing.Color.Red;
            this.csButton.Location = new System.Drawing.Point(458, 204);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(116, 43);
            this.csButton.TabIndex = 2;
            this.csButton.Text = "C#";
            this.csButton.UseVisualStyleBackColor = false;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.closeButton.Location = new System.Drawing.Point(69, 392);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 35);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.vbButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
    }
}

