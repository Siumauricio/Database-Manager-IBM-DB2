using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2.Funciones {
    public partial class ModificarFuncion:Form {
        TreeView arbol;
        public ModificarFuncion(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;

        }

        private void ModificarFuncion_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(@"select text from syscat.routines where routineschema not like 'SYS%'and routineschema='DB2ADMIN' and text not like '%PROCEDURE%' and ROUTINENAME ='" + arbol.SelectedNode.Text + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var function = buffer ["TEXT"].ToString();
                    richTextBox1.Text = function;
                    break;
                }
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al mostrar funcion\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcion Modificada satisfactoriamente!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al Modificar funcion\n" + ex.Message);
            }
        }
    }
}
