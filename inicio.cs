using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace preba_carvajal
{
    public partial class inicio : Form
    {
        String dato;
        public inicio()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRUEBADataSet.VUELOS' Puede moverla o quitarla según sea necesario.
            this.vUELOSTableAdapter.Fill(this.pRUEBADataSet.VUELOS);

            horallegada.Format = DateTimePickerFormat.Custom;
            horallegada.CustomFormat = "hh:mm:ss";
            horasalida.Format = DateTimePickerFormat.Custom;
            horasalida.CustomFormat = "hh:mm:ss";
            fecha.Format = DateTimePickerFormat.Custom;
            fecha.CustomFormat = "dd/mm/yyyy";


        }



        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = coneccion.conectar();
            sqlConnection.Open();
            String estado = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string sql = "INSERT INTO VUELOS(NUMERODEVUELO,AEROLINEA,ORIGEN,DESTINO,FECHA,HORASALIDA,HORALLEGADA,ESTADODEVUELO) VALUES ('" + numerovuelo.Text + "','" + aerolinea.Text + "','" + origen.Text + "','" + destino.Text + "','" + fecha.Text + "','" + horasalida.Text + "','" + horallegada.Text + "','" + estado + "')";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            command.ExecuteNonQuery();
            this.vUELOSTableAdapter.Fill(this.pRUEBADataSet.VUELOS);

            numerovuelo.Clear();
            aerolinea.Clear();
            origen.Clear();
            destino.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {


            SqlConnection sqlConnection = coneccion.conectar();
            sqlConnection.Open();
            MessageBox.Show("borrar registro?");
            String sql = "DELETE FROM VUELOS WHERE NUMERODEVUELO='" + dato + "';";
            // WHERE NUMERODEVUELO= + dato
            try
            {
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("no eliminado " + ex);
            }


            this.vUELOSTableAdapter.Fill(this.pRUEBADataSet.VUELOS);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            dato = row.Cells[0].Value.ToString();
        }


    }
}
