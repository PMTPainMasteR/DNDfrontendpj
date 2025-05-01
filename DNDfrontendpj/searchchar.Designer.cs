namespace DNDfrontendpj
{
    partial class searchchar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchchar));
            label1 = new Label();
            searchchar_TB = new TextBox();
            searchcharBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 120, 105);
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(233, 22);
            label1.TabIndex = 5;
            label1.Text = "Enter Character Name";
            // 
            // searchchar_TB
            // 
            searchchar_TB.BackColor = Color.FromArgb(247, 220, 143);
            searchchar_TB.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchchar_TB.Location = new Point(44, 74);
            searchchar_TB.Name = "searchchar_TB";
            searchchar_TB.Size = new Size(427, 28);
            searchchar_TB.TabIndex = 4;
            // 
            // searchcharBT
            // 
            searchcharBT.BackColor = Color.FromArgb(150, 206, 180);
            searchcharBT.FlatAppearance.BorderSize = 0;
            searchcharBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 220, 143);
            searchcharBT.FlatStyle = FlatStyle.Flat;
            searchcharBT.ForeColor = Color.FromArgb(145, 199, 176);
            searchcharBT.Image = (Image)resources.GetObject("searchcharBT.Image");
            searchcharBT.Location = new Point(477, 44);
            searchcharBT.Name = "searchcharBT";
            searchcharBT.Size = new Size(57, 58);
            searchcharBT.TabIndex = 3;
            searchcharBT.UseVisualStyleBackColor = false;
            searchcharBT.Click += searchcharBT_Click;
            // 
            // searchchar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 238, 173);
            ClientSize = new Size(581, 149);
            Controls.Add(label1);
            Controls.Add(searchchar_TB);
            Controls.Add(searchcharBT);
            Name = "searchchar";
            Text = "Search Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchchar_TB;
        private Button searchcharBT;
    }
}