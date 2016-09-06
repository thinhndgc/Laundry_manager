namespace LaunryManager
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accountManagerPanel = new System.Windows.Forms.Panel();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.staffGrid = new System.Windows.Forms.DataGridView();
            this.btnNewStaff = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnServiceRefresh = new System.Windows.Forms.Button();
            this.serviceGrid = new System.Windows.Forms.DataGridView();
            this.btnNewService = new System.Windows.Forms.Button();
            this.accountManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // accountManagerPanel
            // 
            this.accountManagerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountManagerPanel.Controls.Add(this.cbSearchType);
            this.accountManagerPanel.Controls.Add(this.btnSearch);
            this.accountManagerPanel.Controls.Add(this.txtSearch);
            this.accountManagerPanel.Controls.Add(this.btnRefresh);
            this.accountManagerPanel.Controls.Add(this.staffGrid);
            this.accountManagerPanel.Controls.Add(this.btnNewStaff);
            this.accountManagerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountManagerPanel.Location = new System.Drawing.Point(0, 0);
            this.accountManagerPanel.Name = "accountManagerPanel";
            this.accountManagerPanel.Size = new System.Drawing.Size(1284, 711);
            this.accountManagerPanel.TabIndex = 2;
            this.accountManagerPanel.Visible = false;
            // 
            // cbSearchType
            // 
            this.cbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchType.ForeColor = System.Drawing.Color.DarkCyan;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(970, 15);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(161, 39);
            this.cbSearchType.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1146, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 41);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtSearch.Location = new System.Drawing.Point(505, 15);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(449, 38);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(168, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // staffGrid
            // 
            this.staffGrid.AllowUserToAddRows = false;
            this.staffGrid.AllowUserToDeleteRows = false;
            this.staffGrid.AllowUserToOrderColumns = true;
            this.staffGrid.AllowUserToResizeColumns = false;
            this.staffGrid.AllowUserToResizeRows = false;
            this.staffGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.staffGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGrid.GridColor = System.Drawing.Color.DarkCyan;
            this.staffGrid.Location = new System.Drawing.Point(12, 74);
            this.staffGrid.MultiSelect = false;
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.ReadOnly = true;
            this.staffGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.staffGrid.Size = new System.Drawing.Size(1260, 608);
            this.staffGrid.TabIndex = 1;
            this.staffGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffGrid_CellContentClick);
            this.staffGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.staffGrid_CellFormatting);
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.ForeColor = System.Drawing.Color.White;
            this.btnNewStaff.Location = new System.Drawing.Point(12, 15);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(126, 41);
            this.btnNewStaff.TabIndex = 0;
            this.btnNewStaff.Text = "New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = false;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip1";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip2";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnServiceRefresh);
            this.panel2.Controls.Add(this.serviceGrid);
            this.panel2.Controls.Add(this.btnNewService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 711);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // btnServiceRefresh
            // 
            this.btnServiceRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnServiceRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceRefresh.ForeColor = System.Drawing.Color.White;
            this.btnServiceRefresh.Location = new System.Drawing.Point(168, 15);
            this.btnServiceRefresh.Name = "btnServiceRefresh";
            this.btnServiceRefresh.Size = new System.Drawing.Size(126, 41);
            this.btnServiceRefresh.TabIndex = 2;
            this.btnServiceRefresh.Text = "Refresh";
            this.btnServiceRefresh.UseVisualStyleBackColor = false;
            this.btnServiceRefresh.Click += new System.EventHandler(this.btnServiceRefresh_Click);
            // 
            // serviceGrid
            // 
            this.serviceGrid.AllowUserToAddRows = false;
            this.serviceGrid.AllowUserToDeleteRows = false;
            this.serviceGrid.AllowUserToOrderColumns = true;
            this.serviceGrid.AllowUserToResizeColumns = false;
            this.serviceGrid.AllowUserToResizeRows = false;
            this.serviceGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.serviceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceGrid.GridColor = System.Drawing.Color.DarkCyan;
            this.serviceGrid.Location = new System.Drawing.Point(12, 74);
            this.serviceGrid.MultiSelect = false;
            this.serviceGrid.Name = "serviceGrid";
            this.serviceGrid.ReadOnly = true;
            this.serviceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.serviceGrid.Size = new System.Drawing.Size(1260, 608);
            this.serviceGrid.TabIndex = 1;
            this.serviceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceGrid_CellContentClick);
            // 
            // btnNewService
            // 
            this.btnNewService.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewService.ForeColor = System.Drawing.Color.White;
            this.btnNewService.Location = new System.Drawing.Point(12, 15);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(126, 41);
            this.btnNewService.TabIndex = 0;
            this.btnNewService.Text = "New Service";
            this.btnNewService.UseVisualStyleBackColor = false;
            this.btnNewService.Click += new System.EventHandler(this.btnNewService_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.accountManagerPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 750);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laundry Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.accountManagerPanel.ResumeLayout(false);
            this.accountManagerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel accountManagerPanel;
        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.DataGridView staffGrid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnServiceRefresh;
        private System.Windows.Forms.DataGridView serviceGrid;
        private System.Windows.Forms.Button btnNewService;
    }
}