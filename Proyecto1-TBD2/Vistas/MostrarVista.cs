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

namespace Proyecto1_TBD2.Vistas {
    public partial class MostrarVista:Form {
        TreeView arbol;
        public MostrarVista(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void MostrarVista_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            try {
                DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
                connection.Open();
                DB2Command cmd = new DB2Command(@"select TEXT from SYSIBM.SYSVIEWS WHERE CREATOR='DB2ADMIN' and NAME='" + arbol.SelectedNode.Text + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var function = buffer ["TEXT"].ToString();
                    richTextBox1.Text = function;
                    break;
                }
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al mostrar Vista\n" + ex.Message);
            }catch(Exception ex2) { }
        }
    }
}
