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

namespace Proyecto1_TBD2.Indices {
    public partial class ModificarPrimaryKey:Form {
        TreeView arbol;
        public ModificarPrimaryKey(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void ModificarPrimaryKey_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(@"select tab.tabname from syscat.tables tab inner join syscat.tabconst const  on const.tabschema = tab.tabschema  and const.tabname = tab.tabname and const.type = 'P' join syscat.keycoluse key  on const.tabschema = key.tabschema  and const.tabname = key.tabname  and const.constname = '" + arbol.SelectedNode.Text + "' where tab.type = 'T'  and tab.tabschema like 'DB2ADMIN' group by tab.tabschema, const.constname, tab.tabname  order by tab.tabschema, const.constname;", connection);
                DB2DataReader buffer = cmd.ExecuteReader();

                while (buffer.Read()) {
                    var nombre_tabla = buffer ["TABNAME"].ToString();
                    buffer.Close();
                    richTextBox1.Text = "ALTER TABLE " + nombre_tabla + " DROP PRIMARY KEY;";

                    break;
                }

            } catch (DB2Exception ex) {
                MessageBox.Show("Error \n" + ex.Message);
            }
            connection.Close();
            TreeNodeCollection cl = arbol.SelectedNode.Parent.Parent.Parent.Nodes [0].Nodes;
            foreach (TreeNode tabla in cl) {
                comboBox1.Items.Add(tabla.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox2.Items.Clear();
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Parent.Text);
            try {
                connection.Open();
                int posicion = comboBox1.SelectedIndex;
                string nombre_tabla = comboBox1.Items [posicion].ToString();
                DB2Command cmd = new DB2Command(@"SELECT NAME FROM SYSIBM.SYSCOLUMNS WHERE TBNAME = '" + nombre_tabla + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var nombre_campo = buffer ["NAME"].ToString();
                    comboBox2.Items.Add(nombre_campo);
                }
                buffer.Close();
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error\n" + ex.Message);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ejecutado correctamente");
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error\n" + ex.Message);
            }
            connection.Close();
        }
    }
}
