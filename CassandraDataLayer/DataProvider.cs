using System;
using System.Collections.Generic;
using Cassandra;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CassandraDataLayer.Entities;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region GetAlbums
        public static List<Album> GetAlbumsByGenre(string genre) 
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Album> albums = new List<Album>();

            //select * from Allbooms_by_genre where Genre = genre
            var albumsData = session.Execute("select * from \"Allbooms_by_genre\" where \"Genre\" = '" + genre +"'");

            foreach(var albumData in albumsData)
            {
                Album album = new Album
                {
                    Name = albumData["Name"] != null ? albumData["Name"].ToString() : string.Empty,
                    Artist = albumData["Artist"] != null ? albumData["Artist"].ToString() : string.Empty,
                    Genre = albumData["Genre"] != null ? albumData["Genre"].ToString() : string.Empty,
                    Year = albumData["Year"] != null ? albumData["Year"].ToString() : string.Empty
                };
                albums.Add(album);
            }

            return albums; 
        }
        public static List<Album> GetAlbumsByYear(string year)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Album> albums = new List<Album>();

            //select * from Allbooms_by_year where Year = year
            var albumsData = session.Execute("select * from \"Allbooms_by_year\" where \"Year\" = '" + year + "'");

            foreach (var albumData in albumsData)
            {
                Album album = new Album
                {
                    Name = albumData["Name"] != null ? albumData["Name"].ToString() : string.Empty,
                    Artist = albumData["Artist"] != null ? albumData["Artist"].ToString() : string.Empty,
                    Genre = albumData["Genre"] != null ? albumData["Genre"].ToString() : string.Empty,
                    Year = albumData["Year"] != null ? albumData["Year"].ToString() : string.Empty
                };
                albums.Add(album);
            }

            return albums;
        }
        public static List<Album> GetAlbumsByArtist(string artist)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Album> albums = new List<Album>();

            //select * from Allbooms_by_artist where Artist = artist
            var albumsData = session.Execute("select * from \"Allbooms_by_artist\" where \"Artist\" = '" + artist + "'");

            foreach (var albumData in albumsData)
            {
                Album album = new Album
                {
                    Name = albumData["Name"] != null ? albumData["Name"].ToString() : string.Empty,
                    Artist = albumData["Artist"] != null ? albumData["Artist"].ToString() : string.Empty,
                    Genre = albumData["Genre"] != null ? albumData["Genre"].ToString() : string.Empty,
                    Year = albumData["Year"] != null ? albumData["Year"].ToString() : string.Empty
                };
                albums.Add(album);
            }

            return albums;
        }
        public static List<Album> GetAlbumsByName(string name)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Album> albums = new List<Album>();

            //select * from Allbooms_by_name where Name = name
            var albumsData = session.Execute("select * from \"Allbooms_by_name\" where \"Name\" = '" + name + "'");

            foreach (var albumData in albumsData)
            {
                Album album = new Album
                {
                    Name = albumData["Name"] != null ? albumData["Name"].ToString() : string.Empty,
                    Artist = albumData["Artist"] != null ? albumData["Artist"].ToString() : string.Empty,
                    Genre = albumData["Genre"] != null ? albumData["Genre"].ToString() : string.Empty,
                    Year = albumData["Year"] != null ? albumData["Year"].ToString() : string.Empty
                };
                albums.Add(album);
            }

            return albums;
        }
        #endregion
        #region GetSongs
        public static List<Song> GetSongsFromAlbum(string artist, string album)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Song> songs = new List<Song>();

            //select * from Songs_from_album where Artist = artist and Album = album
            var songsData = session.Execute("select * from \"Songs_from_album\" where \"Artist\" = '" + artist + "' and \"Album_name\" = '" + album + "'");
            foreach (var songData in songsData)
            {
                Song song = new Song
                {
                    Artist = songData["Artist"] != null ? songData["Artist"].ToString() : string.Empty,
                    Album = songData["Album_name"] != null ? songData["Album_name"].ToString() : string.Empty,
                    Num = songData["Song_num"] != null ? songData["Song_num"].ToString() : string.Empty,
                    Name = songData["Song_name"] != null ? songData["Song_name"].ToString() : string.Empty,
                    Duration = songData["Duration"] != null ? songData["Duration"].ToString() : string.Empty
                };
                songs.Add(song);
            }
            return songs;
        }
        public static List<Song> GetSongsByArtist(string artist)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Song> songs = new List<Song>();

            //select * from Songs_from_album where Artist = artist
            var songsData = session.Execute("select * from \"Songs_by_artist\" where \"Artist\" = '" + artist + "'");
            foreach (var songData in songsData)
            {
                Song song = new Song
                {
                    Artist = songData["Artist"] != null ? songData["Artist"].ToString() : string.Empty,
                    Album = songData["Album_name"] != null ? songData["Album_name"].ToString() : string.Empty,
                    Num = songData["Song_num"] != null ? songData["Song_num"].ToString() : string.Empty,
                    Name = songData["Song_name"] != null ? songData["Song_name"].ToString() : string.Empty,
                    Duration = songData["Duration"] != null ? songData["Duration"].ToString() : string.Empty
                };
                songs.Add(song);
            }
            return songs;
        }
        public static List<Playlist> GetSongsByPlaylist(string name)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Playlist> playlists = new List<Playlist>();

            //select * from Songs_from_album where Artist = artist and Album = album
            var playlistsData = session.Execute("select * from \"Playlists\" where \"Playlist_name\" = '" + name + "'");
            foreach (var playlistData in playlistsData)
            {
                Playlist playlist = new Playlist
                {
                    Name = playlistData["Playlist_name"] != null ? playlistData["Playlist_name"].ToString() : string.Empty,
                    Song = playlistData["Song_name"] != null ? playlistData["Song_name"].ToString() : string.Empty,
                    Artist = playlistData["Artist"] != null ? playlistData["Artist"].ToString() : string.Empty,
                };
                if (playlist.Song != "initial_element" && playlist.Artist != "initial_element")
                    playlists.Add(playlist);
            }
            return playlists;
        }
        #endregion
        #region Playlists
        //get all playlists
        public static List<Playlist> GetPlaylists()
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Playlist> playlists = new List<Playlist>();

            //select * from Songs_from_album where Artist = artist and Album = album
            var playlistsData = session.Execute("select * from \"Playlists\"");
            foreach (var playlistData in playlistsData)
            {
                Playlist playlist = new Playlist
                {
                    Name = playlistData["Playlist_name"] != null ? playlistData["Playlist_name"].ToString() : string.Empty,
                    Song = playlistData["Song_name"] != null ? playlistData["Song_name"].ToString() : string.Empty,
                    Artist = playlistData["Artist"] != null ? playlistData["Artist"].ToString() : string.Empty,
                };
                playlists.Add(playlist);
            }
            List<Playlist> distinct = playlists.GroupBy(pl => pl.Name).Select(el => el.First()).ToList();
            return distinct;
        }
        //get playlist by name
        public static void CreatePlaylist(string name)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            session.Execute("insert into \"Playlists\" (\"Playlist_name\",\"Song_name\",\"Artist\") VALUES ('" + name + "','initial_element','initial_element')");
        }
        public static void AddToPlaylist(string playlist,string song, string artist)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            session.Execute("insert into \"Playlists\" (\"Playlist_name\",\"Song_name\",\"Artist\") VALUES ('" + playlist + "','" + song + "','" + artist + "')");
        }
        #endregion
    }
}
