using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Listas_Circulares
{
    public partial class frmRoute : Form
    {
        Base base1;
        Route route = new Route();

        public frmRoute() => InitializeComponent();

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                base1 = new Base(txtName.Text, Convert.ToInt32(txtDuration.Text));
                route.Agregar(base1);
                clear();
                txtName.Focus();
            }
            catch (Exception nel)
            {
                MessageBox.Show(nel.Message);
            }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutcome.Text = route.Buscar(txtName.Text).ToString();
                clear();
            }
            catch (Exception nel)
            {
                txtOutcome.Clear();
                MessageBox.Show(nel.Message);
            }
        }

        private void clear()
        {
            txtDuration.Clear();
            txtName.Clear();
        }

        private void bttnRemoveLast_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutcome.Text = route.eliminarUltimo().ToString();
            }
            catch(Exception nel)
            {
                txtOutcome.Clear();
                MessageBox.Show(nel.Message);
            }
        }

        private void bttnRemoveFirst_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutcome.Text = route.eliminarPrimero().ToString();
            }
            catch (Exception nel)
            {
                txtOutcome.Clear();
                MessageBox.Show(nel.Message);
            }
        }

        private void bttnList_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutcome.Text = route.Listar();
            }
            catch (Exception nel)
            {
                txtOutcome.Clear();
                MessageBox.Show(nel.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutcome.Clear();
                txtOutcome.Text = route.ruta(txtBaseInicio.Text, horaInicio.Value, horaFin.Value);
            }
            catch (KeyNotFoundException)
            {
                txtOutcome.Text = "Base no encontrada";
            }
        }
    }
}
