
namespace projetEvents
{
    partial class formEvenements
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
            this.userControlMenu1 = new uControlMenu.userControlMenu();
            this.SuspendLayout();
            // 
            // userControlMenu1
            // 
            this.userControlMenu1.BarrePanel = 2;
            this.userControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.userControlMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlMenu1.Name = "userControlMenu1";
            this.userControlMenu1.Size = new System.Drawing.Size(207, 753);
            this.userControlMenu1.TabIndex = 0;
            // 
            // formEvenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.userControlMenu1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formEvenements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formEvenements";
            this.Load += new System.EventHandler(this.formEvenements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uControlMenu.userControlMenu userControlMenu1;
    }
}