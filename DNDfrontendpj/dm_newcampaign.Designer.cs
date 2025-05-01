namespace DNDfrontendpj
{
    partial class dm_newcampaign
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
            CampaignName_txtbox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Description_rich = new RichTextBox();
            label1 = new Label();
            Settingh_rich = new RichTextBox();
            button1 = new Button();
            startcampaignBT = new Button();
            SuspendLayout();
            // 
            // CampaignName_txtbox
            // 
            CampaignName_txtbox.BackColor = Color.FromArgb(247, 220, 143);
            CampaignName_txtbox.BorderStyle = BorderStyle.None;
            CampaignName_txtbox.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CampaignName_txtbox.Location = new Point(118, 253);
            CampaignName_txtbox.Name = "CampaignName_txtbox";
            CampaignName_txtbox.Size = new Size(496, 28);
            CampaignName_txtbox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(91, 120, 105);
            label6.Location = new Point(706, 197);
            label6.Name = "label6";
            label6.Size = new Size(294, 28);
            label6.TabIndex = 10;
            label6.Text = "Campaign Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(91, 120, 105);
            label5.Location = new Point(118, 316);
            label5.Name = "label5";
            label5.Size = new Size(205, 28);
            label5.TabIndex = 9;
            label5.Text = "Setting/Theme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 120, 105);
            label4.Location = new Point(118, 197);
            label4.Name = "label4";
            label4.Size = new Size(220, 28);
            label4.TabIndex = 8;
            label4.Text = "Campaign Name";
            // 
            // Description_rich
            // 
            Description_rich.BackColor = Color.FromArgb(247, 220, 143);
            Description_rich.Location = new Point(706, 257);
            Description_rich.Name = "Description_rich";
            Description_rich.Size = new Size(454, 288);
            Description_rich.TabIndex = 13;
            Description_rich.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(238, 66);
            label1.Name = "label1";
            label1.Size = new Size(839, 73);
            label1.TabIndex = 14;
            label1.Text = "Create a New Campaign";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Settingh_rich
            // 
            Settingh_rich.BackColor = Color.FromArgb(247, 220, 143);
            Settingh_rich.Location = new Point(118, 362);
            Settingh_rich.Name = "Settingh_rich";
            Settingh_rich.Size = new Size(496, 183);
            Settingh_rich.TabIndex = 16;
            Settingh_rich.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(150, 206, 180);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(91, 120, 105);
            button1.Location = new Point(706, 595);
            button1.Name = "button1";
            button1.Size = new Size(294, 52);
            button1.TabIndex = 17;
            button1.Text = "Return to All Campaign View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // startcampaignBT
            // 
            startcampaignBT.BackColor = Color.FromArgb(150, 206, 180);
            startcampaignBT.FlatAppearance.BorderSize = 0;
            startcampaignBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            startcampaignBT.FlatStyle = FlatStyle.Flat;
            startcampaignBT.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startcampaignBT.ForeColor = Color.FromArgb(91, 120, 105);
            startcampaignBT.Location = new Point(1033, 595);
            startcampaignBT.Name = "startcampaignBT";
            startcampaignBT.Size = new Size(127, 52);
            startcampaignBT.TabIndex = 18;
            startcampaignBT.Text = "Start the Campaign";
            startcampaignBT.UseVisualStyleBackColor = false;
            startcampaignBT.Click += startcampaignBT_Click;
            // 
            // dm_newcampaign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 238, 173);
            ClientSize = new Size(1262, 673);
            Controls.Add(startcampaignBT);
            Controls.Add(button1);
            Controls.Add(Settingh_rich);
            Controls.Add(label1);
            Controls.Add(Description_rich);
            Controls.Add(CampaignName_txtbox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "dm_newcampaign";
            Text = "Create a New Campaign";
            Load += dm_newcampaign_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox CampaignName_txtbox;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox Description_rich;
        private Label label1;
        private RichTextBox Settingh_rich;
        private Button button1;
        private Button startcampaignBT;
    }
}