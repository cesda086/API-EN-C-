using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpresa.DAL;
using AdminEmpresa.BLL;

namespace AdminEmpresa.PL
{
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            // INTRUCCION GUI(OBTENER INFORMACION)
            RecuperarInformacion();
            conexionDAL conexion = new conexionDAL();
            
            MessageBox.Show("CONECTADO ...."+ conexion.Pruebaconectar("INSERT INTO Departamentos (departamento) VALUES('sistemas')"));
        }
        private void RecuperarInformacion()
        {
            DepartamentBLL oDepartamento = new DepartamentBLL();
            int ID = 0; int.TryParse(txtID_Departamento.Text, out ID);
            oDepartamento.ID = ID;
            oDepartamento.Departamento = txtNombreDepartamento.Text;
            MessageBox.Show(oDepartamento.ID.ToString());
            MessageBox.Show(oDepartamento.Departamento);

        }
    }
}
