namespace DNDfrontendpj
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            Signup_con = new TextBox();
            Signup_pass = new TextBox();
            Signup_username = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            Player_chkbox = new CheckBox();
            label7 = new Label();
            DM_chkbox = new CheckBox();
            label3 = new Label();
            ret2loginBT = new Button();
            return2loginBT = new PictureBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)return2loginBT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(461, 49);
            label1.Name = "label1";
            label1.Size = new Size(387, 97);
            label1.TabIndex = 2;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(Signup_con);
            groupBox1.Controls.Add(Signup_pass);
            groupBox1.Controls.Add(Signup_username);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(247, 220, 143);
            groupBox1.Location = new Point(79, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 467);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(91, 120, 105);
            label8.Location = new Point(23, 39);
            label8.Name = "label8";
            label8.Size = new Size(297, 48);
            label8.TabIndex = 10;
            label8.Text = "General info";
            // 
            // Signup_con
            // 
            Signup_con.BackColor = Color.FromArgb(247, 220, 143);
            Signup_con.BorderStyle = BorderStyle.None;
            Signup_con.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signup_con.Location = new Point(23, 395);
            Signup_con.Name = "Signup_con";
            Signup_con.PasswordChar = '*';
            Signup_con.Size = new Size(423, 28);
            Signup_con.TabIndex = 8;
            Signup_con.TextChanged += textBox3_TextChanged;
            // 
            // Signup_pass
            // 
            Signup_pass.BackColor = Color.FromArgb(247, 220, 143);
            Signup_pass.BorderStyle = BorderStyle.None;
            Signup_pass.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signup_pass.Location = new Point(23, 279);
            Signup_pass.Name = "Signup_pass";
            Signup_pass.PasswordChar = '*';
            Signup_pass.Size = new Size(423, 28);
            Signup_pass.TabIndex = 7;
            // 
            // Signup_username
            // 
            Signup_username.BackColor = Color.FromArgb(247, 220, 143);
            Signup_username.BorderStyle = BorderStyle.None;
            Signup_username.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signup_username.Location = new Point(23, 177);
            Signup_username.Name = "Signup_username";
            Signup_username.Size = new Size(423, 28);
            Signup_username.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(91, 120, 105);
            label6.Location = new Point(23, 332);
            label6.Name = "label6";
            label6.Size = new Size(304, 34);
            label6.TabIndex = 5;
            label6.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(91, 120, 105);
            label5.Location = new Point(23, 222);
            label5.Name = "label5";
            label5.Size = new Size(169, 34);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 120, 105);
            label4.Location = new Point(23, 121);
            label4.Name = "label4";
            label4.Size = new Size(176, 34);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Player_chkbox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(DM_chkbox);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(150, 206, 180);
            groupBox2.Location = new Point(665, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 256);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // Player_chkbox
            // 
            Player_chkbox.AutoSize = true;
            Player_chkbox.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Player_chkbox.ForeColor = Color.FromArgb(91, 120, 105);
            Player_chkbox.Location = new Point(46, 177);
            Player_chkbox.Name = "Player_chkbox";
            Player_chkbox.Size = new Size(357, 38);
            Player_chkbox.TabIndex = 7;
            Player_chkbox.Text = "Adventurer (Player)";
            Player_chkbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(91, 120, 105);
            label7.Location = new Point(46, 39);
            label7.Name = "label7";
            label7.Size = new Size(255, 48);
            label7.TabIndex = 9;
            label7.Text = "Sign up as";
            label7.Click += label7_Click;
            // 
            // DM_chkbox
            // 
            DM_chkbox.AutoSize = true;
            DM_chkbox.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DM_chkbox.ForeColor = Color.FromArgb(91, 120, 105);
            DM_chkbox.Location = new Point(46, 117);
            DM_chkbox.Name = "DM_chkbox";
            DM_chkbox.Size = new Size(406, 38);
            DM_chkbox.TabIndex = 6;
            DM_chkbox.Text = "Duengeon Master (DM)";
            DM_chkbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(91, 120, 105);
            label3.Location = new Point(106, 211);
            label3.Name = "label3";
            label3.Size = new Size(0, 45);
            label3.TabIndex = 2;
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // ret2loginBT
            // 
            ret2loginBT.BackColor = Color.FromArgb(150, 206, 180);
            ret2loginBT.FlatAppearance.BorderSize = 0;
            ret2loginBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            ret2loginBT.FlatStyle = FlatStyle.Flat;
            ret2loginBT.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ret2loginBT.ForeColor = Color.FromArgb(91, 120, 105);
            ret2loginBT.Location = new Point(937, 564);
            ret2loginBT.Name = "ret2loginBT";
            ret2loginBT.Size = new Size(261, 52);
            ret2loginBT.TabIndex = 5;
            ret2loginBT.Text = "Save and Return to login";
            ret2loginBT.UseVisualStyleBackColor = false;
            ret2loginBT.Click += ret2loginBT_Click;
            // 
            // return2loginBT
            // 
            return2loginBT.BackColor = Color.Transparent;
            return2loginBT.BackgroundImage = (Image)resources.GetObject("return2loginBT.BackgroundImage");
            return2loginBT.BackgroundImageLayout = ImageLayout.Zoom;
            return2loginBT.BorderStyle = BorderStyle.FixedSingle;
            return2loginBT.ErrorImage = (Image)resources.GetObject("return2loginBT.ErrorImage");
            return2loginBT.InitialImage = (Image)resources.GetObject("return2loginBT.InitialImage");
            return2loginBT.Location = new Point(29, 23);
            return2loginBT.Name = "return2loginBT";
            return2loginBT.Size = new Size(77, 39);
            return2loginBT.TabIndex = 13;
            return2loginBT.TabStop = false;
            return2loginBT.Click += return2loginBT_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 204, 92);
            label9.Location = new Point(120, 32);
            label9.Name = "label9";
            label9.Size = new Size(166, 22);
            label9.TabIndex = 14;
            label9.Text = "Return to Login";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 235, 171);
            ClientSize = new Size(1262, 673);
            Controls.Add(label9);
            Controls.Add(return2loginBT);
            Controls.Add(ret2loginBT);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Sign Up";
            Load += Signup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)return2loginBT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox Signup_username;
        private TextBox Signup_con;
        private TextBox Signup_pass;
        private Button ret2loginBT;
        private Label label7;
        private Label label8;
        private CheckBox DM_chkbox;
        private CheckBox Player_chkbox;
        private PictureBox return2loginBT;
        private Label label9;
    }
}