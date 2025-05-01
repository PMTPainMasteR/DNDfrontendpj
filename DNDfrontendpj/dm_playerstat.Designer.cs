namespace DNDfrontendpj
{
    partial class dm_playerstat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dm_playerstat));
            viewinvenBT = new Button();
            searchcharBT = new Button();
            charstat_DGV = new DataGridView();
            label1 = new Label();
            addnewcharBT = new Button();
            button2 = new Button();
            editcampaignBT = new Button();
            EditcharacterBT = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            campname_TXT = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)charstat_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // viewinvenBT
            // 
            viewinvenBT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewinvenBT.BackColor = Color.FromArgb(148, 201, 176);
            viewinvenBT.FlatAppearance.BorderSize = 0;
            viewinvenBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 220, 143);
            viewinvenBT.FlatStyle = FlatStyle.Flat;
            viewinvenBT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewinvenBT.ForeColor = Color.FromArgb(91, 120, 105);
            viewinvenBT.Image = (Image)resources.GetObject("viewinvenBT.Image");
            viewinvenBT.ImageAlign = ContentAlignment.MiddleLeft;
            viewinvenBT.Location = new Point(176, 553);
            viewinvenBT.Name = "viewinvenBT";
            viewinvenBT.Size = new Size(245, 35);
            viewinvenBT.TabIndex = 9;
            viewinvenBT.Text = "View Inventory";
            viewinvenBT.TextAlign = ContentAlignment.MiddleRight;
            viewinvenBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewinvenBT.UseVisualStyleBackColor = false;
            viewinvenBT.Click += viewinvenBT_Click;
            // 
            // searchcharBT
            // 
            searchcharBT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchcharBT.BackColor = Color.FromArgb(148, 201, 176);
            searchcharBT.FlatAppearance.BorderColor = Color.Silver;
            searchcharBT.FlatAppearance.BorderSize = 0;
            searchcharBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            searchcharBT.FlatStyle = FlatStyle.Flat;
            searchcharBT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchcharBT.ForeColor = Color.FromArgb(91, 120, 105);
            searchcharBT.Image = (Image)resources.GetObject("searchcharBT.Image");
            searchcharBT.ImageAlign = ContentAlignment.MiddleLeft;
            searchcharBT.Location = new Point(176, 594);
            searchcharBT.Name = "searchcharBT";
            searchcharBT.Size = new Size(245, 35);
            searchcharBT.TabIndex = 8;
            searchcharBT.Text = "Search Character";
            searchcharBT.TextAlign = ContentAlignment.MiddleRight;
            searchcharBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchcharBT.UseVisualStyleBackColor = false;
            searchcharBT.Click += searchcharBT_Click;
            // 
            // charstat_DGV
            // 
            charstat_DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            charstat_DGV.BackgroundColor = Color.FromArgb(247, 220, 143);
            charstat_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            charstat_DGV.GridColor = Color.FromArgb(91, 120, 105);
            charstat_DGV.Location = new Point(61, 167);
            charstat_DGV.Name = "charstat_DGV";
            charstat_DGV.RowHeadersWidth = 51;
            charstat_DGV.Size = new Size(1141, 375);
            charstat_DGV.TabIndex = 7;
            charstat_DGV.CellClick += charstat_DGV_CellClick;
            charstat_DGV.CellContentClick += charstat_DGV_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(372, 76);
            label1.Name = "label1";
            label1.Size = new Size(554, 73);
            label1.TabIndex = 6;
            label1.Text = "Character Stats";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // addnewcharBT
            // 
            addnewcharBT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addnewcharBT.BackColor = Color.FromArgb(148, 201, 176);
            addnewcharBT.FlatAppearance.BorderColor = Color.Silver;
            addnewcharBT.FlatAppearance.BorderSize = 0;
            addnewcharBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            addnewcharBT.FlatStyle = FlatStyle.Flat;
            addnewcharBT.Font = new Font("Verdana", 9.8F, FontStyle.Bold);
            addnewcharBT.ForeColor = Color.FromArgb(91, 120, 105);
            addnewcharBT.Image = (Image)resources.GetObject("addnewcharBT.Image");
            addnewcharBT.ImageAlign = ContentAlignment.MiddleLeft;
            addnewcharBT.Location = new Point(592, 565);
            addnewcharBT.Name = "addnewcharBT";
            addnewcharBT.Size = new Size(245, 35);
            addnewcharBT.TabIndex = 10;
            addnewcharBT.Text = "Add New Character";
            addnewcharBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            addnewcharBT.UseVisualStyleBackColor = false;
            addnewcharBT.Click += addnewcharBT_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(148, 201, 176);
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(91, 120, 105);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(909, 626);
            button2.Name = "button2";
            button2.Size = new Size(245, 35);
            button2.TabIndex = 11;
            button2.Text = "Delete Character";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // editcampaignBT
            // 
            editcampaignBT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editcampaignBT.BackColor = Color.FromArgb(148, 201, 176);
            editcampaignBT.FlatAppearance.BorderColor = Color.Silver;
            editcampaignBT.FlatAppearance.BorderSize = 0;
            editcampaignBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            editcampaignBT.FlatStyle = FlatStyle.Flat;
            editcampaignBT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editcampaignBT.ForeColor = Color.FromArgb(91, 120, 105);
            editcampaignBT.Image = (Image)resources.GetObject("editcampaignBT.Image");
            editcampaignBT.ImageAlign = ContentAlignment.MiddleLeft;
            editcampaignBT.Location = new Point(592, 626);
            editcampaignBT.Name = "editcampaignBT";
            editcampaignBT.Size = new Size(245, 35);
            editcampaignBT.TabIndex = 12;
            editcampaignBT.Text = "Edit Campaign";
            editcampaignBT.TextAlign = ContentAlignment.MiddleRight;
            editcampaignBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            editcampaignBT.UseVisualStyleBackColor = false;
            editcampaignBT.Click += editcampaignBT_Click;
            // 
            // EditcharacterBT
            // 
            EditcharacterBT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditcharacterBT.BackColor = Color.FromArgb(148, 201, 176);
            EditcharacterBT.FlatAppearance.BorderColor = Color.Silver;
            EditcharacterBT.FlatAppearance.BorderSize = 0;
            EditcharacterBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            EditcharacterBT.FlatStyle = FlatStyle.Flat;
            EditcharacterBT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditcharacterBT.ForeColor = Color.FromArgb(91, 120, 105);
            EditcharacterBT.Image = (Image)resources.GetObject("EditcharacterBT.Image");
            EditcharacterBT.ImageAlign = ContentAlignment.MiddleLeft;
            EditcharacterBT.Location = new Point(909, 565);
            EditcharacterBT.Name = "EditcharacterBT";
            EditcharacterBT.Size = new Size(245, 35);
            EditcharacterBT.TabIndex = 13;
            EditcharacterBT.Text = "Edit Character";
            EditcharacterBT.TextAlign = ContentAlignment.MiddleRight;
            EditcharacterBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditcharacterBT.UseVisualStyleBackColor = false;
            EditcharacterBT.Click += EditcharacterBT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 204, 92);
            label2.Location = new Point(140, 28);
            label2.Name = "label2";
            label2.Size = new Size(244, 22);
            label2.TabIndex = 16;
            label2.Text = "Return to All Campaign";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(57, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 39);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // campname_TXT
            // 
            campname_TXT.AutoSize = true;
            campname_TXT.BackColor = Color.Transparent;
            campname_TXT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campname_TXT.ForeColor = Color.FromArgb(91, 120, 105);
            campname_TXT.Location = new Point(761, 28);
            campname_TXT.Name = "campname_TXT";
            campname_TXT.Size = new Size(188, 22);
            campname_TXT.TabIndex = 14;
            campname_TXT.Text = "Campaign Name: ";
            campname_TXT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(91, 120, 105);
            label3.Location = new Point(955, 28);
            label3.Name = "label3";
            label3.Size = new Size(188, 22);
            label3.TabIndex = 17;
            label3.Text = "Campaign Name: ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 561);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label5.Location = new Point(160, 547);
            label5.Name = "label5";
            label5.Size = new Size(270, 41);
            label5.TabIndex = 19;
            label5.Text = "                     ";
            // 
            // dm_playerstat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 235, 171);
            ClientSize = new Size(1262, 673);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(campname_TXT);
            Controls.Add(EditcharacterBT);
            Controls.Add(editcampaignBT);
            Controls.Add(button2);
            Controls.Add(addnewcharBT);
            Controls.Add(viewinvenBT);
            Controls.Add(searchcharBT);
            Controls.Add(charstat_DGV);
            Controls.Add(label1);
            Name = "dm_playerstat";
            Text = "Character Status (DM View)";
            Load += dm_playerstat_Load;
            ((System.ComponentModel.ISupportInitialize)charstat_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewinvenBT;
        private Button searchcharBT;
        private DataGridView charstat_DGV;
        private Label label1;
        private Button addnewcharBT;
        private Button button2;
        private Button editcampaignBT;
        private Button EditcharacterBT;
        private Label label2;
        private PictureBox pictureBox1;
        private Label campname_TXT;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}