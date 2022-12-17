
using System;
using System.Data;
using System.Data.SqlClient;
namespace film
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        #region connexion 
        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=FILM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 
        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        #endregion

        public void log_in_btn_Click(object sender, EventArgs e)
        {

           
            
            cnx.Open();

            SqlCommand cmd = new SqlCommand("login", cnx);
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.Text.ToString();
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password.Text.ToString();
                SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                movies movies = new movies();
                movies.Show();
                this.Visible = false;
              
            }
            else
            {
                MessageBox.Show("login failed");
                
            }

            cnx.Close();
        }

    }
}