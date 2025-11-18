namespace Scaled
{
    partial class Scaled
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
            this.scale_btn = new System.Windows.Forms.Button();
            this.window_list = new System.Windows.Forms.CheckedListBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scale_btn
            // 
            this.scale_btn.BackColor = System.Drawing.Color.DimGray;
            this.scale_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scale_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scale_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.scale_btn.Location = new System.Drawing.Point(12, 388);
            this.scale_btn.Name = "scale_btn";
            this.scale_btn.Size = new System.Drawing.Size(775, 50);
            this.scale_btn.TabIndex = 1;
            this.scale_btn.Text = "Scale";
            this.scale_btn.UseVisualStyleBackColor = false;
            this.scale_btn.Click += new System.EventHandler(this.scale_btn_Click);
            // 
            // window_list
            // 
            this.window_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window_list.FormattingEnabled = true;
            this.window_list.Location = new System.Drawing.Point(13, 43);
            this.window_list.Name = "window_list";
            this.window_list.Size = new System.Drawing.Size(774, 332);
            this.window_list.TabIndex = 2;
            this.window_list.SelectedIndexChanged += new System.EventHandler(this.window_list_SelectedIndexChanged);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(12, 12);
            this.search_box.MaxLength = 100;
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(304, 20);
            this.search_box.TabIndex = 3;
            this.search_box.Text = "Search...";
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(322, 12);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(385, 20);
            this.progress_bar.TabIndex = 4;
            this.progress_bar.Click += new System.EventHandler(this.progress_bar_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh_button.Location = new System.Drawing.Point(713, 12);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(74, 20);
            this.refresh_button.TabIndex = 5;
            this.refresh_button.Text = "refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Scaled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.window_list);
            this.Controls.Add(this.scale_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Scaled";
            this.ShowIcon = false;
            this.Text = "Scaled";
            this.Load += new System.EventHandler(this.Scaled_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scale_btn;
        private System.Windows.Forms.CheckedListBox window_list;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Button refresh_button;
    }
}

