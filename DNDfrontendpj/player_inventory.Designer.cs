namespace DNDfrontendpj
{
    partial class player_inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player_inventory));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            viewcharstatBT = new Button();
            searchcharBT = new Button();
            charstat_DGV = new DataGridView();
            label1 = new Label();
            campname_TXT = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charstat_DGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 204, 92);
            label2.Location = new Point(126, 33);
            label2.Name = "label2";
            label2.Size = new Size(279, 22);
            label2.TabIndex = 13;
            label2.Text = "Return to Welcome Player ";
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
            pictureBox1.Location = new Point(43, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 39);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // viewcharstatBT
            // 
            viewcharstatBT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewcharstatBT.BackColor = Color.FromArgb(148, 201, 176);
            viewcharstatBT.FlatAppearance.BorderSize = 0;
            viewcharstatBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 220, 143);
            viewcharstatBT.FlatStyle = FlatStyle.Flat;
            viewcharstatBT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewcharstatBT.ForeColor = Color.FromArgb(91, 120, 105);
            viewcharstatBT.Image = (Image)resources.GetObject("viewcharstatBT.Image");
            viewcharstatBT.ImageAlign = ContentAlignment.MiddleLeft;
            viewcharstatBT.Location = new Point(852, 601);
            viewcharstatBT.Name = "viewcharstatBT";
            viewcharstatBT.Size = new Size(254, 47);
            viewcharstatBT.TabIndex = 11;
            viewcharstatBT.Text = "View Character Stats";
            viewcharstatBT.TextAlign = ContentAlignment.MiddleRight;
            viewcharstatBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewcharstatBT.UseVisualStyleBackColor = false;
            viewcharstatBT.Click += viewcharstatBT_Click;
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
            searchcharBT.Location = new Point(240, 601);
            searchcharBT.Name = "searchcharBT";
            searchcharBT.Size = new Size(212, 47);
            searchcharBT.TabIndex = 10;
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
            charstat_DGV.Location = new Point(79, 181);
            charstat_DGV.Name = "charstat_DGV";
            charstat_DGV.RowHeadersWidth = 51;
            charstat_DGV.Size = new Size(1141, 398);
            charstat_DGV.TabIndex = 9;
            charstat_DGV.CellClick += charstat_DGV_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(302, 91);
            label1.Name = "label1";
            label1.Size = new Size(716, 73);
            label1.TabIndex = 8;
            label1.Text = "Character Inventory";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // campname_TXT
            // 
            campname_TXT.AutoSize = true;
            campname_TXT.BackColor = Color.Transparent;
            campname_TXT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campname_TXT.ForeColor = Color.FromArgb(91, 120, 105);
            campname_TXT.Location = new Point(747, 33);
            campname_TXT.Name = "campname_TXT";
            campname_TXT.Size = new Size(188, 22);
            campname_TXT.TabIndex = 7;
            campname_TXT.Text = "Campaign Name: ";
            campname_TXT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // player_inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 238, 173);
            ClientSize = new Size(1262, 673);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(viewcharstatBT);
            Controls.Add(searchcharBT);
            Controls.Add(charstat_DGV);
            Controls.Add(label1);
            Controls.Add(campname_TXT);
            Name = "player_inventory";
            Text = "Character Inventory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)charstat_DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button viewcharstatBT;
        private Button searchcharBT;
        private DataGridView charstat_DGV;
        private Label label1;
        private Label campname_TXT;
    }
}