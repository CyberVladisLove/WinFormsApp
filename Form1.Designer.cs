
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_read_start = new System.Windows.Forms.Button();
            this.button_read_end = new System.Windows.Forms.Button();
            this.button_clear_file = new System.Windows.Forms.Button();
            this.button_add_to_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(164, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 189);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(164, 230);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(314, 48);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button_read_start
            // 
            this.button_read_start.Location = new System.Drawing.Point(29, 24);
            this.button_read_start.Name = "button_read_start";
            this.button_read_start.Size = new System.Drawing.Size(112, 23);
            this.button_read_start.TabIndex = 2;
            this.button_read_start.Text = "Читать с начала";
            this.button_read_start.UseVisualStyleBackColor = true;
            this.button_read_start.Click += new System.EventHandler(this.button_read_start_Click);
            // 
            // button_read_end
            // 
            this.button_read_end.Location = new System.Drawing.Point(29, 63);
            this.button_read_end.Name = "button_read_end";
            this.button_read_end.Size = new System.Drawing.Size(112, 23);
            this.button_read_end.TabIndex = 3;
            this.button_read_end.Text = "Читать с конца";
            this.button_read_end.UseVisualStyleBackColor = true;
            this.button_read_end.Click += new System.EventHandler(this.button_read_end_Click);
            // 
            // button_clear_file
            // 
            this.button_clear_file.Location = new System.Drawing.Point(29, 101);
            this.button_clear_file.Name = "button_clear_file";
            this.button_clear_file.Size = new System.Drawing.Size(112, 23);
            this.button_clear_file.TabIndex = 4;
            this.button_clear_file.Text = "Очистить файл";
            this.button_clear_file.UseVisualStyleBackColor = true;
            this.button_clear_file.Click += new System.EventHandler(this.button_clear_file_Click);
            // 
            // button_add_to_file
            // 
            this.button_add_to_file.Location = new System.Drawing.Point(29, 242);
            this.button_add_to_file.Name = "button_add_to_file";
            this.button_add_to_file.Size = new System.Drawing.Size(112, 23);
            this.button_add_to_file.TabIndex = 5;
            this.button_add_to_file.Text = "Добавить в файл";
            this.button_add_to_file.UseVisualStyleBackColor = true;
            this.button_add_to_file.Click += new System.EventHandler(this.button_add_to_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 301);
            this.Controls.Add(this.button_add_to_file);
            this.Controls.Add(this.button_clear_file);
            this.Controls.Add(this.button_read_end);
            this.Controls.Add(this.button_read_start);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_read_start;
        private System.Windows.Forms.Button button_read_end;
        private System.Windows.Forms.Button button_clear_file;
        private System.Windows.Forms.Button button_add_to_file;
    }
}

