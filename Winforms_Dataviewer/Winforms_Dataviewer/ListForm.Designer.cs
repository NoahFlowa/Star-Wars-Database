namespace Winforms_Dataviewer
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.dataGridView_StarWarsInfo = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.moreInfo_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.filter_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.close_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StarWarsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_StarWarsInfo
            // 
            this.dataGridView_StarWarsInfo.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView_StarWarsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StarWarsInfo.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView_StarWarsInfo.Location = new System.Drawing.Point(80, 120);
            this.dataGridView_StarWarsInfo.Name = "dataGridView_StarWarsInfo";
            this.dataGridView_StarWarsInfo.RowTemplate.Height = 28;
            this.dataGridView_StarWarsInfo.Size = new System.Drawing.Size(891, 450);
            this.dataGridView_StarWarsInfo.TabIndex = 0;
            this.dataGridView_StarWarsInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Title.Location = new System.Drawing.Point(198, 21);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(681, 82);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Star Wars Database";
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // moreInfo_btn
            // 
            this.moreInfo_btn.BackColor = System.Drawing.Color.Transparent;
            this.moreInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreInfo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfo_btn.ForeColor = System.Drawing.Color.Gold;
            this.moreInfo_btn.Location = new System.Drawing.Point(382, 602);
            this.moreInfo_btn.Name = "moreInfo_btn";
            this.moreInfo_btn.Size = new System.Drawing.Size(145, 66);
            this.moreInfo_btn.TabIndex = 2;
            this.moreInfo_btn.Text = "More Info";
            this.moreInfo_btn.UseVisualStyleBackColor = false;
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Transparent;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.Gold;
            this.help_btn.Location = new System.Drawing.Point(533, 602);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(145, 66);
            this.help_btn.TabIndex = 3;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.Transparent;
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_btn.ForeColor = System.Drawing.Color.Gold;
            this.filter_btn.Location = new System.Drawing.Point(80, 602);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(145, 66);
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
            this.label2.Location = new System.Drawing.Point(925, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
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
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.Gold;
            this.close_btn.Location = new System.Drawing.Point(684, 602);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(145, 66);
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
            this.sort_btn.Location = new System.Drawing.Point(231, 602);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(145, 66);
            this.sort_btn.TabIndex = 7;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1068, 707);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.moreInfo_btn);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dataGridView_StarWarsInfo);
            this.Name = "ListForm";
            this.Text = "Star Wars Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StarWarsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_StarWarsInfo;
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

