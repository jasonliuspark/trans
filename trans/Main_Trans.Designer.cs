namespace trans
{
    partial class Main_Trans
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
            this.excel_button = new System.Windows.Forms.Button();
            this.target_button = new System.Windows.Forms.Button();
            this.target_path = new System.Windows.Forms.TextBox();
            this.excel_path = new System.Windows.Forms.TextBox();
            this.Transfer_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // excel_button
            // 
            this.excel_button.Location = new System.Drawing.Point(73, 197);
            this.excel_button.Name = "excel_button";
            this.excel_button.Size = new System.Drawing.Size(136, 23);
            this.excel_button.TabIndex = 0;
            this.excel_button.Text = "open excel";
            this.excel_button.UseVisualStyleBackColor = true;
            this.excel_button.Click += new System.EventHandler(this.Open_Excel);
            // 
            // target_button
            // 
            this.target_button.Location = new System.Drawing.Point(73, 107);
            this.target_button.Name = "target_button";
            this.target_button.Size = new System.Drawing.Size(136, 23);
            this.target_button.TabIndex = 1;
            this.target_button.Text = "open target file";
            this.target_button.UseVisualStyleBackColor = true;
            this.target_button.Click += new System.EventHandler(this.target_button_Click);
            // 
            // target_path
            // 
            this.target_path.Location = new System.Drawing.Point(44, 67);
            this.target_path.Name = "target_path";
            this.target_path.Size = new System.Drawing.Size(191, 21);
            this.target_path.TabIndex = 2;
            this.target_path.TextChanged += new System.EventHandler(this.target_path_TextChanged);
            // 
            // excel_path
            // 
            this.excel_path.Location = new System.Drawing.Point(44, 170);
            this.excel_path.Name = "excel_path";
            this.excel_path.Size = new System.Drawing.Size(191, 21);
            this.excel_path.TabIndex = 3;
            this.excel_path.TextChanged += new System.EventHandler(this.excel_path_TextChanged);
            // 
            // Transfer_Button
            // 
            this.Transfer_Button.Location = new System.Drawing.Point(279, 125);
            this.Transfer_Button.Name = "Transfer_Button";
            this.Transfer_Button.Size = new System.Drawing.Size(75, 23);
            this.Transfer_Button.TabIndex = 4;
            this.Transfer_Button.Text = "Transfer";
            this.Transfer_Button.UseVisualStyleBackColor = true;
            this.Transfer_Button.Click += new System.EventHandler(this.Transfer_Button_Click);
            // 
            // Main_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 307);
            this.Controls.Add(this.Transfer_Button);
            this.Controls.Add(this.excel_path);
            this.Controls.Add(this.target_path);
            this.Controls.Add(this.target_button);
            this.Controls.Add(this.excel_button);
            this.Name = "Main_Trans";
            this.Text = "Excel Trans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excel_button;
        private System.Windows.Forms.Button target_button;
        private System.Windows.Forms.TextBox target_path;
        private System.Windows.Forms.TextBox excel_path;
        private System.Windows.Forms.Button Transfer_Button;
    }
}

