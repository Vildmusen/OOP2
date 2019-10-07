namespace CustomCollectionsTestApp {
    partial class TestApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listview = new System.Windows.Forms.ListView();
            this.add_btn = new System.Windows.Forms.Button();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(13, 40);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(127, 302);
            this.listview.TabIndex = 0;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(227, 40);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(212, 94);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(100, 26);
            this.input_txt.TabIndex = 2;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(227, 153);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 3;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.listview);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestApp";
            this.Text = "Test App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.Button remove_btn;
    }
}

