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
            this.Errormessage = new System.Windows.Forms.Label();
            this.Contains_btn = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(14, 16);
            this.listview.Margin = new System.Windows.Forms.Padding(2);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(1027, 209);
            this.listview.TabIndex = 0;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(14, 278);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(340, 237);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(14, 254);
            this.input_txt.Margin = new System.Windows.Forms.Padding(2);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(1027, 20);
            this.input_txt.TabIndex = 2;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(357, 278);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(340, 237);
            this.remove_btn.TabIndex = 3;
            this.remove_btn.Text = "REMOVE";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Errormessage
            // 
            this.Errormessage.AutoSize = true;
            this.Errormessage.Location = new System.Drawing.Point(53, 236);
            this.Errormessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Errormessage.Name = "Errormessage";
            this.Errormessage.Size = new System.Drawing.Size(0, 13);
            this.Errormessage.TabIndex = 5;
            // 
            // Contains_btn
            // 
            this.Contains_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contains_btn.Location = new System.Drawing.Point(701, 278);
            this.Contains_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Contains_btn.Name = "Contains_btn";
            this.Contains_btn.Size = new System.Drawing.Size(340, 237);
            this.Contains_btn.TabIndex = 6;
            this.Contains_btn.Text = "CONTAINS";
            this.Contains_btn.UseVisualStyleBackColor = true;
            this.Contains_btn.Click += new System.EventHandler(this.Contains_btn_Click);
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(14, 236);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(34, 13);
            this.Input.TabIndex = 7;
            this.Input.Text = "Input:";
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 526);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Contains_btn);
            this.Controls.Add(this.Errormessage);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.listview);
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
        private System.Windows.Forms.Label Errormessage;
        private System.Windows.Forms.Button Contains_btn;
        private System.Windows.Forms.Label Input;
    }
}

