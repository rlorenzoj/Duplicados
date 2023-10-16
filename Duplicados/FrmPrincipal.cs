using Microsoft.VisualBasic.Devices;

namespace Duplicados
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            // Inicializamos todos los campos.
            lblOrigen.Text = string.Empty;
            lblDestino.Text = string.Empty;
            lstDuplicados.Items.Clear();
        }

        private void BtnSeleccionarDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Seleccione el directorio origen de la comparación"
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lblDestino.Text = fbd.SelectedPath;
            }
        }

        private void BtnSeleccionarOrigen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Seleccione el directorio origen de la comparación"
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lblOrigen.Text = fbd.SelectedPath;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblOrigen.Text) && !string.IsNullOrWhiteSpace(lblDestino.Text))
            {
                Cursor.Current = Cursors.WaitCursor;
                lstDuplicados.Items.Clear();
                var ficherosOrigen = new Directorios().Examinar(lblOrigen.Text);
                var ficherosDestino = new Directorios().Examinar(lblDestino.Text);
                if (ficherosOrigen.Count() > 0 && ficherosDestino.Count() > 0)
                {
                    foreach (var ficheroOrigen in ficherosOrigen)
                    {
                        var existentes = ficherosDestino.Where(d => d.Value == ficheroOrigen.Value);
                        if (existentes.Any())
                        {
                            foreach (var existente in existentes)
                            {
                                string[] row = { ficheroOrigen.Key, existente.Key };
                                var listViewItem = new ListViewItem(row);
                                lstDuplicados.Items.Add(listViewItem);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione la carpeta origen y destino de la comparativa.");
            }
            Cursor.Current = Cursors.Default;
        }

        private void lstDuplicados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitInfo = lstDuplicados.HitTest(e.Location);
            if (hitInfo.SubItem == null || string.IsNullOrEmpty(hitInfo.SubItem.Text)) return;

            int subItemIndex = hitInfo.Item.SubItems.IndexOf(hitInfo.SubItem);
            var column = lstDuplicados.Columns[subItemIndex];

            var result = hitInfo.SubItem.Text;
            Clipboard.SetText(result, TextDataFormat.UnicodeText);

            if (subItemIndex > 0)
            {
                if (MessageBox.Show("La ruta completa del fichero ha sido copiada al portapapeles. ¿Desea borrar el archivo?","Borrar archivo duplicado",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(hitInfo.SubItem.Text);
                }
            }
        }
    }
}