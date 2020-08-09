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
    public partial class MostrarTriggers:Form {
        TreeView arbol;
        public MostrarTriggers(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void MostrarTriggers_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(@"SELECT TEXT FROM SYSCAT.TRIGGERS WHERE TRIGSCHEMA ='DB2ADMIN' AND TRIGNAME= '" + arbol.SelectedNode.Text + "';", connection);//OBTENER TABLAS DE LA BASE DE DATOS
                DB2DataReader bff = cmd.ExecuteReader();
                while (bff.Read()) {
                    var Names = bff ["TEXT"].ToString();
                    richTextBox1.Text = Names;
                    break;
                }
                bff.Close();
            } catch (DB2Exception ex) {

            }

        }
    }
}
