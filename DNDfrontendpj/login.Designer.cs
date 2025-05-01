namespace DNDfrontendpj
{
    partial class login
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
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            nextbt = new Button();
            label6 = new Label();
            Version_lb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(508, 41);
            label1.Name = "label1";
            label1.Size = new Size(288, 97);
            label1.TabIndex = 3;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(247, 220, 143);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(424, 398);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(423, 28);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(247, 220, 143);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(425, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 28);
            textBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(91, 120, 105);
            label5.Location = new Point(424, 341);
            label5.Name = "label5";
            label5.Size = new Size(169, 34);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 120, 105);
            label4.Location = new Point(425, 220);
            label4.Name = "label4";
            label4.Size = new Size(176, 34);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(91, 120, 105);
            label3.Location = new Point(422, 462);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 13;
            label3.Text = "No account?";
            // 
            // nextbt
            // 
            nextbt.BackColor = Color.FromArgb(150, 206, 180);
            nextbt.FlatAppearance.BorderSize = 0;
            nextbt.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            nextbt.FlatStyle = FlatStyle.Flat;
            nextbt.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextbt.ForeColor = Color.FromArgb(91, 120, 105);
            nextbt.Location = new Point(508, 584);
            nextbt.Name = "nextbt";
            nextbt.Size = new Size(261, 52);
            nextbt.TabIndex = 15;
            nextbt.Text = "Next";
            nextbt.UseVisualStyleBackColor = false;
            nextbt.Click += nextbt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(150, 206, 180);
            label6.Location = new Point(563, 462);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 16;
            label6.Text = "Sign up here";
            label6.Click += label6_Click;
            // 
            // Version_lb
            // 
            Version_lb.AutoSize = true;
            Version_lb.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Version_lb.ForeColor = Color.FromArgb(186, 177, 47);
            Version_lb.Location = new Point(31, 639);
            Version_lb.Name = "Version_lb";
            Version_lb.Size = new Size(254, 25);
            Version_lb.TabIndex = 17;
            Version_lb.Text = "Version 0.0.1 (DM only)";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 238, 173);
            ClientSize = new Size(1262, 673);
            Controls.Add(Version_lb);
            Controls.Add(label6);
            Controls.Add(nextbt);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "login";
            Text = "Login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button nextbt;
        private Label label6;
        private Label Version_lb;
    }
}