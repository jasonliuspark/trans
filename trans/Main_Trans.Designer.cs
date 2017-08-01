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
            this.Trans_non_quo_botton = new System.Windows.Forms.Button();
            this.quotation_choose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // excel_button
            // 
            this.excel_button.Location = new System.Drawing.Point(262, 182);
            this.excel_button.Name = "excel_button";
            this.excel_button.Size = new System.Drawing.Size(136, 23);
            this.excel_button.TabIndex = 0;
            this.excel_button.Text = "open excel";
            this.excel_button.UseVisualStyleBackColor = true;
            this.excel_button.Click += new System.EventHandler(this.Open_Excel);
            // 
            // target_button
            // 
            this.target_button.Location = new System.Drawing.Point(262, 87);
            this.target_button.Name = "target_button";
            this.target_button.Size = new System.Drawing.Size(136, 23);
            this.target_button.TabIndex = 1;
            this.target_button.Text = "open target file";
            this.target_button.UseVisualStyleBackColor = true;
            this.target_button.Click += new System.EventHandler(this.target_button_Click);
            // 
            // target_path
            // 
            this.target_path.Location = new System.Drawing.Point(233, 47);
            this.target_path.Name = "target_path";
            this.target_path.Size = new System.Drawing.Size(191, 21);
            this.target_path.TabIndex = 2;
            this.target_path.TextChanged += new System.EventHandler(this.target_path_TextChanged);
            // 
            // excel_path
            // 
            this.excel_path.Location = new System.Drawing.Point(233, 155);
            this.excel_path.Name = "excel_path";
            this.excel_path.Size = new System.Drawing.Size(191, 21);
            this.excel_path.TabIndex = 3;
            this.excel_path.TextChanged += new System.EventHandler(this.excel_path_TextChanged);
            // 
            // Transfer_Button
            // 
            this.Transfer_Button.Location = new System.Drawing.Point(392, 277);
            this.Transfer_Button.Name = "Transfer_Button";
            this.Transfer_Button.Size = new System.Drawing.Size(165, 55);
            this.Transfer_Button.TabIndex = 4;
            this.Transfer_Button.Text = "Transfer(source with quoation marks)";
            this.Transfer_Button.UseVisualStyleBackColor = true;
            this.Transfer_Button.Click += new System.EventHandler(this.Transfer_Button_Click);
            // 
            // Trans_non_quo_botton
            // 
            this.Trans_non_quo_botton.Location = new System.Drawing.Point(102, 277);
            this.Trans_non_quo_botton.Name = "Trans_non_quo_botton";
            this.Trans_non_quo_botton.Size = new System.Drawing.Size(191, 55);
            this.Trans_non_quo_botton.TabIndex = 5;
            this.Trans_non_quo_botton.Text = "Transfer( source without quoation marks)";
            this.Trans_non_quo_botton.UseVisualStyleBackColor = true;
            this.Trans_non_quo_botton.Click += new System.EventHandler(this.Trans_Non_Quo_Button_Click);
            // 
            // quotation_choose
            // 
            this.quotation_choose.Location = new System.Drawing.Point(145, 231);
            this.quotation_choose.Name = "quotation_choose";
            this.quotation_choose.Size = new System.Drawing.Size(100, 21);
            this.quotation_choose.TabIndex = 6;
            this.quotation_choose.TextChanged += new System.EventHandler(this.quotation_choose_TextChanged);
            // 
            // Main_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 403);
            this.Controls.Add(this.quotation_choose);
            this.Controls.Add(this.Trans_non_quo_botton);
            this.Controls.Add(this.Transfer_Button);
            this.Controls.Add(this.excel_path);
            this.Controls.Add(this.target_path);
            this.Controls.Add(this.target_button);
            this.Controls.Add(this.excel_button);
            this.Name = "Main_Trans";
            this.Text = "Excel Trans";
            this.Load += new System.EventHandler(this.Main_Trans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excel_button;
        private System.Windows.Forms.Button target_button;
        private System.Windows.Forms.TextBox target_path;
        private System.Windows.Forms.TextBox excel_path;
        private System.Windows.Forms.Button Transfer_Button;
        private System.Windows.Forms.Button Trans_non_quo_botton;
        private System.Windows.Forms.TextBox quotation_choose;
    }
}

