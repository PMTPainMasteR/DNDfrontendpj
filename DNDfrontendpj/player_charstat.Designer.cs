namespace DNDfrontendpj
{
    partial class character_stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(character_stat));
            campname_TXT = new Label();
            label1 = new Label();
            charstat_DGV = new DataGridView();
            searchcharBT = new Button();
            viewinvenBT = new Button();
            ret2welcomeplayer = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)charstat_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ret2welcomeplayer).BeginInit();
            SuspendLayout();
            // 
            // campname_TXT
            // 
            campname_TXT.AutoSize = true;
            campname_TXT.BackColor = Color.Transparent;
            campname_TXT.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campname_TXT.ForeColor = Color.FromArgb(91, 120, 105);
            campname_TXT.Location = new Point(726, 31);
            campname_TXT.Name = "campname_TXT";
            campname_TXT.Size = new Size(188, 22);
            campname_TXT.TabIndex = 0;
            campname_TXT.Text = "Campaign Name: ";
            campname_TXT.TextAlign = ContentAlignment.MiddleRight;
            campname_TXT.Click += campname_TXT_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(369, 90);
            label1.Name = "label1";
            label1.Size = new Size(554, 73);
            label1.TabIndex = 1;
            label1.Text = "Character Stats";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // charstat_DGV
            // 
            charstat_DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            charstat_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            charstat_DGV.BackgroundColor = Color.FromArgb(247, 220, 143);
            charstat_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            charstat_DGV.GridColor = Color.FromArgb(91, 120, 105);
            charstat_DGV.Location = new Point(58, 179);
            charstat_DGV.Name = "charstat_DGV";
            charstat_DGV.RowHeadersWidth = 51;
            charstat_DGV.Size = new Size(1141, 398);
            charstat_DGV.TabIndex = 2;
            charstat_DGV.CellClick += charstat_DGV_CellClick;
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
            searchcharBT.Location = new Point(219, 599);
            searchcharBT.Name = "searchcharBT";
            searchcharBT.Size = new Size(212, 47);
            searchcharBT.TabIndex = 3;
            searchcharBT.Text = "Search Character";
            searchcharBT.TextAlign = ContentAlignment.MiddleRight;
            searchcharBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchcharBT.UseVisualStyleBackColor = false;
            searchcharBT.Click += searchchar_BT_Click;
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
            viewinvenBT.Location = new Point(831, 599);
            viewinvenBT.Name = "viewinvenBT";
            viewinvenBT.Size = new Size(196, 47);
            viewinvenBT.TabIndex = 4;
            viewinvenBT.Text = "View Inventory";
            viewinvenBT.TextAlign = ContentAlignment.MiddleRight;
            viewinvenBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewinvenBT.UseVisualStyleBackColor = false;
            viewinvenBT.Click += viewinven_BT_Click;
            // 
            // ret2welcomeplayer
            // 
            ret2welcomeplayer.BackColor = Color.Transparent;
            ret2welcomeplayer.BackgroundImage = (Image)resources.GetObject("ret2welcomeplayer.BackgroundImage");
            ret2welcomeplayer.BackgroundImageLayout = ImageLayout.Zoom;
            ret2welcomeplayer.BorderStyle = BorderStyle.FixedSingle;
            ret2welcomeplayer.ErrorImage = (Image)resources.GetObject("ret2welcomeplayer.ErrorImage");
            ret2welcomeplayer.InitialImage = (Image)resources.GetObject("ret2welcomeplayer.InitialImage");
            ret2welcomeplayer.Location = new Point(22, 22);
            ret2welcomeplayer.Name = "ret2welcomeplayer";
            ret2welcomeplayer.Size = new Size(77, 39);
            ret2welcomeplayer.TabIndex = 5;
            ret2welcomeplayer.TabStop = false;
            ret2welcomeplayer.Click += ret2welcomeplayer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 204, 92);
            label2.Location = new Point(105, 31);
            label2.Name = "label2";
            label2.Size = new Size(279, 22);
            label2.TabIndex = 6;
            label2.Text = "Return to Welcome Player ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // character_stat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 235, 171);
            ClientSize = new Size(1262, 673);
            Controls.Add(label2);
            Controls.Add(ret2welcomeplayer);
            Controls.Add(viewinvenBT);
            Controls.Add(searchcharBT);
            Controls.Add(charstat_DGV);
            Controls.Add(label1);
            Controls.Add(campname_TXT);
            Name = "character_stat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Status (Player View)";
            ((System.ComponentModel.ISupportInitialize)charstat_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ret2welcomeplayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label campname_TXT;
        private Label label1;
        private DataGridView charstat_DGV;
        private Button searchcharBT;
        private Button viewinvenBT;
        private PictureBox ret2welcomeplayer;
        private Label label2;
    }
}
