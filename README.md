# Taller-VB-SqlServer

# Pasos para ejecutar el ejemplo
 - Crear la base de datos con el nombre **Prueba** luego ejecutar el script.sql 
 ```SQL
CREATE TABLE USUARIO (
    id INT PRIMARY KEY IDENTITY (1, 1),
    nombre VARCHAR (13) NOT NULL,
    apellido VARCHAR (10) NOT NULL,
    edad INT NOT NULL,
    direccion VARCHAR(30) NOT NULL,
    telefono VARCHAR(30) NOT NULL
);
 ```
 - En la carpeta CRUD ejecutar el **CRUD.sln** 
 - Cambiar el nombre de la computadora en la conexion a la base de datos.

 ```VB
Dim connection As New SqlConnection("Data Source=<NOMBRE_DE_LA_PC>;Initial Catalog=Prueba;Integrated Security=True")
 ```

# Pesentacion
https://docs.google.com/presentation/d/11u_teJjbJRToWc0TWgW5dtR1VIx_mdSXmkQbtbjLnts/edit?usp=sharing

# Contacto
Julio Cotzojay

juliocotzo11@gmail.com
