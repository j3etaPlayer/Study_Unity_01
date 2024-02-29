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
            this.Control = new System.Windows.Forms.GroupBox();
            this.List = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Region = new System.Windows.Forms.Label();
            this.Label_Race = new System.Windows.Forms.Label();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Race_Textbox = new System.Windows.Forms.TextBox();
            this.Region_Textbox = new System.Windows.Forms.TextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Information.SuspendLayout();
            this.Control.SuspendLayout();
            this.List.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Controls.Add(this.tableLayoutPanel1);
            this.Information.Location = new System.Drawing.Point(12, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(567, 305);
            this.Information.TabIndex = 0;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // Control
            // 
            this.Control.Controls.Add(this.Btn_Remove);
            this.Control.Controls.Add(this.Btn_Create);
            this.Control.Controls.Add(this.Btn_Clear);
            this.Control.Location = new System.Drawing.Point(599, 12);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(567, 305);
            this.Control.TabIndex = 1;
            this.Control.TabStop = false;
            this.Control.Text = "Control";
            // 
            // List
            // 
            this.List.Controls.Add(this.DataGrid);
            this.List.Location = new System.Drawing.Point(12, 323);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(1154, 309);
            this.List.TabIndex = 1;
            this.List.TabStop = false;
            this.List.Text = "List";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.Region_Textbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Race_Textbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Name_Textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_Race, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Label_Region, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Label_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ID_Textbox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Label_ID
            // 
            this.Label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ID.Location = new System.Drawing.Point(3, 0);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(105, 68);
            this.Label_ID.TabIndex = 0;
            this.Label_ID.Text = "ID";
            this.Label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Name
            // 
            this.Label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Name.Location = new System.Drawing.Point(3, 68);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(105, 68);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Region
            // 
            this.Label_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Region.Location = new System.Drawing.Point(3, 204);
            this.Label_Region.Name = "Label_Region";
            this.Label_Region.Size = new System.Drawing.Size(105, 68);
            this.Label_Region.TabIndex = 3;
            this.Label_Region.Text = "Region";
            this.Label_Region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Race
            // 
            this.Label_Race.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Race.Location = new System.Drawing.Point(3, 136);
            this.Label_Race.Name = "Label_Race";
            this.Label_Race.Size = new System.Drawing.Size(105, 68);
            this.Label_Race.TabIndex = 4;
            this.Label_Race.Text = "Race";
            this.Label_Race.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_Textbox.Location = new System.Drawing.Point(114, 3);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(438, 28);
            this.ID_Textbox.TabIndex = 5;
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_Textbox.Location = new System.Drawing.Point(114, 71);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(438, 28);
            this.Name_Textbox.TabIndex = 6;
            // 
            // Race_Textbox
            // 
            this.Race_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Race_Textbox.Location = new System.Drawing.Point(114, 139);
            this.Race_Textbox.Name = "Race_Textbox";
            this.Race_Textbox.Size = new System.Drawing.Size(438, 28);
            this.Race_Textbox.TabIndex = 7;
            // 
            // Region_Textbox
            // 
            this.Region_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Region_Textbox.Location = new System.Drawing.Point(114, 207);
            this.Region_Textbox.Name = "Region_Textbox";
            this.Region_Textbox.Size = new System.Drawing.Size(438, 28);
            this.Region_Textbox.TabIndex = 8;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(7, 34);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(554, 61);
            this.Btn_Clear.TabIndex = 0;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(7, 133);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(554, 61);
            this.Btn_Create.TabIndex = 1;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(6, 231);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(554, 61);
            this.Btn_Remove.TabIndex = 2;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 28);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 30;
            this.DataGrid.Size = new System.Drawing.Size(1135, 275);
            this.DataGrid.TabIndex = 0;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Information);
            this.Name = "Database";
            this.Text = "Database";
            this.Information.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.List.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
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
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.TextBox Region_Textbox;
        private System.Windows.Forms.TextBox Race_Textbox;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}

