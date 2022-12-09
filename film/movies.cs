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


    }
}
