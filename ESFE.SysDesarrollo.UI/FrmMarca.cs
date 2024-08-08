using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESFE.SysDesarrollo.EN;
using ESFE.SysDesarrollo.LN;


namespace ESFE.SysDesarrollo.UI
{
    public partial class FrmMarca : Form
    {
        private MarcaBL _marcaBL;
        public FrmMarca()
        {
            InitializeComponent();
            _marcaBL = new MarcaBL();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescrip.Text,
                RegMarca = int.Parse(txtRegMar.Text)
            };
            int resultado = _marcaBL.InsertarMarca(nuevaMarca);

            if (resultado < 0)
            {
                MessageBox.Show("Marca insertada correctamente. ");
            }
            else
            {
                MessageBox.Show("Error al insertar marca. ");
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            List<Marca> marcas = _marcaBL.ObtenerMarcas();
            DataGV.DataSource = marcas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            List<Marca> marcas = _marcaBL.ObtenerMarcaNombre(nombre);
            DataGV.DataSource = marcas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Marca marcaActualizada = new Marca
            {
                IdMarca = int.Parse(txtNumID.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescrip.Text,
                RegMarca = int.Parse(txtRegMar.Text)
            };

            int Resultado = _marcaBL.ActualizarMarca(marcaActualizada);

            if (Resultado < 0 )
            {
                MessageBox.Show("Marca actualizada correctamente. ");
            }
            else
            {
                MessageBox.Show("Error al actualizar la marca");
            }

            List<Marca> marcas = _marcaBL.ObtenerMarcas();
            DataGV.DataSource = marcas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdMarca = Convert.ToInt32(txtNumID.Text);
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                using (SqlCommand _command = new SqlCommand("EliminarMarca", _conn as SqlConnection))
                {
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@IdMarca", IdMarca);

                    int resultado = _command.ExecuteNonQuery();
                    MessageBox.Show($"{resultado} registro(s) eliminado(s),");
                }
            }

            List<Marca> marcas = _marcaBL.ObtenerMarcas();
            DataGV.DataSource = marcas;
        }

        private void DataGV_SelectionChanged(object sender, EventArgs e)
        {
            txtNumID.Text = Convert.ToString(DataGV.CurrentRow.Cells["IdMarca" +
                ""].Value);
            txtNombre.Text = Convert.ToString(DataGV.CurrentRow.Cells["Nombre"].Value);
            txtDescrip.Text = Convert.ToString(DataGV.CurrentRow.Cells["Descripcion"].Value);
            txtRegMar.Text = Convert.ToString(DataGV.CurrentRow.Cells["RegMarca"].Value);
        }
    }
}


