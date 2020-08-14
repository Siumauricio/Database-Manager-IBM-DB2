using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Proyecto1_TBD2.Tablas {
    public partial class MostrarDatosTabla:Form {
        TreeView arbol_conexiones;
        DataTable ds;
        DB2DataAdapter adapter;
        public MostrarDatosTabla(TreeView _arbol_conexiones) {
            InitializeComponent();
            arbol_conexiones = _arbol_conexiones;
        }

        private void MostrarDatosTabla_Load(object sender, EventArgs e) {
            try {
                tabla_name.Text = "DATOS DE TABLA : " + arbol_conexiones.SelectedNode.Text;
                PantallaPrincipal pn = new PantallaPrincipal();
                DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);

                connection.Open();
                DB2Command cmd = new DB2Command(@"SELECT * FROM " + arbol_conexiones.SelectedNode.Text + "; ",connection);
                adapter = new DB2DataAdapter(cmd);
                ds = new DataTable();
                adapter.Fill(ds);
                data_tablas.DataSource = ds;
                connection.Close();

            } catch (DB2Exception ex) { } catch { }

        }
        
        private void data_tablas_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
               
        }

        private void data_tablas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
           
        }
        private void button1_Click(object sender, EventArgs e) {
          
        }

        private void button2_Click(object sender, EventArgs e) {
           InsertarDatosTablas idt = new InsertarDatosTablas(data_tablas,arbol_conexiones);
           idt.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                DB2CommandBuilder cmb = new DB2CommandBuilder(adapter);
                adapter.Update(ds);
                MessageBox.Show("Tabla Actualizada Correctamente");
            } catch {

            }
        }
    }
}
