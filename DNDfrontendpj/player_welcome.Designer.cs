namespace DNDfrontendpj
{
    partial class player_welcome
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
            continuecamBT = new Button();
            createnewcam = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(359, 60);
            label1.Name = "label1";
            label1.Size = new Size(575, 73);
            label1.TabIndex = 7;
            label1.Text = "Welcome Player";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(247, 220, 143);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(410, 418);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(423, 28);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(247, 220, 143);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(410, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 28);
            textBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(91, 120, 105);
            label5.Location = new Point(410, 361);
            label5.Name = "label5";
            label5.Size = new Size(217, 34);
            label5.TabIndex = 10;
            label5.Text = "Character ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 120, 105);
            label4.Location = new Point(410, 222);
            label4.Name = "label4";
            label4.Size = new Size(221, 34);
            label4.TabIndex = 9;
            label4.Text = "Campaign ID";
            // 
            // continuecamBT
            // 
            continuecamBT.BackColor = Color.FromArgb(150, 206, 180);
            continuecamBT.FlatAppearance.BorderSize = 0;
            continuecamBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            continuecamBT.FlatStyle = FlatStyle.Flat;
            continuecamBT.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continuecamBT.ForeColor = Color.FromArgb(91, 120, 105);
            continuecamBT.Location = new Point(448, 519);
            continuecamBT.Name = "continuecamBT";
            continuecamBT.Size = new Size(325, 64);
            continuecamBT.TabIndex = 13;
            continuecamBT.Text = "Continue Campaign";
            continuecamBT.UseVisualStyleBackColor = false;
            continuecamBT.Click += continuecamBT_Click;
            // 
            // createnewcam
            // 
            createnewcam.AutoSize = true;
            createnewcam.BorderStyle = BorderStyle.FixedSingle;
            createnewcam.FlatStyle = FlatStyle.Popup;
            createnewcam.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createnewcam.ForeColor = Color.FromArgb(150, 206, 180);
            createnewcam.Location = new Point(472, 612);
            createnewcam.Name = "createnewcam";
            createnewcam.Size = new Size(279, 27);
            createnewcam.TabIndex = 17;
            createnewcam.Text = "+ Create a New Character";
            createnewcam.Click += createnewcam_Click;
            // 
            // player_welcome
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 238, 173);
            ClientSize = new Size(1262, 673);
            Controls.Add(createnewcam);
            Controls.Add(continuecamBT);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "player_welcome";
            Text = "Welcome Player";
            Load += player_welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Button continuecamBT;
        private Label createnewcam;
    }
}