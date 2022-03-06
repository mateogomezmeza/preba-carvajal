Esta es la solucion de la prueba asignada 
```
DATOS DEL SERVIDOR
Nombre del servidor : localhost
Nombre de la base de datos: PRUEBA
Usuario de la base de datos: PRUEBA
Contraseña del usuario : PRUEBA

----------------------------------
DATOS DEL LONGIN
Usuario de login : CARVAJAL
Contraseña de login: 123

---------------------------------

script de base de datos

user.ToString : hace referencia al usuario 
password.ToString() : hace referencia a la contraseña del usuario

Se realiza una consulta a la base de datos donde se valida el usuario
SELECT USURIO,CONTRASEÑA FROM LOGEO WHERE USURIO='" + user.ToString()  + "' and CONTRASEÑA='" + password.ToString() + "'


Sentencia donde se agregan los datos
"INSERT INTO VUELOS(NUMERODEVUELO,AEROLINEA,ORIGEN,DESTINO,FECHA,HORASALIDA,HORALLEGADA,ESTADODEVUELO) VALUES ('" + numerovuelo.Text + "','" + aerolinea.Text + "','" + origen.Text + "','" + destino.Text + "','" + fecha.Text + "','" + horasalida.Text + "','" + horallegada.Text + "','" + estado + "')"

Sentencia de eliminacion de datos con llave primaria 
"DELETE FROM VUELOS WHERE NUMERODEVUELO='" + dato + "';"














```
