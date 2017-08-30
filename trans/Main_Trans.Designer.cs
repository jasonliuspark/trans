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
            this.Script_destination_text = new System.Windows.Forms.TextBox();
            this.Script_save_destination = new System.Windows.Forms.Button();
            this.Script_source_text = new System.Windows.Forms.TextBox();
            this.Script_source = new System.Windows.Forms.Button();
            this.Script_generate_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Replacement_Lable = new System.Windows.Forms.Label();
            this.Script_Lable = new System.Windows.Forms.Label();
            this.Test_con = new System.Windows.Forms.Button();
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
            // Script_destination_text
            // 
            this.Script_destination_text.Location = new System.Drawing.Point(15, 234);
            this.Script_destination_text.Name = "Script_destination_text";
            this.Script_destination_text.Size = new System.Drawing.Size(152, 21);
            this.Script_destination_text.TabIndex = 7;
            // 
            // Script_save_destination
            // 
            this.Script_save_destination.Location = new System.Drawing.Point(179, 232);
            this.Script_save_destination.Name = "Script_save_destination";
            this.Script_save_destination.Size = new System.Drawing.Size(168, 23);
            this.Script_save_destination.TabIndex = 10;
            this.Script_save_destination.Text = "Script Save Destination";
            this.Script_save_destination.UseVisualStyleBackColor = true;
            this.Script_save_destination.Click += new System.EventHandler(this.Script_save_button_click);
            // 
            // Script_source_text
            // 
            this.Script_source_text.Location = new System.Drawing.Point(374, 232);
            this.Script_source_text.Name = "Script_source_text";
            this.Script_source_text.Size = new System.Drawing.Size(152, 21);
            this.Script_source_text.TabIndex = 9;
            // 
            // Script_source
            // 
            this.Script_source.Location = new System.Drawing.Point(556, 232);
            this.Script_source.Name = "Script_source";
            this.Script_source.Size = new System.Drawing.Size(143, 23);
            this.Script_source.TabIndex = 11;
            this.Script_source.Text = "Script Source";
            this.Script_source.UseVisualStyleBackColor = true;
            this.Script_source.Click += new System.EventHandler(this.Script_source_button_click);
            // 
            // Script_generate_button
            // 
            this.Script_generate_button.Location = new System.Drawing.Point(292, 286);
            this.Script_generate_button.Name = "Script_generate_button";
            this.Script_generate_button.Size = new System.Drawing.Size(115, 23);
            this.Script_generate_button.TabIndex = 13;
            this.Script_generate_button.Text = "Generate Scripts";
            this.Script_generate_button.UseVisualStyleBackColor = true;
            this.Script_generate_button.Click += new System.EventHandler(this.Script_generate_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 165);
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
            this.Script_Lable.Location = new System.Drawing.Point(265, 182);
            this.Script_Lable.Name = "Script_Lable";
            this.Script_Lable.Size = new System.Drawing.Size(200, 16);
            this.Script_Lable.TabIndex = 16;
            this.Script_Lable.Text = "Update Script Generation";
            this.Script_Lable.Click += new System.EventHandler(this.label2_Click);
            // 
            // Test_con
            // 
            this.Test_con.Location = new System.Drawing.Point(268, 134);
            this.Test_con.Name = "Test_con";
            this.Test_con.Size = new System.Drawing.Size(152, 23);
            this.Test_con.TabIndex = 17;
            this.Test_con.Text = "Transfer";
            this.Test_con.UseVisualStyleBackColor = true;
            this.Test_con.Click += new System.EventHandler(this.Test_Click);
            // 
            // Main_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 316);
            this.Controls.Add(this.Test_con);
            this.Controls.Add(this.Script_Lable);
            this.Controls.Add(this.Replacement_Lable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Script_generate_button);
            this.Controls.Add(this.Script_source);
            this.Controls.Add(this.Script_save_destination);
            this.Controls.Add(this.Script_source_text);
            this.Controls.Add(this.Script_destination_text);
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
        private System.Windows.Forms.TextBox Script_destination_text;
        private System.Windows.Forms.Button Script_save_destination;
        private System.Windows.Forms.TextBox Script_source_text;
        private System.Windows.Forms.Button Script_source;
        private System.Windows.Forms.Button Script_generate_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Replacement_Lable;
        private System.Windows.Forms.Label Script_Lable;
        private System.Windows.Forms.Button Test_con;
    }
}

