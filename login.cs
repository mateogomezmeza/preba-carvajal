using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace preba_carvajal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)

        {
            String user = usuario.Text;
            String password = contraseña.Text;
            SqlConnection sqlConnection = coneccion.conectar();
            sqlConnection.Open();
            try
            {

                SqlCommand command = new SqlCommand("SELECT USURIO,CONTRASEÑA FROM LOGEO WHERE USURIO='" + user.ToString() + "' and CONTRASEÑA='" + password.ToString() + "'", sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("BIENVENIDO ");
                this.Hide();

                Form form = new inicio();
                form.Show();

            }
            catch (SqlException)
            {

                MessageBox.Show("error");
            }


        }
    }
}
