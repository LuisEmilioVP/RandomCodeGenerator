namespace RandomGenerator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            panel2 = new Panel();
            btnCancel = new Button();
            btnInicio = new Button();
            panel3 = new Panel();
            btnGenerator = new Button();
            lblClave = new Label();
            label4 = new Label();
            txtClave = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUsuer = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 400);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnGenerator);
            panel2.Controls.Add(lblClave);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUsuer);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 362);
            panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleDescription = "Cancelar un código generado";
            btnCancel.AutoEllipsis = true;
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(291, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(211, 36);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoEllipsis = true;
            btnInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(74, 286);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(211, 36);
            btnInicio.TabIndex = 9;
            btnInicio.Text = "Registrar código";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(17, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 10);
            panel3.TabIndex = 8;
            // 
            // btnGenerator
            // 
            btnGenerator.AutoEllipsis = true;
            btnGenerator.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerator.Location = new Point(84, 121);
            btnGenerator.Name = "btnGenerator";
            btnGenerator.Size = new Size(211, 36);
            btnGenerator.TabIndex = 7;
            btnGenerator.Text = "Generar código de tarjeta";
            btnGenerator.UseVisualStyleBackColor = true;
            btnGenerator.Click += btnGenerator_Click;
            // 
            // lblClave
            // 
            lblClave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblClave.AutoEllipsis = true;
            lblClave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblClave.ForeColor = SystemColors.ActiveCaption;
            lblClave.Location = new Point(314, 123);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(205, 34);
            lblClave.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(65, 236);
            label4.Name = "label4";
            label4.Size = new Size(220, 25);
            label4.TabIndex = 5;
            label4.Text = "Ingresa código asignado";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtClave.Location = new Point(291, 236);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(228, 29);
            txtClave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(80, 193);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 3;
            label3.Text = "Ingrese un Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(145, 68);
            label2.Name = "label2";
            label2.Size = new Size(341, 30);
            label2.TabIndex = 2;
            label2.Text = "Sistema de generación de Código ";
            // 
            // txtUsuer
            // 
            txtUsuer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuer.Location = new Point(291, 189);
            txtUsuer.Name = "txtUsuer";
            txtUsuer.Size = new Size(228, 29);
            txtUsuer.TabIndex = 1;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(260, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 47);
            label1.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 386);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Home";
            Text = "Generador de Código de Tarjeta";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label lblClave;
        private Label label4;
        private Label label3;
        private Button btnGenerator;
        private Button btnInicio;
        private Panel panel3;
        public TextBox txtUsuer;
        public TextBox txtClave;
        private Button btnCancel;
    }
}