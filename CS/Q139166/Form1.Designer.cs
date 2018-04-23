namespace Q139166 {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mySimpleButton1 = new DXSample.MySimpleButton();
            this.SuspendLayout();
            // 
            // mySimpleButton1
            // 
            this.mySimpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("mySimpleButton1.Image")));
            this.mySimpleButton1.Location = new System.Drawing.Point(93, 90);
            this.mySimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.mySimpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mySimpleButton1.Name = "mySimpleButton1";
            this.mySimpleButton1.Size = new System.Drawing.Size(98, 38);
            this.mySimpleButton1.TabIndex = 1;
            this.mySimpleButton1.Text = "mySimpleButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.mySimpleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MySimpleButton mySimpleButton1;
    }
}

