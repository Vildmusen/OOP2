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
            this.reject_chk = new System.Windows.Forms.CheckBox();
            this.Errormessage = new System.Windows.Forms.Label();
            this.Contains_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(21, 25);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(170, 358);
            this.listview.TabIndex = 0;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(195, 79);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(96, 35);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(195, 39);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(206, 26);
            this.input_txt.TabIndex = 2;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(195, 127);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(96, 35);
            this.remove_btn.TabIndex = 3;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // reject_chk
            // 
            this.reject_chk.AutoSize = true;
            this.reject_chk.Location = new System.Drawing.Point(195, 182);
            this.reject_chk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reject_chk.Name = "reject_chk";
            this.reject_chk.Size = new System.Drawing.Size(149, 24);
            this.reject_chk.TabIndex = 4;
            this.reject_chk.Text = "Reject Changes";
            this.reject_chk.UseVisualStyleBackColor = true;
            this.reject_chk.CheckedChanged += new System.EventHandler(this.reject_chk_CheckedChanged);
            // 
            // Errormessage
            // 
            this.Errormessage.AutoSize = true;
            this.Errormessage.Location = new System.Drawing.Point(230, 228);
            this.Errormessage.Name = "Errormessage";
            this.Errormessage.Size = new System.Drawing.Size(0, 20);
            this.Errormessage.TabIndex = 5;
            // 
            // Contains_btn
            // 
            this.Contains_btn.Location = new System.Drawing.Point(316, 133);
            this.Contains_btn.Name = "Contains_btn";
            this.Contains_btn.Size = new System.Drawing.Size(85, 29);
            this.Contains_btn.TabIndex = 6;
            this.Contains_btn.Text = "Contains";
            this.Contains_btn.UseVisualStyleBackColor = true;
            this.Contains_btn.Click += new System.EventHandler(this.Contains_btn_Click);
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.Contains_btn);
            this.Controls.Add(this.Errormessage);
            this.Controls.Add(this.reject_chk);
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
        private System.Windows.Forms.CheckBox reject_chk;
        private System.Windows.Forms.Label Errormessage;
        private System.Windows.Forms.Button Contains_btn;
    }
}

