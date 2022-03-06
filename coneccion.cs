using System;
using System.Data.SqlClient;

namespace preba_carvajal
{
    internal class coneccion
    {
        public static SqlConnection conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection("SERVER=localhost;DATABASE=PRUEBA;integrated security=false;User ID=PRUEBA;Password=PRUEBA");
                return cn;
            }
            catch (SqlException e)
            {
                Console.WriteLine("error" + e);

                return null;
            }



        }
    }
}
