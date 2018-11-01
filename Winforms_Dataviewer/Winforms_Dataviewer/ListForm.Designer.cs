namespace Winforms_Dataviewer
{
    partial class SWdb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SWdb));
            this.dataGridView_swDB = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.moreInfo_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.filter_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.close_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_swDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_swDB
            // 
            this.dataGridView_swDB.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_swDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_swDB.GridColor = System.Drawing.Color.White;
            this.dataGridView_swDB.Location = new System.Drawing.Point(53, 78);
            this.dataGridView_swDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_swDB.Name = "dataGridView_swDB";
            this.dataGridView_swDB.RowTemplate.Height = 28;
            this.dataGridView_swDB.Size = new System.Drawing.Size(594, 292);
            this.dataGridView_swDB.TabIndex = 0;
            this.dataGridView_swDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_swDB_CellContentClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Title.Location = new System.Drawing.Point(132, 14);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(457, 55);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Star Wars Database";
            this.lbl_Title.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // moreInfo_btn
            // 
            this.moreInfo_btn.BackColor = System.Drawing.Color.Transparent;
            this.moreInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreInfo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfo_btn.ForeColor = System.Drawing.Color.Gold;
            this.moreInfo_btn.Location = new System.Drawing.Point(255, 391);
            this.moreInfo_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moreInfo_btn.Name = "moreInfo_btn";
            this.moreInfo_btn.Size = new System.Drawing.Size(97, 43);
            this.moreInfo_btn.TabIndex = 2;
            this.moreInfo_btn.Text = "More Info";
            this.moreInfo_btn.UseVisualStyleBackColor = false;
            this.moreInfo_btn.Click += new System.EventHandler(this.moreInfo_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Transparent;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.Gold;
            this.help_btn.Location = new System.Drawing.Point(355, 391);
            this.help_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(97, 43);
            this.help_btn.TabIndex = 3;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.Transparent;
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_btn.ForeColor = System.Drawing.Color.Gold;
            this.filter_btn.Location = new System.Drawing.Point(53, 391);
            this.filter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(97, 43);
            this.filter_btn.TabIndex = 4;
            this.filter_btn.Text = "Filter";
            this.filter_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(617, 441);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "swDB Version 66";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.Gold;
            this.close_btn.Location = new System.Drawing.Point(456, 391);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(97, 43);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.BackColor = System.Drawing.Color.Transparent;
            this.sort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_btn.ForeColor = System.Drawing.Color.Gold;
            this.sort_btn.Location = new System.Drawing.Point(154, 391);
            this.sort_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(97, 43);
            this.sort_btn.TabIndex = 7;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = false;
            // 
            // SWdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 460);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.moreInfo_btn);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dataGridView_swDB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SWdb";
            this.Text = "Star Wars Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_swDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_swDB;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button moreInfo_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.Button close_btn;
    }
}

