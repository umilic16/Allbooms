
namespace Allbooms_v1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnByGenre = new System.Windows.Forms.Button();
            this.cbZanrovi = new System.Windows.Forms.ComboBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnByYears = new System.Windows.Forms.Button();
            this.nmUDYear = new System.Windows.Forms.NumericUpDown();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.btnByArtist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnByName = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnShowFromAlbum = new System.Windows.Forms.Button();
            this.tbAlbumInfo = new System.Windows.Forms.TextBox();
            this.dgvSongsFromAlbum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongsByArtist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbArtistInfo = new System.Windows.Forms.TextBox();
            this.btnShowByArtist = new System.Windows.Forms.Button();
            this.lbPlaylists = new System.Windows.Forms.ListBox();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.tbPlaylistName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSelectedAlbum = new System.Windows.Forms.TextBox();
            this.dgvPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.tbPlaylistInfo = new System.Windows.Forms.TextBox();
            this.btnShowByPlaylist = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnShowPlaylists = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsFromAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsByArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnByGenre
            // 
            this.btnByGenre.Location = new System.Drawing.Point(139, 39);
            this.btnByGenre.Name = "btnByGenre";
            this.btnByGenre.Size = new System.Drawing.Size(75, 23);
            this.btnByGenre.TabIndex = 0;
            this.btnByGenre.Text = "Search";
            this.btnByGenre.UseVisualStyleBackColor = true;
            this.btnByGenre.Click += new System.EventHandler(this.btnByGenre_Click);
            // 
            // cbZanrovi
            // 
            this.cbZanrovi.FormattingEnabled = true;
            this.cbZanrovi.Items.AddRange(new object[] {
            "Hip Hop",
            "Rock",
            "Jazz",
            "Pop"});
            this.cbZanrovi.Location = new System.Drawing.Point(12, 41);
            this.cbZanrovi.Name = "cbZanrovi";
            this.cbZanrovi.Size = new System.Drawing.Size(121, 21);
            this.cbZanrovi.TabIndex = 1;
            this.cbZanrovi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbZanrovi_KeyPress);
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.AllowUserToResizeColumns = false;
            this.dgvTabela.AllowUserToResizeRows = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumName,
            this.Artist,
            this.Genre,
            this.Year});
            this.dgvTabela.Location = new System.Drawing.Point(12, 70);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTabela.Size = new System.Drawing.Size(827, 303);
            this.dgvTabela.TabIndex = 2;
            this.dgvTabela.SelectionChanged += new System.EventHandler(this.dgvTabela_SelectionChanged);
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.AlbumName.DefaultCellStyle = dataGridViewCellStyle1;
            this.AlbumName.HeaderText = "Album Name";
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.ReadOnly = true;
            this.AlbumName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Artist
            // 
            this.Artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(217, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by year";
            // 
            // btnByYears
            // 
            this.btnByYears.Location = new System.Drawing.Point(347, 39);
            this.btnByYears.Name = "btnByYears";
            this.btnByYears.Size = new System.Drawing.Size(75, 23);
            this.btnByYears.TabIndex = 4;
            this.btnByYears.Text = "Search";
            this.btnByYears.UseVisualStyleBackColor = true;
            this.btnByYears.Click += new System.EventHandler(this.btnByYears_Click);
            // 
            // nmUDYear
            // 
            this.nmUDYear.Location = new System.Drawing.Point(220, 41);
            this.nmUDYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nmUDYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nmUDYear.Name = "nmUDYear";
            this.nmUDYear.Size = new System.Drawing.Size(121, 20);
            this.nmUDYear.TabIndex = 7;
            this.nmUDYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nmUDYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmUDYear_KeyPress);
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(429, 41);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(121, 20);
            this.tbArtist.TabIndex = 8;
            this.tbArtist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArtist_KeyPress);
            // 
            // btnByArtist
            // 
            this.btnByArtist.Location = new System.Drawing.Point(556, 39);
            this.btnByArtist.Name = "btnByArtist";
            this.btnByArtist.Size = new System.Drawing.Size(75, 23);
            this.btnByArtist.TabIndex = 9;
            this.btnByArtist.Text = "Search";
            this.btnByArtist.UseVisualStyleBackColor = true;
            this.btnByArtist.Click += new System.EventHandler(this.btnByArtist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(426, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search by artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(634, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search by name";
            // 
            // btnByName
            // 
            this.btnByName.Location = new System.Drawing.Point(764, 39);
            this.btnByName.Name = "btnByName";
            this.btnByName.Size = new System.Drawing.Size(75, 23);
            this.btnByName.TabIndex = 13;
            this.btnByName.Text = "Search";
            this.btnByName.UseVisualStyleBackColor = true;
            this.btnByName.Click += new System.EventHandler(this.btnByName_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(637, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 12;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btnShowFromAlbum
            // 
            this.btnShowFromAlbum.Location = new System.Drawing.Point(300, 411);
            this.btnShowFromAlbum.Name = "btnShowFromAlbum";
            this.btnShowFromAlbum.Size = new System.Drawing.Size(122, 23);
            this.btnShowFromAlbum.TabIndex = 15;
            this.btnShowFromAlbum.Text = "Show songs";
            this.btnShowFromAlbum.UseVisualStyleBackColor = true;
            this.btnShowFromAlbum.Click += new System.EventHandler(this.btnShowSongs_Click);
            // 
            // tbAlbumInfo
            // 
            this.tbAlbumInfo.Location = new System.Drawing.Point(12, 413);
            this.tbAlbumInfo.Name = "tbAlbumInfo";
            this.tbAlbumInfo.ReadOnly = true;
            this.tbAlbumInfo.Size = new System.Drawing.Size(282, 20);
            this.tbAlbumInfo.TabIndex = 16;
            // 
            // dgvSongsFromAlbum
            // 
            this.dgvSongsFromAlbum.AllowUserToAddRows = false;
            this.dgvSongsFromAlbum.AllowUserToDeleteRows = false;
            this.dgvSongsFromAlbum.AllowUserToResizeColumns = false;
            this.dgvSongsFromAlbum.AllowUserToResizeRows = false;
            this.dgvSongsFromAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongsFromAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSongsFromAlbum.Location = new System.Drawing.Point(12, 440);
            this.dgvSongsFromAlbum.Name = "dgvSongsFromAlbum";
            this.dgvSongsFromAlbum.ReadOnly = true;
            this.dgvSongsFromAlbum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSongsFromAlbum.Size = new System.Drawing.Size(410, 271);
            this.dgvSongsFromAlbum.TabIndex = 17;
            this.dgvSongsFromAlbum.SelectionChanged += new System.EventHandler(this.dgvSongsFromAlbum_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 35F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvSongsByArtist
            // 
            this.dgvSongsByArtist.AllowUserToAddRows = false;
            this.dgvSongsByArtist.AllowUserToDeleteRows = false;
            this.dgvSongsByArtist.AllowUserToResizeColumns = false;
            this.dgvSongsByArtist.AllowUserToResizeRows = false;
            this.dgvSongsByArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongsByArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvSongsByArtist.Location = new System.Drawing.Point(430, 440);
            this.dgvSongsByArtist.Name = "dgvSongsByArtist";
            this.dgvSongsByArtist.ReadOnly = true;
            this.dgvSongsByArtist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSongsByArtist.Size = new System.Drawing.Size(409, 271);
            this.dgvSongsByArtist.TabIndex = 20;
            this.dgvSongsByArtist.SelectionChanged += new System.EventHandler(this.dgvSongsByArtist_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Album";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 90F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 35F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbArtistInfo
            // 
            this.tbArtistInfo.Location = new System.Drawing.Point(430, 413);
            this.tbArtistInfo.Name = "tbArtistInfo";
            this.tbArtistInfo.ReadOnly = true;
            this.tbArtistInfo.Size = new System.Drawing.Size(278, 20);
            this.tbArtistInfo.TabIndex = 19;
            // 
            // btnShowByArtist
            // 
            this.btnShowByArtist.Location = new System.Drawing.Point(714, 410);
            this.btnShowByArtist.Name = "btnShowByArtist";
            this.btnShowByArtist.Size = new System.Drawing.Size(125, 23);
            this.btnShowByArtist.TabIndex = 18;
            this.btnShowByArtist.Text = "Show songs";
            this.btnShowByArtist.UseVisualStyleBackColor = true;
            this.btnShowByArtist.Click += new System.EventHandler(this.btnShowByArtist_Click);
            // 
            // lbPlaylists
            // 
            this.lbPlaylists.FormattingEnabled = true;
            this.lbPlaylists.Location = new System.Drawing.Point(999, 70);
            this.lbPlaylists.Name = "lbPlaylists";
            this.lbPlaylists.Size = new System.Drawing.Size(255, 303);
            this.lbPlaylists.TabIndex = 21;
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(845, 116);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(148, 23);
            this.btnCreatePlaylist.TabIndex = 22;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // tbPlaylistName
            // 
            this.tbPlaylistName.Location = new System.Drawing.Point(845, 90);
            this.tbPlaylistName.Name = "tbPlaylistName";
            this.tbPlaylistName.Size = new System.Drawing.Size(148, 20);
            this.tbPlaylistName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(845, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Playlist name:";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(845, 199);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(148, 23);
            this.btnAddAlbum.TabIndex = 25;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(842, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Add selected album";
            // 
            // tbSelectedAlbum
            // 
            this.tbSelectedAlbum.Location = new System.Drawing.Point(845, 173);
            this.tbSelectedAlbum.Name = "tbSelectedAlbum";
            this.tbSelectedAlbum.ReadOnly = true;
            this.tbSelectedAlbum.Size = new System.Drawing.Size(148, 20);
            this.tbSelectedAlbum.TabIndex = 29;
            // 
            // dgvPlaylistSongs
            // 
            this.dgvPlaylistSongs.AllowUserToAddRows = false;
            this.dgvPlaylistSongs.AllowUserToDeleteRows = false;
            this.dgvPlaylistSongs.AllowUserToResizeColumns = false;
            this.dgvPlaylistSongs.AllowUserToResizeRows = false;
            this.dgvPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvPlaylistSongs.Location = new System.Drawing.Point(848, 440);
            this.dgvPlaylistSongs.Name = "dgvPlaylistSongs";
            this.dgvPlaylistSongs.ReadOnly = true;
            this.dgvPlaylistSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPlaylistSongs.Size = new System.Drawing.Size(409, 271);
            this.dgvPlaylistSongs.TabIndex = 38;
            // 
            // tbPlaylistInfo
            // 
            this.tbPlaylistInfo.Location = new System.Drawing.Point(848, 413);
            this.tbPlaylistInfo.Name = "tbPlaylistInfo";
            this.tbPlaylistInfo.ReadOnly = true;
            this.tbPlaylistInfo.Size = new System.Drawing.Size(278, 20);
            this.tbPlaylistInfo.TabIndex = 37;
            // 
            // btnShowByPlaylist
            // 
            this.btnShowByPlaylist.Location = new System.Drawing.Point(1132, 410);
            this.btnShowByPlaylist.Name = "btnShowByPlaylist";
            this.btnShowByPlaylist.Size = new System.Drawing.Size(125, 23);
            this.btnShowByPlaylist.TabIndex = 36;
            this.btnShowByPlaylist.Text = "Show songs";
            this.btnShowByPlaylist.UseVisualStyleBackColor = true;
            this.btnShowByPlaylist.Click += new System.EventHandler(this.btnShowByPlaylist_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(12, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Show songs from selected album";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(428, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Show songs from selected artist";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(845, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Show songs from selected playlist";
            // 
            // btnShowPlaylists
            // 
            this.btnShowPlaylists.Location = new System.Drawing.Point(999, 39);
            this.btnShowPlaylists.Name = "btnShowPlaylists";
            this.btnShowPlaylists.Size = new System.Drawing.Size(255, 23);
            this.btnShowPlaylists.TabIndex = 43;
            this.btnShowPlaylists.Text = "ShowPlaylists";
            this.btnShowPlaylists.UseVisualStyleBackColor = true;
            this.btnShowPlaylists.Click += new System.EventHandler(this.btnShowPlaylists_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.FillWeight = 90F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Song";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.FillWeight = 35F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 723);
            this.Controls.Add(this.btnShowPlaylists);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPlaylistSongs);
            this.Controls.Add(this.tbPlaylistInfo);
            this.Controls.Add(this.btnShowByPlaylist);
            this.Controls.Add(this.tbSelectedAlbum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPlaylistName);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.lbPlaylists);
            this.Controls.Add(this.dgvSongsByArtist);
            this.Controls.Add(this.tbArtistInfo);
            this.Controls.Add(this.btnShowByArtist);
            this.Controls.Add(this.dgvSongsFromAlbum);
            this.Controls.Add(this.tbAlbumInfo);
            this.Controls.Add(this.btnShowFromAlbum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnByName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnByArtist);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.nmUDYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnByYears);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.cbZanrovi);
            this.Controls.Add(this.btnByGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsFromAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsByArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnByGenre;
        private System.Windows.Forms.ComboBox cbZanrovi;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnByYears;
        private System.Windows.Forms.NumericUpDown nmUDYear;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Button btnByArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnByName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnShowFromAlbum;
        private System.Windows.Forms.TextBox tbAlbumInfo;
        private System.Windows.Forms.DataGridView dgvSongsFromAlbum;
        private System.Windows.Forms.DataGridView dgvSongsByArtist;
        private System.Windows.Forms.TextBox tbArtistInfo;
        private System.Windows.Forms.Button btnShowByArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ListBox lbPlaylists;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.TextBox tbPlaylistName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSelectedAlbum;
        private System.Windows.Forms.DataGridView dgvPlaylistSongs;
        private System.Windows.Forms.TextBox tbPlaylistInfo;
        private System.Windows.Forms.Button btnShowByPlaylist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnShowPlaylists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

