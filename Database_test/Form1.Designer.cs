namespace Database_test
{
    partial class Database
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
            this.Information = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RaceText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Label_Race = new System.Windows.Forms.Label();
            this.Label_Region = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.RegionSelectbox = new System.Windows.Forms.ComboBox();
            this.Control = new System.Windows.Forms.GroupBox();
            this.Btn_DataLoad = new System.Windows.Forms.Button();
            this.Btn_DataSave = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.GroupBox();
            this.ListCombobox = new System.Windows.Forms.ComboBox();
            this.DataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.Information.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Control.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Controls.Add(this.tableLayoutPanel1);
            this.Information.Location = new System.Drawing.Point(11, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(567, 304);
            this.Information.TabIndex = 0;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.RaceText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_Race, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Label_Region, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Label_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IDText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RegionSelectbox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RaceText
            // 
            this.RaceText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RaceText.Location = new System.Drawing.Point(113, 139);
            this.RaceText.Name = "RaceText";
            this.RaceText.Size = new System.Drawing.Size(438, 28);
            this.RaceText.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.Location = new System.Drawing.Point(113, 71);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(438, 28);
            this.NameText.TabIndex = 6;
            // 
            // Label_Race
            // 
            this.Label_Race.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Race.Location = new System.Drawing.Point(3, 136);
            this.Label_Race.Name = "Label_Race";
            this.Label_Race.Size = new System.Drawing.Size(104, 68);
            this.Label_Race.TabIndex = 4;
            this.Label_Race.Text = "Race";
            this.Label_Race.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Region
            // 
            this.Label_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Region.Location = new System.Drawing.Point(3, 204);
            this.Label_Region.Name = "Label_Region";
            this.Label_Region.Size = new System.Drawing.Size(104, 68);
            this.Label_Region.TabIndex = 3;
            this.Label_Region.Text = "Region";
            this.Label_Region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Name
            // 
            this.Label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Name.Location = new System.Drawing.Point(3, 68);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(104, 68);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ID
            // 
            this.Label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ID.Location = new System.Drawing.Point(3, 0);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(104, 68);
            this.Label_ID.TabIndex = 0;
            this.Label_ID.Text = "ID";
            this.Label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDText
            // 
            this.IDText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDText.Location = new System.Drawing.Point(113, 3);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(438, 28);
            this.IDText.TabIndex = 5;
            // 
            // RegionSelectbox
            // 
            this.RegionSelectbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegionSelectbox.FormattingEnabled = true;
            this.RegionSelectbox.Items.AddRange(new object[] {
            "1지역",
            "2지역",
            "3지역"});
            this.RegionSelectbox.Location = new System.Drawing.Point(114, 208);
            this.RegionSelectbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegionSelectbox.Name = "RegionSelectbox";
            this.RegionSelectbox.Size = new System.Drawing.Size(436, 26);
            this.RegionSelectbox.TabIndex = 8;
            // 
            // Control
            // 
            this.Control.Controls.Add(this.Btn_DataLoad);
            this.Control.Controls.Add(this.Btn_DataSave);
            this.Control.Controls.Add(this.BtnRemove);
            this.Control.Controls.Add(this.BtnCreate);
            this.Control.Controls.Add(this.BtnClear);
            this.Control.Location = new System.Drawing.Point(599, 12);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(567, 304);
            this.Control.TabIndex = 1;
            this.Control.TabStop = false;
            this.Control.Text = "Control";
            // 
            // Btn_DataLoad
            // 
            this.Btn_DataLoad.Location = new System.Drawing.Point(291, 134);
            this.Btn_DataLoad.Name = "Btn_DataLoad";
            this.Btn_DataLoad.Size = new System.Drawing.Size(276, 62);
            this.Btn_DataLoad.TabIndex = 4;
            this.Btn_DataLoad.Text = "DataLoad";
            this.Btn_DataLoad.UseVisualStyleBackColor = true;
            this.Btn_DataLoad.Click += new System.EventHandler(this.Btn_DataLoad_Click);
            // 
            // Btn_DataSave
            // 
            this.Btn_DataSave.Location = new System.Drawing.Point(291, 33);
            this.Btn_DataSave.Name = "Btn_DataSave";
            this.Btn_DataSave.Size = new System.Drawing.Size(276, 62);
            this.Btn_DataSave.TabIndex = 3;
            this.Btn_DataSave.Text = "DataSave";
            this.Btn_DataSave.UseVisualStyleBackColor = true;
            this.Btn_DataSave.Click += new System.EventHandler(this.Btn_DataSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(6, 231);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(277, 62);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(7, 134);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(276, 62);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(7, 34);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(276, 62);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // List
            // 
            this.List.Controls.Add(this.ListCombobox);
            this.List.Controls.Add(this.DataGridViewInfo);
            this.List.Location = new System.Drawing.Point(11, 322);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(1154, 309);
            this.List.TabIndex = 1;
            this.List.TabStop = false;
            this.List.Text = "List";
            // 
            // ListCombobox
            // 
            this.ListCombobox.FormattingEnabled = true;
            this.ListCombobox.Items.AddRange(new object[] {
            "1지역",
            "2지역",
            "3지역"});
            this.ListCombobox.Location = new System.Drawing.Point(41, 26);
            this.ListCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListCombobox.Name = "ListCombobox";
            this.ListCombobox.Size = new System.Drawing.Size(270, 26);
            this.ListCombobox.TabIndex = 1;
            this.ListCombobox.SelectedIndexChanged += new System.EventHandler(this.ListCombobox_SelectedIndexChanged);
            // 
            // DataGridViewInfo
            // 
            this.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInfo.Location = new System.Drawing.Point(11, 63);
            this.DataGridViewInfo.Name = "DataGridViewInfo";
            this.DataGridViewInfo.RowHeadersWidth = 62;
            this.DataGridViewInfo.RowTemplate.Height = 30;
            this.DataGridViewInfo.Size = new System.Drawing.Size(1134, 240);
            this.DataGridViewInfo.TabIndex = 0;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 644);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Information);
            this.Name = "Database";
            this.Text = "Database";
            this.Information.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Control.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.GroupBox List;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Label_Race;
        private System.Windows.Forms.Label Label_Region;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox RaceText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DataGridView DataGridViewInfo;
        private System.Windows.Forms.ComboBox RegionSelectbox;
        private System.Windows.Forms.ComboBox ListCombobox;
        private System.Windows.Forms.Button Btn_DataLoad;
        private System.Windows.Forms.Button Btn_DataSave;
    }
}

