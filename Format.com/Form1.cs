using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Format.com
{
    public partial class Form1: Form
    {
        private string _driveLetter;

        private readonly Dictionary<string, List<string>> tamanosAsignacion = new Dictionary<string, List<string>>
    {
        { "NTFS", new List<string> { "512", "1024", "2048", "4096", "8192", "16K", "32K", "64K" } },
        { "FAT32", new List<string> { "512", "1024", "2048", "4096", "8192", "16K", "32K" } },
        { "exFAT", new List<string> { "512", "1024", "2048", "4096", "8192", "16K", "32K", "64K", "128K", "256K", "512K", "1M", "2M" } }
    };
        private readonly Dictionary<string, string> tamanosPredeterminados = new Dictionary<string, string>
    {
        { "NTFS", "64K" },
        { "FAT32", "32K" },
        { "exFAT", "2M" }
    };

        private void CargarTamanosAsignacion()
        {
            if (comboSistemaArchivos.SelectedItem is string sistemaArchivos && tamanosAsignacion.ContainsKey(sistemaArchivos))
            {
                comboBoxTamanoAsignacion.Items.Clear();
                comboBoxTamanoAsignacion.Items.AddRange(tamanosAsignacion[sistemaArchivos].ToArray());
                string predeterminado = tamanosPredeterminados[sistemaArchivos];
                comboBoxTamanoAsignacion.SelectedItem = predeterminado;
            }
        }

        // Constructor modificado para recibir la letra de la unidad.
        public Form1(string driveLetter)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(driveLetter))
            {
                MessageBox.Show("No se ha proporcionado una unidad válida." + driveLetter, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); // Cierra la aplicación si no se proporciona una unidad.
                return;
            }

            _driveLetter = driveLetter;
        }

        private void DisplayDriveInfo()
        {
            try
            {
                // Verificar si la letra de la unidad es válida.
                if (string.IsNullOrEmpty(_driveLetter) || _driveLetter.Length != 2 || _driveLetter[1] != ':')
                {
                    MessageBox.Show("La letra de la unidad no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                // Obtener información de la unidad.
                DriveInfo drive = new DriveInfo(_driveLetter);

                // Verificar si la unidad está lista.
                if (!drive.IsReady)
                {
                    MessageBox.Show($"La unidad {_driveLetter} no está lista o no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                // Mostrar información de la unidad.
                lblLetraUnidad.Text = $"{drive.Name}";
                Text = $"Formatear unidad {drive.Name}";

                comboCapacidad.Items.Add($"{drive.TotalSize / (1024 * 1024 * 1024)} GB"); 
                comboCapacidad.SelectedIndex = 0;

                if(drive.Name == "C:\\")
                    lblNombre.Text = "Disco local";
                else
                    lblNombre.Text = $"{drive.VolumeLabel}";

                lblTipo.Text = $"{drive.DriveType}";
                lblSistemaArchivos.Text = $"{drive.DriveFormat}";
                lblLetra.Text = $"{drive.Name}";
                lblLetra.Text = lblLetra.Text.Substring(0, 1);
                lblLibre.Text = $"{drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB";
                lblUsado.Text = $"{(drive.TotalSize - drive.AvailableFreeSpace) / (1024 * 1024 * 1024)} GB";
                txtNombre.Text = $"{drive.VolumeLabel}";
                // Cargar sistemas de archivos en el ComboBox.
                LoadFileSystems(drive.DriveFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener información de la unidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); // Cierra la aplicación si hay un error.
            }
        }

        private void LoadFileSystems(string currentFileSystem)
        {
            // Limpiar el ComboBox.
            comboSistemaArchivos.Items.Clear();

            // Agregar el sistema de archivos actual.
            comboSistemaArchivos.Items.Add("(Predeterminado)");

            // Agregar otros sistemas de archivos disponibles.
            comboSistemaArchivos.Items.Add("NTFS");
            comboSistemaArchivos.Items.Add("FAT32");
            comboSistemaArchivos.Items.Add("exFAT");
            // Seleccionar el sistema de archivos actual por defecto.
            comboSistemaArchivos.SelectedItem = currentFileSystem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           DisplayDriveInfo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void comboSistemaArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el sistema de archivos seleccionado.
            string selectedFileSystem = comboSistemaArchivos.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedFileSystem))
            {
                // Cargar los tamaños de asignación correspondientes.
                if(selectedFileSystem == "(Predeterminado)")
                    selectedFileSystem = lblSistemaArchivos.Text;

                if (selectedFileSystem == "NTFS")
                    checkBoxHabilitarCompresion.Enabled = true;
                else
                    checkBoxHabilitarCompresion.Enabled = false;

                CargarTamanosAsignacion();
            }
        }

        private async void btnFormatear_Click(object sender, EventArgs e)
        {
            // Obtener la configuración seleccionada.
            string fileSystem = comboSistemaArchivos.SelectedItem?.ToString();
            string allocationSize = comboBoxTamanoAsignacion.SelectedItem?.ToString()?.Replace(" bytes", "");
            string volumeLabel = txtNombre.Text;
            bool quickFormat = checkBoxFormatoRapido.Checked;

            // Validar la configuración.
            if (string.IsNullOrEmpty(fileSystem) || string.IsNullOrEmpty(allocationSize))
            {
                MessageBox.Show("Selecciona un sistema de archivos y un tamaño de asignación válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar con el usuario antes de formatear.
            DialogResult result = MessageBox.Show(
                $"Tenga en cuenta que al formatear la unidad todos los datos almacenados en ella serán eliminados \n\n" +
                $"¿Estás seguro de que deseas formatear la unidad {_driveLetter}?\n\n" +
                $"Sistema de archivos: {fileSystem}\n" +
                $"Tamaño de asignación: {allocationSize} bytes\n" +
                $"Nombre de la unidad: {volumeLabel}\n" +
                $"Formato rápido: {(quickFormat ? "Sí" : "No")}",
                "Confirmar Formateo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                btnFormatear.Enabled = false;
                btnCerrar.Enabled = false;

                await FormatearUSBAsync(lblLetra.Text, comboSistemaArchivos.SelectedItem.ToString(), txtNombre.Text, comboBoxTamanoAsignacion.SelectedItem.ToString(), checkBoxFormatoRapido.Checked);
                
                btnFormatear.Enabled = true;
                btnCerrar.Enabled = true;
            }
        }

        public async Task FormatearUSBAsync(string letraUnidad, string sistemaArchivos, string etiqueta, string tamanoAsignacion, bool formatoRapido)
        {
            if (string.IsNullOrEmpty(letraUnidad) || string.IsNullOrEmpty(sistemaArchivos) || string.IsNullOrEmpty(etiqueta) || string.IsNullOrEmpty(tamanoAsignacion))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;

            await Task.Run(() =>
            {
                try
                {
                    string quickFormatFlag = formatoRapido ? "/q" : "";
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c format {letraUnidad}: /fs:{sistemaArchivos} /v:{etiqueta} /a:{tamanoAsignacion} {quickFormatFlag} /y",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process { StartInfo = psi })
                    {
                        process.Start();
                        process.WaitForExit();
                    }

                    // Habilitar la compresión si el sistema de archivos es NTFS y el usuario lo seleccionó
                    if (sistemaArchivos.Equals("NTFS", StringComparison.OrdinalIgnoreCase) && checkBoxHabilitarCompresion.Checked)
                    {
                        HabilitarCompresion(letraUnidad);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al formatear la unidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 100;
            MessageBox.Show("Formateo completado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriba el espacio en blanco
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Replace(" ", ""); // Elimina espacios en blanco si se pegan desde el portapapeles
            txtNombre.SelectionStart = txtNombre.Text.Length; // Mantiene el cursor al final del texto
        }

        private void HabilitarCompresion(string letraUnidad)
        {
            try
            {
                string rutaUnidad = $"{letraUnidad}";
                ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c compact /c /s:{rutaUnidad}",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al habilitar la compresión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
