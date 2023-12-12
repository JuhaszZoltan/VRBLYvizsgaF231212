using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace BEstGamesGUI
{
    public partial class FrmBestGames : Form
    {
        private readonly string connectionString;

        public FrmBestGames()
        {
            connectionString =
                "server=(localdb)\\MSSQLLocalDB;" +
                "database=bestgames;";

            InitializeComponent();
            this.Load += FrmBestGames_Load;
            this.Load += Query_Event;
            tbxTitle.TextChanged += Query_Event;
            cbxGenre.TextChanged += Query_Event;
            dgvGames.CellClick += DgvGames_CellClick;
            lnkGoogle.LinkClicked += LnkGoogle_LinkClicked;
        }

        private void LnkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(lnkGoogle.Text) { UseShellExecute = true });
        }

        private void DgvGames_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            string title = dgvGames[1, e.RowIndex].Value.ToString()!.Replace(' ', '+').ToLower();
            lnkGoogle.Text = $@"https://www.google.com/search?q={title}";
        }

        private void FrmBestGames_Load(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(connectionString);
            conn.Open();
            var rdr = new SqlCommand("SELECT name FROM genre;", conn).ExecuteReader();
            while (rdr.Read()) cbxGenre.Items.Add(rdr[0]);
        }

        private void Query_Event(object? sender, EventArgs e)
        {
            dgvGames.Rows.Clear();
            using SqlConnection conn = new(connectionString);
            conn.Open();
            string cmdStr = "SELECT game.id, title, year, genre.name " +
                "FROM game INNER JOIN genre ON game.genreId = genre.id " +
                $"WHERE title LIKE '{tbxTitle.Text}%'" +
                $"{(string.IsNullOrEmpty(cbxGenre.Text) ? ";" : $" AND genre.name = '{cbxGenre.Text}';")}";
            var rdr = new SqlCommand(cmdStr, conn).ExecuteReader();
            while (rdr.Read()) dgvGames.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);

        }
    }
}
