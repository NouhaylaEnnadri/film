using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace film
{
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
        }

        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=FILM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void movie_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String id;
           

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.movie_grid.Rows[e.RowIndex];

                id = row.Cells["id_f"].Value.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [dbo].[nbr_intr] (@id)";
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                label2.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "select [dbo].[rating] (@id2)";
                cmd.Parameters.Add("@id2", SqlDbType.NVarChar).Value = id;
                label5.Text = cmd.ExecuteScalar().ToString();


            }


        }
        private void movies_Load(object sender, EventArgs e)
        {

           
            cnx.Open();
         
            cmd.CommandText = "select * from film f , notation n where f.id_f = n.id_f and email = 'noyl@gmail.com'  ";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            movie_grid.DataSource = dt;
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
