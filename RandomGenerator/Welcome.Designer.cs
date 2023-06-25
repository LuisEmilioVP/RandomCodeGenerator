namespace RandomGenerator
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            lblInfo = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblInfo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 489);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(374, 225);
            label3.Name = "label3";
            label3.Size = new Size(67, 61);
            label3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(190, 286);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 2;
            label2.Text = "En hora buena, todo listo!";
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInfo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.ActiveCaption;
            lblInfo.Location = new Point(34, 340);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(575, 100);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "En hora buena, todo listo!";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(232, 246);
            label1.TabIndex = 0;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 485);
            Controls.Add(panel1);
            Name = "Welcome";
            Text = "Welcome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblInfo;
        private Label label2;
        private Label label3;
    }
}