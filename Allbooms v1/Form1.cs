using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.Entities;

namespace Allbooms_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Show albums functions and event handlers
        private void ShowByGenre()
        {
            if (dgvTabela.Rows.Count > 0)
                dgvTabela.Rows.Clear();
            if (cbZanrovi.SelectedItem == null)
                return;
            string genre = cbZanrovi.SelectedItem.ToString();
            List<Album> albumi = DataProvider.GetAlbumsByGenre(genre);
            if (albumi == null)
                return;
            foreach (Album album in albumi)
                dgvTabela.Rows.Add(album.Name, album.Artist, album.Genre, album.Year);
        }
        private void ShowByYear()
        {
            if (dgvTabela.Rows.Count > 0)
                dgvTabela.Rows.Clear();
            string year = nmUDYear.Value.ToString();
            List<Album> albumi = DataProvider.GetAlbumsByYear(year);
            if (albumi == null)
                return;
            foreach (Album album in albumi)
                dgvTabela.Rows.Add(album.Name, album.Artist, album.Genre, album.Year);
        }
        private void ShowByArtist()
        {
            if (dgvTabela.Rows.Count > 0)
                dgvTabela.Rows.Clear();
            if (tbArtist.Text.Length == 0)
                return;
            string artist = tbArtist.Text;
            tbArtist.Text = null;
            List<Album> albumi = DataProvider.GetAlbumsByArtist(artist);
            if (albumi == null)
                return;
            foreach (Album album in albumi)
                dgvTabela.Rows.Add(album.Name, album.Artist, album.Genre, album.Year);
        }
        private void ShowByName() 
        {
            if (dgvTabela.Rows.Count > 0)
                dgvTabela.Rows.Clear();
            if (tbName.Text.Length == 0)
                return;
            string name = tbName.Text;
            tbName.Text = null;
            List<Album> albumi = DataProvider.GetAlbumsByName(name);
            if (albumi == null)
                return;
            foreach (Album album in albumi)
                dgvTabela.Rows.Add(album.Name, album.Artist, album.Genre, album.Year);
        }
        private void btnByGenre_Click(object sender, EventArgs e)
        {
            ShowByGenre();
        }
        private void btnByYears_Click(object sender, EventArgs e)
        {
            ShowByYear();
        }
        private void btnByArtist_Click(object sender, EventArgs e)
        {
            ShowByArtist();
        }
        private void btnByName_Click(object sender, EventArgs e)
        {
            ShowByName();
        }
        private void cbZanrovi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                ShowByGenre();
        }
        private void nmUDYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                ShowByYear();
        }
        private void tbArtist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                ShowByArtist();
        }
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                ShowByName();
        }
        #endregion

        #region Show songs functions and event handlers
        private string albumName, artistName;
        private void dgvTabela_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTabela.SelectedCells.Count > 0)
            {
                albumName = dgvTabela.Rows[dgvTabela.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                artistName = dgvTabela.Rows[dgvTabela.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            }
        }
        private void btnShowSongs_Click(object sender, EventArgs e)
        {
            if (dgvSongsFromAlbum.Rows.Count > 0)
                dgvSongsFromAlbum.Rows.Clear();
            if (albumName == null || artistName == null)
                return;
            tbAlbumInfo.Text = albumName + " by " + artistName;
            List<Song> songs = DataProvider.GetSongsFromAlbum(artistName, albumName).OrderBy(s=>s.Num).ToList();
            foreach (Song song in songs)
                dgvSongsFromAlbum.Rows.Add(song.Num, song.Name, song.Duration);

        }
        private void btnShowByArtist_Click(object sender, EventArgs e)
        {
            if (dgvSongsByArtist.Rows.Count > 0)
                dgvSongsByArtist.Rows.Clear();
            if (artistName == null)
                return;
            tbArtistInfo.Text = artistName;
            List<Song> songs = DataProvider.GetSongsByArtist(artistName).OrderBy(s => s.Album).ThenBy(s => s.Num).ToList();
            foreach (Song song in songs)
                dgvSongsByArtist.Rows.Add(song.Album, song.Name, song.Duration);
        }
        #endregion
        #region Show playlist, add songs and albums to playlist
        private string songName1, songName2;
        private void dgvSongsFromAlbum_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvSongsFromAlbum.SelectedCells.Count>0)
                songName1 = dgvSongsFromAlbum.Rows[dgvSongsFromAlbum.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
        }
        private void dgvSongsByArtist_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSongsByArtist.SelectedCells.Count > 0)
                songName2 = dgvSongsByArtist.Rows[dgvSongsFromAlbum.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
        }
        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (tbPlaylistName.Text.Length == 0)
                return;
            DataProvider.CreatePlaylist(tbPlaylistName.Text);
            tbPlaylistName.Text = null;
            LoadPlaylists();
        }
        private void LoadPlaylists()
        {
            if (lbPlaylists.Items.Count > 0)
                lbPlaylists.Items.Clear();
            List<Playlist> playlists = DataProvider.GetPlaylists();
            foreach (Playlist playlist in playlists)
                lbPlaylists.Items.Add(playlist.Name);
        }
        private void AddSongToPlaylist(string song)
        {

        }
        private void btnAddSong1_Click(object sender, EventArgs e)
        {
            AddSongToPlaylist(songName1);
        }
        private void btnAddSong2_Click(object sender, EventArgs e)
        {
            AddSongToPlaylist(songName2);
        }

        private void btnShowByPlaylist_Click(object sender, EventArgs e)
        {
            if (lbPlaylists.SelectedItem == null)
                return;
            string plName = lbPlaylists.SelectedItem.ToString();
            tbPlaylistInfo.Text = plName;
            List<Playlist> playlists = DataProvider.GetSongsByPlaylist(plName);
            foreach (Playlist pl in playlists)
                dgvPlaylistSongs.Rows.Add(pl.Song, pl.Artist);
        }

        private void btnShowPlaylists_Click(object sender, EventArgs e)
        {
            LoadPlaylists();
        }
        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            if (dgvSongsFromAlbum.Rows.Count > 0)
                dgvSongsFromAlbum.Rows.Clear();
            if (albumName == null || artistName == null)
                return;
            if (lbPlaylists.SelectedItem == null)
                return;
            tbSelectedAlbum.Text = albumName;
            List<Song> songs = DataProvider.GetSongsFromAlbum(artistName, albumName).OrderBy(s => s.Num).ToList();
            string playlist = lbPlaylists.SelectedItem.ToString();
            foreach (Song song in songs)
                DataProvider.AddToPlaylist(playlist, song.Name, song.Artist);

        }
        #endregion
    }
}
