using Dapper;
using System;
using System.Data.SqlClient;

namespace Project.Data.Connection
{
    public class Backup
    {
        private readonly string ConnectionString;

        public Backup()
        {
            this.ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Generate(string backupFilePath)
        {
            string name = $" - {DateTime.Now.ToString("dd_MM_yyyy")}";

            // Crea la cadena de consulta para el respaldo utilizando la ruta proporcionada
            string query = $"BACKUP DATABASE [ProjectDatabase] TO DISK = N'{backupFilePath}' WITH NOFORMAT, NOINIT, NAME = N'ProjectDatabase-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Utiliza Dapper para ejecutar la consulta
                    connection.Execute(query);

                    // Aquí puedes realizar cualquier otra lógica necesaria después del respaldo
                    // ...

                    // Devuelve true indicando que la operación fue exitosa
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Maneja las excepciones según tus necesidades (registra, muestra mensajes, etc.)
                Console.WriteLine($"Error durante el respaldo: {ex.Message}");

                // Devuelve false indicando que la operación falló
                return false;
            }
        }
    }
}
