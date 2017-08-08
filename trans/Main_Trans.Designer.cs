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
            this.Excel_button = new System.Windows.Forms.Button();
            this.Target_button = new System.Windows.Forms.Button();
            this.Target_path = new System.Windows.Forms.TextBox();
            this.Excel_path = new System.Windows.Forms.TextBox();
            this.Transfer_Button = new System.Windows.Forms.Button();
            this.Trans_non_quo_botton = new System.Windows.Forms.Button();
            this.Quotation_choose = new System.Windows.Forms.TextBox();
            this.Script_destination_text = new System.Windows.Forms.TextBox();
            this.Script_save_destination = new System.Windows.Forms.Button();
            this.Script_source_text = new System.Windows.Forms.TextBox();
            this.Script_source = new System.Windows.Forms.Button();
            this.quotation_type_labe = new System.Windows.Forms.Label();
            this.Script_generate_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Replacement_Lable = new System.Windows.Forms.Label();
            this.Script_Lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Excel_button
            // 
            this.Excel_button.Location = new System.Drawing.Point(448, 77);
            this.Excel_button.Name = "Excel_button";
            this.Excel_button.Size = new System.Drawing.Size(136, 23);
            this.Excel_button.TabIndex = 0;
            this.Excel_button.Text = "open source excel";
            this.Excel_button.UseVisualStyleBackColor = true;
            this.Excel_button.Click += new System.EventHandler(this.Open_Excel);
            // 
            // Target_button
            // 
            this.Target_button.Location = new System.Drawing.Point(136, 78);
            this.Target_button.Name = "Target_button";
            this.Target_button.Size = new System.Drawing.Size(136, 23);
            this.Target_button.TabIndex = 1;
            this.Target_button.Text = "open target file";
            this.Target_button.UseVisualStyleBackColor = true;
            this.Target_button.Click += new System.EventHandler(this.Target_button_Click);
            // 
            // Target_path
            // 
            this.Target_path.Location = new System.Drawing.Point(107, 46);
            this.Target_path.Name = "Target_path";
            this.Target_path.Size = new System.Drawing.Size(191, 21);
            this.Target_path.TabIndex = 2;
            this.Target_path.TextChanged += new System.EventHandler(this.Target_path_TextChanged);
            // 
            // Excel_path
            // 
            this.Excel_path.Location = new System.Drawing.Point(424, 46);
            this.Excel_path.Name = "Excel_path";
            this.Excel_path.Size = new System.Drawing.Size(191, 21);
            this.Excel_path.TabIndex = 3;
            this.Excel_path.TextChanged += new System.EventHandler(this.Excel_path_TextChanged);
            // 
            // Transfer_Button
            // 
            this.Transfer_Button.Location = new System.Drawing.Point(435, 158);
            this.Transfer_Button.Name = "Transfer_Button";
            this.Transfer_Button.Size = new System.Drawing.Size(165, 55);
            this.Transfer_Button.TabIndex = 4;
            this.Transfer_Button.Text = "Transfer(source with quoation marks)";
            this.Transfer_Button.UseVisualStyleBackColor = true;
            this.Transfer_Button.Click += new System.EventHandler(this.Transfer_Button_Click);
            // 
            // Trans_non_quo_botton
            // 
            this.Trans_non_quo_botton.Location = new System.Drawing.Point(107, 158);
            this.Trans_non_quo_botton.Name = "Trans_non_quo_botton";
            this.Trans_non_quo_botton.Size = new System.Drawing.Size(191, 55);
            this.Trans_non_quo_botton.TabIndex = 5;
            this.Trans_non_quo_botton.Text = "Transfer( source without quoation marks)";
            this.Trans_non_quo_botton.UseVisualStyleBackColor = true;
            this.Trans_non_quo_botton.Click += new System.EventHandler(this.Trans_Non_Quo_Button_Click);
            // 
            // Quotation_choose
            // 
            this.Quotation_choose.Location = new System.Drawing.Point(198, 126);
            this.Quotation_choose.Name = "Quotation_choose";
            this.Quotation_choose.Size = new System.Drawing.Size(100, 21);
            this.Quotation_choose.TabIndex = 6;
            this.Quotation_choose.TextChanged += new System.EventHandler(this.Quotation_choose_TextChanged);
            // 
            // Script_destination_text
            // 
            this.Script_destination_text.Location = new System.Drawing.Point(15, 305);
            this.Script_destination_text.Name = "Script_destination_text";
            this.Script_destination_text.Size = new System.Drawing.Size(152, 21);
            this.Script_destination_text.TabIndex = 7;
            // 
            // Script_save_destination
            // 
            this.Script_save_destination.Location = new System.Drawing.Point(179, 303);
            this.Script_save_destination.Name = "Script_save_destination";
            this.Script_save_destination.Size = new System.Drawing.Size(168, 23);
            this.Script_save_destination.TabIndex = 10;
            this.Script_save_destination.Text = "Script Save Destination";
            this.Script_save_destination.UseVisualStyleBackColor = true;
            this.Script_save_destination.Click += new System.EventHandler(this.Script_save_button_click);
            // 
            // Script_source_text
            // 
            this.Script_source_text.Location = new System.Drawing.Point(374, 303);
            this.Script_source_text.Name = "Script_source_text";
            this.Script_source_text.Size = new System.Drawing.Size(152, 21);
            this.Script_source_text.TabIndex = 9;
            // 
            // Script_source
            // 
            this.Script_source.Location = new System.Drawing.Point(556, 303);
            this.Script_source.Name = "Script_source";
            this.Script_source.Size = new System.Drawing.Size(143, 23);
            this.Script_source.TabIndex = 11;
            this.Script_source.Text = "Script Source";
            this.Script_source.UseVisualStyleBackColor = true;
            this.Script_source.Click += new System.EventHandler(this.Script_source_button_click);
            // 
            // quotation_type_labe
            // 
            this.quotation_type_labe.AutoSize = true;
            this.quotation_type_labe.Location = new System.Drawing.Point(23, 130);
            this.quotation_type_labe.Name = "quotation_type_labe";
            this.quotation_type_labe.Size = new System.Drawing.Size(155, 12);
            this.quotation_type_labe.TabIndex = 12;
            this.quotation_type_labe.Text = "Quotation Mark Type: \'or\"";
            this.quotation_type_labe.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Script_generate_button
            // 
            this.Script_generate_button.Location = new System.Drawing.Point(292, 357);
            this.Script_generate_button.Name = "Script_generate_button";
            this.Script_generate_button.Size = new System.Drawing.Size(115, 23);
            this.Script_generate_button.TabIndex = 13;
            this.Script_generate_button.Text = "Generate Scripts";
            this.Script_generate_button.UseVisualStyleBackColor = true;
            this.Script_generate_button.Click += new System.EventHandler(this.Script_generate_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 10);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Replacement_Lable
            // 
            this.Replacement_Lable.AutoSize = true;
            this.Replacement_Lable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Replacement_Lable.Location = new System.Drawing.Point(289, 9);
            this.Replacement_Lable.Name = "Replacement_Lable";
            this.Replacement_Lable.Size = new System.Drawing.Size(152, 16);
            this.Replacement_Lable.TabIndex = 15;
            this.Replacement_Lable.Text = "String Replacement";
            // 
            // Script_Lable
            // 
            this.Script_Lable.AutoSize = true;
            this.Script_Lable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Script_Lable.Location = new System.Drawing.Point(265, 253);
            this.Script_Lable.Name = "Script_Lable";
            this.Script_Lable.Size = new System.Drawing.Size(200, 16);
            this.Script_Lable.TabIndex = 16;
            this.Script_Lable.Text = "Update Script Generation";
            this.Script_Lable.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.Script_Lable);
            this.Controls.Add(this.Replacement_Lable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Script_generate_button);
            this.Controls.Add(this.quotation_type_labe);
            this.Controls.Add(this.Script_source);
            this.Controls.Add(this.Script_save_destination);
            this.Controls.Add(this.Script_source_text);
            this.Controls.Add(this.Script_destination_text);
            this.Controls.Add(this.Quotation_choose);
            this.Controls.Add(this.Trans_non_quo_botton);
            this.Controls.Add(this.Transfer_Button);
            this.Controls.Add(this.Excel_path);
            this.Controls.Add(this.Target_path);
            this.Controls.Add(this.Target_button);
            this.Controls.Add(this.Excel_button);
            this.Name = "Main_Trans";
            this.Text = "Excel Trans";
            this.Load += new System.EventHandler(this.Main_Trans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excel_button;
        private System.Windows.Forms.Button Target_button;
        private System.Windows.Forms.TextBox Target_path;
        private System.Windows.Forms.TextBox Excel_path;
        private System.Windows.Forms.Button Transfer_Button;
        private System.Windows.Forms.Button Trans_non_quo_botton;
        private System.Windows.Forms.TextBox Quotation_choose;
        private System.Windows.Forms.TextBox Script_destination_text;
        private System.Windows.Forms.Button Script_save_destination;
        private System.Windows.Forms.TextBox Script_source_text;
        private System.Windows.Forms.Button Script_source;
        private System.Windows.Forms.Label quotation_type_labe;
        private System.Windows.Forms.Button Script_generate_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Replacement_Lable;
        private System.Windows.Forms.Label Script_Lable;
    }
}

