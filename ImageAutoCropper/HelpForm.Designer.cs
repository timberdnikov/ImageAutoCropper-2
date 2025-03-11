
namespace ImageAutoCropper
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Logo1PictureBox = new System.Windows.Forms.PictureBox();
            this.Logo2PictureBox = new System.Windows.Forms.PictureBox();
            this.LogoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2PictureBox)).BeginInit();
            this.LogoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(526, 481);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(176, 42);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(686, 398);
            this.textBox1.TabIndex = 1;
            // 
            // Logo1PictureBox
            // 
            this.Logo1PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo1PictureBox.Image = global::ImageAutoCropper.Properties.Resources.Logo1;
            this.Logo1PictureBox.Location = new System.Drawing.Point(148, 3);
            this.Logo1PictureBox.Name = "Logo1PictureBox";
            this.Logo1PictureBox.Size = new System.Drawing.Size(187, 55);
            this.Logo1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo1PictureBox.TabIndex = 50;
            this.Logo1PictureBox.TabStop = false;
            // 
            // Logo2PictureBox
            // 
            this.Logo2PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo2PictureBox.Image = global::ImageAutoCropper.Properties.Resources.Logo2;
            this.Logo2PictureBox.Location = new System.Drawing.Point(351, 3);
            this.Logo2PictureBox.Name = "Logo2PictureBox";
            this.Logo2PictureBox.Size = new System.Drawing.Size(187, 55);
            this.Logo2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo2PictureBox.TabIndex = 51;
            this.Logo2PictureBox.TabStop = false;
            // 
            // LogoTableLayoutPanel
            // 
            this.LogoTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoTableLayoutPanel.ColumnCount = 5;
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LogoTableLayoutPanel.Controls.Add(this.Logo2PictureBox, 3, 0);
            this.LogoTableLayoutPanel.Controls.Add(this.Logo1PictureBox, 1, 0);
            this.LogoTableLayoutPanel.Location = new System.Drawing.Point(15, 10);
            this.LogoTableLayoutPanel.Name = "LogoTableLayoutPanel";
            this.LogoTableLayoutPanel.RowCount = 1;
            this.LogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LogoTableLayoutPanel.Size = new System.Drawing.Size(686, 61);
            this.LogoTableLayoutPanel.TabIndex = 52;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 535);
            this.ControlBox = false;
            this.Controls.Add(this.LogoTableLayoutPanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(431, 263);
            this.Name = "HelpForm";
            this.Text = "Помощь";
            ((System.ComponentModel.ISupportInitialize)(this.Logo1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2PictureBox)).EndInit();
            this.LogoTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Logo1PictureBox;
        private System.Windows.Forms.PictureBox Logo2PictureBox;
        private System.Windows.Forms.TableLayoutPanel LogoTableLayoutPanel;
    }
}