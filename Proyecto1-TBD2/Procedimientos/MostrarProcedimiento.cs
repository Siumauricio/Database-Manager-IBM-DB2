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

namespace Proyecto1_TBD2.Procedimientos {
    public partial class MostrarProcedimiento:Form {
        TreeView arbol;
        public MostrarProcedimiento(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void MostrarProcedimiento_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("SELECT ROUTINE_DEFINITION FROM SYSIBM.ROUTINES WHERE SPECIFIC_SCHEMA = 'DB2ADMIN' AND ROUTINE_NAME ='"+arbol.SelectedNode.Text.ToUpper() +"';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var texto = buffer ["ROUTINE_DEFINITION"].ToString();
                    richTextBox1.Text = texto;
                }
                buffer.Close();
            } catch (DB2Exception ex) {

            }
            connection.Close();
        }
    }
}
