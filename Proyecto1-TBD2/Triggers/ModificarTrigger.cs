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

namespace Proyecto1_TBD2.Triggers {
    public partial class ModificarTrigger:Form {
        TreeView arbol;
        public ModificarTrigger(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void ModificarTrigger_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            try {
                DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
                connection.Open();
                DB2Command cmd = new DB2Command(@"SELECT TEXT FROM SYSCAT.TRIGGERS WHERE TRIGSCHEMA ='DB2ADMIN' AND TRIGNAME= '" + arbol.SelectedNode.Text + "';", connection);//OBTENER TABLAS DE LA BASE DE DATOS
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var function = buffer ["TEXT"].ToString();
                    richTextBox1.Text = function;
                    break;
                }
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al mostrar Vista\n" + ex.Message);
            } catch (Exception ex2) { }
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            try {
                DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show  ("Modificacion correcta!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al modificar Trigger\n" + ex.Message);
            } catch (Exception ex2) { }
        }
    }
}
