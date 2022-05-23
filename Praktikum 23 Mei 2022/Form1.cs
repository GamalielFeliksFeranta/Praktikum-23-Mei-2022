using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Praktikum_23_Mei_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable Player = new DataTable();
        DataTable Nationality = new DataTable();
        DataTable Team = new DataTable();
        int PosisiSekarang = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select * from player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Player);
            DataPlayer(0);

            sqlQuery = "select n.nation as `Nationality`, p.nationality_id as Nation from player p, nationality n where p.nationality_id = n.nationality_id group by p.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Nationality);
            DataPlayer(0);
            CboxNationality.DataSource = Nationality;
            CboxNationality.DisplayMember = "Nationality";
            CboxNationality.ValueMember = "Nation";

            sqlQuery = "select t.team_name as `Team`, p.team_id as TeamID from player p, team t where p.team_id = t.team_id group by t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Team);
            CboxTeam.DataSource = Team;
            CboxTeam.DisplayMember = "Team";
            CboxTeam.ValueMember = "TeamID";
            DataPlayer(0);

        }



        public void DataPlayer(int posisi)
        {
            TboxPlayerID.Text = Player.Rows[posisi][0].ToString();
            TboxPlayerName.Text = Player.Rows[posisi][2].ToString();
            DateTimeBirthdate.Text = Player.Rows[posisi][7].ToString();
            CboxNationality.SelectedValue = Player.Rows[posisi][3].ToString();
            CboxTeam.SelectedValue = Player.Rows[posisi][8].ToString();
            NumUpDown.Text = Player.Rows[posisi][1].ToString();
            PosisiSekarang = posisi;

        }


        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < Player.Rows.Count - 1)
            {
                PosisiSekarang++;
                DataPlayer(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                DataPlayer(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            DataPlayer(Player.Rows.Count - 1);
        }

        private void Btn_First_Click(object sender, EventArgs e)
        {
            DataPlayer(0);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sqlQuery = $"UPDATE player SET player_id = '{TboxPlayerID.Text}', player_name = '{ TboxPlayerName.Text }', birthdate = '{ DateTimeBirthdate.Value.ToString("yyyy-MM-dd") }', nationality_id = '{ CboxNationality.SelectedValue }', team_id= '{  CboxTeam.SelectedValue }' WHERE player_id = '{TboxPlayerID.Text}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            Player = new DataTable();
            sqlQuery = "select * from player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Player);
            DataPlayer(PosisiSekarang);           
        }
    }
}





        



