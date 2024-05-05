using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace problema4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrar_persona_Click(object sender, EventArgs e)
        {
            // URL del script PHP
            if (textBoxCi.Text.Equals(""))
            {
                string phpUrl = "http://localhost/problema4/php/index.php";
                // Realizar una solicitud HTTP GET al script PHP
                try
                {
                    WebRequest request = WebRequest.Create(phpUrl);
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();

                    // Cerrar los recursos
                    reader.Close();
                    response.Close();

                    // Convertir la respuesta JSON a una lista de objetos
                    var personas = JsonConvert.DeserializeObject<Persona[]>(responseFromServer);

                    dataGridView1.DataSource = personas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos: " + ex.Message);
                }
            }
            else
            {
                string phpUrl = "http://localhost/problema4/php/index.php?ci=" + textBoxCi.Text;
                MessageBox.Show(phpUrl);

                // Realizar una solicitud HTTP GET al script PHP
                try
                {
                    WebRequest request = WebRequest.Create(phpUrl);
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();

                    // Cerrar los recursos
                    reader.Close();
                    response.Close();

                    if (!responseFromServer.Equals("null"))
                    {
                        // Convertir la respuesta JSON a un objeto Persona
                        var persona = JsonConvert.DeserializeObject<Persona>(responseFromServer);

                        // Crear una lista de una sola persona para enlazar al DataGridView
                        var personas = new List<Persona> { persona };

                        dataGridView1.DataSource = personas;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos: " + ex.Message);
                }

            }
        }

        private async void mostrar_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                // URL del script PHP
                string phpUrl = "http://localhost/problema4/php/index.php";

                // Datos a enviar en el cuerpo de la solicitud
                var data = new Dictionary<string, string>();

                if (!string.IsNullOrEmpty(textBoxCi_cuenta.Text))
                {
                    data.Add("ci", textBoxCi_cuenta.Text);
                }

                // Convertir los datos a formato JSON
                var json = JsonConvert.SerializeObject(data);

                // Crear cliente HTTP
                using (var client = new HttpClient())
                {
                    // Enviar la solicitud POST al servidor PHP
                    var response = await client.PostAsync(phpUrl, new StringContent(json, Encoding.UTF8, "application/json"));

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta del servidor
                        var responseContent = await response.Content.ReadAsStringAsync();

                        // Convertir la respuesta JSON a una lista de objetos Cuenta
                        var cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(responseContent);

                        // Mostrar los datos en el DataGridView
                        dataGridView1.DataSource = cuentas;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}");
            }
        }





        public class Persona
        {
            public int ci { get; set; }
            public string nombres { get; set; }
            public string paterno { get; set; }
            public string materno { get; set; }
            public string genero { get; set; }
            public string direccion_dom { get; set; }
            public string telefono { get; set; }
            public string celular { get; set; }
            public string correo { get; set; }
            public string password { get; set; }
            public string rol { get; set; }
            public string departamento { get; set; }
        }
        public class Cuenta
        {
            public string nro_cuenta { get; set; }
            public string tipo { get; set; }
            public decimal saldo { get; set; }
            public int ci { get; set; }
            public string status { get; set; }
        }


    }

}
