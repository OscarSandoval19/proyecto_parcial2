using System.ComponentModel.Design;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar el formulario: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarInventario()
        {

            try
            {
                Console.WriteLine("Llamando a MostrarInventario...");
                string connectionString = @"Data Source=DESKTOP-FEN742K\SQLEXPRESS;Initial Catalog=GData;Integrated Security=True;TrustServerCertificate=True";
                string query = "SELECT DISTINCT * FROM dbo.Inventario";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dataGridViewInventario.DataSource = null;
                    dataGridViewInventario.Rows.Clear();
                    dataGridViewInventario.Columns.Clear();
                    dataGridViewInventario.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.Message);
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.Message);
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cb1.SelectedItem.ToString();

            if (seleccion == "Comun")
            {
                txt5.Text = "Madera de Roble - Piedra - Hierro";

            }
            else if (seleccion == "Raro")
            {
                txt5.Text = "Oro - Redstone - Obsidiana - Lapislazuli";
            }
            else if (seleccion == "Epico")
            {
                txt5.Text = "Diamante - Esmeralda - Bloque de Netherita";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            cb1.Text = "";
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt4.Text, out int idJugador))
                {
                    string conexion = @"Server=DESKTOP-FEN742K\SQLEXPRESS;Database=GData;Integrated Security=True;TrustServerCertificate=True";

                    using (SqlConnection conn = new SqlConnection(conexion))
                    {
                        conn.Open(); // Asegúrate de abrir la conexión aquí

                        string consulta = "SELECT Nombre FROM dbo.Jugadores WHERE Id = @id";
                        SqlCommand comando = new SqlCommand(consulta, conn);
                        comando.Parameters.AddWithValue("@id", idJugador);

                        SqlDataReader lector = comando.ExecuteReader(); // Ejecuta el comando con la conexión abierta

                        if (lector.Read())
                        {
                            txt1.Text = lector["Nombre"].ToString();
                            if (txt1.Text == "Steve")
                            {
                                txt2.Text = "15";
                            }
                            else if (txt1.Text == "Alex")
                            {
                                txt2.Text = "12";
                            }
                            else if (txt1.Text == "Notch")
                            {
                                txt2.Text = "99";
                            }
                            else if (txt1.Text == "Herobrine")
                            {
                                txt2.Text = "100";
                            }
                            else if (txt1.Text == "DiamondGamer")
                            {
                                txt2.Text = "45";
                            }
                            else if (txt1.Text == "RedstoneMaster")
                            {
                                txt2.Text = "32";
                            }
                            else if (txt1.Text == "CreeperHunter")
                            {
                                txt2.Text = "28";
                            }
                            else if (txt1.Text == "EndermanSlayer")
                            {
                                txt2.Text = "60";
                            }
                            else if (txt1.Text == "NetherExplorer")
                            {
                                txt2.Text = "38";
                            }
                            else if (txt1.Text == "Technoblade")
                            {
                                txt2.Text = "70";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error. El jugador solicitado no existe.");
                        }
                        lector.Close();

                        string consultaBloques = @"
                    SELECT b.Nombre, i.Cantidad
                    FROM dbo.Inventario i
                    INNER JOIN dbo.Bloques b ON i.BloqueId = b.Id
                    WHERE i.JugadorId = @id";
                        SqlCommand comandoBloques = new SqlCommand(consultaBloques, conn);
                        comandoBloques.Parameters.AddWithValue("@id", idJugador);

                        SqlDataReader lectorBloques = comandoBloques.ExecuteReader();

                        // Construir el mensaje para txt3.Text
                        string mensaje = $"{txt1.Text} tiene los siguientes bloques:\n";
                        while (lectorBloques.Read())
                        {
                            string nombreBloque = lectorBloques["Nombre"].ToString();
                            int cantidad = (int)lectorBloques["Cantidad"];
                            mensaje += $"{txt1.Text} tiene {cantidad} bloques de {nombreBloque}\n";
                        }
                        lectorBloques.Close();

                        txt3.Text = mensaje;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }














        private void dataGridViewInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text == "Steve")
            {
                txt3.Text = "Steve tiene 64 bloques de madera";
            }
            else if (txt1.Text == "Alex")
            {
                txt3.Text = "Alex tiene 128 bloques de piedra";
            }
            else if (txt1.Text == "Notch")
            {
                txt3.Text = "Notch tiene 5 diamantes";
            }
            else if (txt1.Text == "Herobrine")
            {
                txt3.Text = "Herobrine tiene 1 bloque de netherita";
            }
            else if (txt1.Text == "DiamondGamer")
            {
                txt3.Text = "DiamondGamer tiene 12 diamantes";
            }
            else if (txt1.Text == "RedstoneMaster")
            {
                txt3.Text = "RedstoneMaster tiene 45 redstone";
            }
            else if (txt1.Text == "CreeperHunter")
            {
                txt3.Text = "CreeperHunter tiene 8 bloques de oro";
            }
            else if (txt1.Text == "EndermanSlayer")
            {
                txt3.Text = "EndermanSlayer tiene 3 esmeraldas";
            }
            else if (txt1.Text == "NetherExplorer")
            {
                txt3.Text = "NetherExplorer  tiene 14 obsidianas";
            }
            else if (txt1.Text == "Technoblade")
            {
                txt3.Text = "Technoblade tiene 32 bloques de hierro";
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
        
        }
    }
}

    


           
           
               
        
    
