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

namespace Materi13Mei
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            if (rButtonLaki.Checked = true)
            {
                sqlQuery = "INSERT INTO pelajar VALUES('" + tBoxID.Text + "', '" + tBoxNama.Text + "', '" + cBoxJurusan.Text + "', '" + dTimePickerTglLahir.Value.ToString("yyyyMMdd") + "', '" + tBoxNoInduk.Text + "', '" + tBoxNoTelp.Text + "', '" + rButtonLaki.Text + "', '" + tBoxAlamat.Text + "', '" + cBoxAngkatan.Text + "', '" + tBoxEmail.Text + "', 0)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data pelajar baru dengan nama '" + tBoxNama.Text + "' telah ditambahkan");
            }
            else if (rButtonPerempuan.Checked = true)
            {
                sqlQuery = "INSERT INTO pelajar VALUES('" + tBoxID.Text + "', '" + tBoxNama.Text + "', '" + cBoxJurusan.Text + "', '" + dTimePickerTglLahir.Value.ToString("yyyyMMdd") + "', '" + tBoxNoInduk.Text + "', '" + tBoxNoTelp.Text + "', '" + rButtonPerempuan.Text + "', '" + tBoxAlamat.Text + "', '" + cBoxAngkatan.Text + "', '" + tBoxEmail.Text + "', 0)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data pelajar baru dengan nama '" + tBoxNama.Text + "' telah ditambahkan");
            }
            sqlConnect.Close();

        }
    }
}
