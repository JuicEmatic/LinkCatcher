
namespace LinkCatcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.ActualURLLabel = new System.Windows.Forms.Label();
            this.OpenURLButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URLTextbox
            // 
            this.URLTextbox.AllowDrop = true;
            this.URLTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextbox.Location = new System.Drawing.Point(18, 66);
            this.URLTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.URLTextbox.Multiline = true;
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(462, 275);
            this.URLTextbox.TabIndex = 0;
            this.URLTextbox.TextChanged += new System.EventHandler(this.URLTextbox_TextChanged);
            // 
            // ActualURLLabel
            // 
            this.ActualURLLabel.AutoSize = true;
            this.ActualURLLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualURLLabel.Location = new System.Drawing.Point(18, 32);
            this.ActualURLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActualURLLabel.Name = "ActualURLLabel";
            this.ActualURLLabel.Size = new System.Drawing.Size(129, 29);
            this.ActualURLLabel.TabIndex = 1;
            this.ActualURLLabel.Text = "Actual URL:";
            // 
            // OpenURLButton
            // 
            this.OpenURLButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenURLButton.ForeColor = System.Drawing.Color.Red;
            this.OpenURLButton.Location = new System.Drawing.Point(18, 431);
            this.OpenURLButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenURLButton.Name = "OpenURLButton";
            this.OpenURLButton.Size = new System.Drawing.Size(130, 58);
            this.OpenURLButton.TabIndex = 2;
            this.OpenURLButton.Text = "Open URL (Dangerous)";
            this.OpenURLButton.UseVisualStyleBackColor = true;
            this.OpenURLButton.Click += new System.EventHandler(this.OpenURLButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Green;
            this.CloseButton.Location = new System.Drawing.Point(316, 369);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(165, 120);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 537);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenURLButton);
            this.Controls.Add(this.ActualURLLabel);
            this.Controls.Add(this.URLTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 593);
            this.MinimumSize = new System.Drawing.Size(550, 593);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkCatcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.Label ActualURLLabel;
        private System.Windows.Forms.Button OpenURLButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

