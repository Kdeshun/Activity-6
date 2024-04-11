namespace MusicApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.txt_videoUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_trackTitle = new System.Windows.Forms.TextBox();
            this.lb_trackTitle = new System.Windows.Forms.Label();
            this.lb_addAlbum = new System.Windows.Forms.GroupBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.txt_image_url = new System.Windows.Forms.TextBox();
            this.lb_imageurl = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.lb_year = new System.Windows.Forms.Label();
            this.txt_artist = new System.Windows.Forms.TextBox();
            this.lb_artist = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowAllAlbums = new System.Windows.Forms.Button();
            this.txtSearchAlbum = new System.Windows.Forms.TextBox();
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSearchTRack = new System.Windows.Forms.TextBox();
            this.btnShowAllTrack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridAlbums = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSearchAlbum = new System.Windows.Forms.Button();
            this.btnSearchTrack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.lb_addAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTrack);
            this.groupBox1.Controls.Add(this.txt_videoUrl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_trackTitle);
            this.groupBox1.Controls.Add(this.lb_trackTitle);
            this.groupBox1.Location = new System.Drawing.Point(30, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(14, 129);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(80, 29);
            this.btnAddTrack.TabIndex = 11;
            this.btnAddTrack.Text = "Add";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // txt_videoUrl
            // 
            this.txt_videoUrl.Location = new System.Drawing.Point(10, 89);
            this.txt_videoUrl.Name = "txt_videoUrl";
            this.txt_videoUrl.Size = new System.Drawing.Size(230, 22);
            this.txt_videoUrl.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Video URL";
            // 
            // txt_trackTitle
            // 
            this.txt_trackTitle.Location = new System.Drawing.Point(10, 38);
            this.txt_trackTitle.Name = "txt_trackTitle";
            this.txt_trackTitle.Size = new System.Drawing.Size(230, 22);
            this.txt_trackTitle.TabIndex = 3;
            // 
            // lb_trackTitle
            // 
            this.lb_trackTitle.AutoSize = true;
            this.lb_trackTitle.Location = new System.Drawing.Point(7, 18);
            this.lb_trackTitle.Name = "lb_trackTitle";
            this.lb_trackTitle.Size = new System.Drawing.Size(71, 16);
            this.lb_trackTitle.TabIndex = 2;
            this.lb_trackTitle.Text = "Track Title";
            // 
            // lb_addAlbum
            // 
            this.lb_addAlbum.Controls.Add(this.btnAdd1);
            this.lb_addAlbum.Controls.Add(this.txt_description);
            this.lb_addAlbum.Controls.Add(this.lb_description);
            this.lb_addAlbum.Controls.Add(this.txt_image_url);
            this.lb_addAlbum.Controls.Add(this.lb_imageurl);
            this.lb_addAlbum.Controls.Add(this.txt_year);
            this.lb_addAlbum.Controls.Add(this.lb_year);
            this.lb_addAlbum.Controls.Add(this.txt_artist);
            this.lb_addAlbum.Controls.Add(this.lb_artist);
            this.lb_addAlbum.Controls.Add(this.txt_title);
            this.lb_addAlbum.Controls.Add(this.lb_title);
            this.lb_addAlbum.Location = new System.Drawing.Point(30, 19);
            this.lb_addAlbum.Name = "lb_addAlbum";
            this.lb_addAlbum.Size = new System.Drawing.Size(246, 323);
            this.lb_addAlbum.TabIndex = 2;
            this.lb_addAlbum.TabStop = false;
            this.lb_addAlbum.Text = "Add Album";
            this.lb_addAlbum.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(14, 275);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(80, 29);
            this.btnAdd1.TabIndex = 10;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(10, 236);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(230, 22);
            this.txt_description.TabIndex = 9;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(7, 216);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(75, 16);
            this.lb_description.TabIndex = 8;
            this.lb_description.Text = "Description";
            // 
            // txt_image_url
            // 
            this.txt_image_url.Location = new System.Drawing.Point(10, 190);
            this.txt_image_url.Name = "txt_image_url";
            this.txt_image_url.Size = new System.Drawing.Size(230, 22);
            this.txt_image_url.TabIndex = 7;
            this.txt_image_url.TextChanged += new System.EventHandler(this.txt_image_url_TextChanged);
            // 
            // lb_imageurl
            // 
            this.lb_imageurl.AutoSize = true;
            this.lb_imageurl.Location = new System.Drawing.Point(7, 170);
            this.lb_imageurl.Name = "lb_imageurl";
            this.lb_imageurl.Size = new System.Drawing.Size(75, 16);
            this.lb_imageurl.TabIndex = 6;
            this.lb_imageurl.Text = "Image URL";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(10, 142);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(230, 22);
            this.txt_year.TabIndex = 5;
            this.txt_year.TextChanged += new System.EventHandler(this.txt_year_TextChanged);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(7, 122);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(36, 16);
            this.lb_year.TabIndex = 4;
            this.lb_year.Text = "Year";
            this.lb_year.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_artist
            // 
            this.txt_artist.Location = new System.Drawing.Point(10, 94);
            this.txt_artist.Name = "txt_artist";
            this.txt_artist.Size = new System.Drawing.Size(230, 22);
            this.txt_artist.TabIndex = 3;
            // 
            // lb_artist
            // 
            this.lb_artist.AutoSize = true;
            this.lb_artist.Location = new System.Drawing.Point(7, 74);
            this.lb_artist.Name = "lb_artist";
            this.lb_artist.Size = new System.Drawing.Size(36, 16);
            this.lb_artist.TabIndex = 2;
            this.lb_artist.Text = "Artist";
            this.lb_artist.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(10, 42);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(230, 22);
            this.txt_title.TabIndex = 1;
            this.txt_title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(7, 22);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(33, 16);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Title";
            this.lb_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Albums";
            // 
            // btnShowAllAlbums
            // 
            this.btnShowAllAlbums.Location = new System.Drawing.Point(377, 11);
            this.btnShowAllAlbums.Name = "btnShowAllAlbums";
            this.btnShowAllAlbums.Size = new System.Drawing.Size(158, 29);
            this.btnShowAllAlbums.TabIndex = 11;
            this.btnShowAllAlbums.Text = "Show All Albums";
            this.btnShowAllAlbums.UseVisualStyleBackColor = true;
            this.btnShowAllAlbums.Click += new System.EventHandler(this.btnShowAllAlbums_Click);
            // 
            // txtSearchAlbum
            // 
            this.txtSearchAlbum.Location = new System.Drawing.Point(552, 14);
            this.txtSearchAlbum.Name = "txtSearchAlbum";
            this.txtSearchAlbum.Size = new System.Drawing.Size(154, 22);
            this.txtSearchAlbum.TabIndex = 12;
            this.txtSearchAlbum.TextChanged += new System.EventHandler(this.txtSearchAlbum_TextChanged);
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Location = new System.Drawing.Point(831, 11);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(173, 29);
            this.btnDeleteAlbum.TabIndex = 13;
            this.btnDeleteAlbum.Text = "Delete Selected Albums";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(831, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Delete Selected Tracks";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSearchTRack
            // 
            this.txtSearchTRack.Location = new System.Drawing.Point(552, 403);
            this.txtSearchTRack.Name = "txtSearchTRack";
            this.txtSearchTRack.Size = new System.Drawing.Size(154, 22);
            this.txtSearchTRack.TabIndex = 18;
            this.txtSearchTRack.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // btnShowAllTrack
            // 
            this.btnShowAllTrack.Location = new System.Drawing.Point(377, 400);
            this.btnShowAllTrack.Name = "btnShowAllTrack";
            this.btnShowAllTrack.Size = new System.Drawing.Size(158, 29);
            this.btnShowAllTrack.TabIndex = 17;
            this.btnShowAllTrack.Text = "Show All Tracks";
            this.btnShowAllTrack.UseVisualStyleBackColor = true;
            this.btnShowAllTrack.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tracks";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(860, 440);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(441, 241);
            this.webBrowser1.TabIndex = 20;
            // 
            // dataGridAlbums
            // 
            this.dataGridAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlbums.Location = new System.Drawing.Point(317, 61);
            this.dataGridAlbums.Name = "dataGridAlbums";
            this.dataGridAlbums.RowHeadersWidth = 51;
            this.dataGridAlbums.RowTemplate.Height = 24;
            this.dataGridAlbums.Size = new System.Drawing.Size(593, 336);
            this.dataGridAlbums.TabIndex = 21;
            this.dataGridAlbums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(317, 449);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(513, 254);
            this.dataGridView2.TabIndex = 22;
            // 
            // btnSearchAlbum
            // 
            this.btnSearchAlbum.Location = new System.Drawing.Point(725, 11);
            this.btnSearchAlbum.Name = "btnSearchAlbum";
            this.btnSearchAlbum.Size = new System.Drawing.Size(82, 29);
            this.btnSearchAlbum.TabIndex = 23;
            this.btnSearchAlbum.Text = "Search";
            this.btnSearchAlbum.UseVisualStyleBackColor = true;
            this.btnSearchAlbum.Click += new System.EventHandler(this.btnSearchAlbum_Click);
            // 
            // btnSearchTrack
            // 
            this.btnSearchTrack.Location = new System.Drawing.Point(725, 400);
            this.btnSearchTrack.Name = "btnSearchTrack";
            this.btnSearchTrack.Size = new System.Drawing.Size(82, 29);
            this.btnSearchTrack.TabIndex = 24;
            this.btnSearchTrack.Text = "Search";
            this.btnSearchTrack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 752);
            this.Controls.Add(this.btnSearchTrack);
            this.Controls.Add(this.btnSearchAlbum);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridAlbums);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtSearchTRack);
            this.Controls.Add(this.btnShowAllTrack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.txtSearchAlbum);
            this.Controls.Add(this.btnShowAllAlbums);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_addAlbum);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lb_addAlbum.ResumeLayout(false);
            this.lb_addAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox lb_addAlbum;
        private System.Windows.Forms.TextBox txt_image_url;
        private System.Windows.Forms.Label lb_imageurl;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.TextBox txt_artist;
        private System.Windows.Forms.Label lb_artist;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.TextBox txt_videoUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_trackTitle;
        private System.Windows.Forms.Label lb_trackTitle;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowAllAlbums;
        private System.Windows.Forms.TextBox txtSearchAlbum;
        private System.Windows.Forms.Button btnDeleteAlbum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSearchTRack;
        private System.Windows.Forms.Button btnShowAllTrack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridAlbums;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSearchAlbum;
        private System.Windows.Forms.Button btnSearchTrack;
    }
}

