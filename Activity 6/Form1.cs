using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form

    {
        private MySqlConnection connection; // Declare MySqlConnection at the class level
        private string connectionString = "Server=localhost;Database=activity_4;Uid=root;Pwd=root;"; // Declare connectionString at the class level

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void btnShowAllAlbums_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM albums"; // SQL query to fetch all albums

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridAlbums.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int albumId = GetSelectedAlbumId();
            DisplayTracks(albumId);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            string artist = txt_artist.Text;
            string year = txt_year.Text;
            string imageUrl = txt_image_url.Text;
            string description = txt_description.Text;

            string query = "INSERT INTO albums (album_title, artist, year, image_url, description) VALUES (@title, @artist, @year, @imageUrl, @description)";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@artist", artist);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@imageUrl", imageUrl);
                cmd.Parameters.AddWithValue("@description", description);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Album added successfully!");
                    // Optionally, clear the text boxes after successful addition
                    txt_title.Clear();
                    txt_artist.Clear();
                    txt_year.Clear();
                    txt_image_url.Clear();
                    txt_description.Clear();
                }
                else
                {
                    MessageBox.Show("Error adding album!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void txt_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_image_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchAlbum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       private void btnAddTrack_Click(object sender, EventArgs e)
{
    string trackTitle = txt_trackTitle.Text;
    string videoUrl = txt_videoUrl.Text;
    int albumId = GetSelectedAlbumId(); // Implement a method to get the selected album ID

    if (albumId == -1)
    {
        MessageBox.Show("Please select an album first.");
        return;
    }

    string query = "INSERT INTO tracks (album_id, track_title, video_url) VALUES (@albumId, @trackTitle, @videoUrl)";

    try
    {
        connection.Open();
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@albumId", albumId);
        cmd.Parameters.AddWithValue("@trackTitle", trackTitle);
        cmd.Parameters.AddWithValue("@videoUrl", videoUrl);
        int rowsAffected = cmd.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            MessageBox.Show("Track added successfully!");
            // Optionally, clear the text boxes after successful addition
            txt_trackTitle.Clear();
            txt_videoUrl.Clear();
        }
        else
        {
            MessageBox.Show("Error adding track!");
        }
    }
    catch (MySqlException ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
    finally
    {
        if (connection.State == ConnectionState.Open)
            connection.Close();
    }
        }

        private int GetSelectedAlbumId()
        {
            if (dataGridAlbums.SelectedRows.Count > 0)
            {
                // Assuming the ID column is the first column in your DataGridView
                // Adjust the column index if the ID column is at a different position
                DataGridViewRow selectedRow = dataGridAlbums.SelectedRows[0];
                int albumId;
                if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out albumId))
                {
                    return albumId;
                }
            }
            return -1; // Return -1 if no album is selected or if the ID cannot be parsed
        }

        private void DisplayTracks(int albumId)
        {
            string query = "SELECT track_title, video_url FROM tracks WHERE album_id = @albumId";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@albumId", albumId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Call this method when an album is selected (e.g., in a selection changed event)
        private void AlbumSelectionChanged(object sender, EventArgs e)
        {
            int albumId = GetSelectedAlbumId(); // Implement a method to get the selected album ID
            if (albumId != -1)
            {
                DisplayTracks(albumId);
            }
        }

    }
}
