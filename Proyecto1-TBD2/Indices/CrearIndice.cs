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
    public partial class CrearIndice:Form {
        TreeView arbol;
        List<ContextMenuStrip> subMenus;

        public CrearIndice(TreeView _Arbol, List<ContextMenuStrip> _menus) {
            InitializeComponent();
            arbol = _Arbol;
            subMenus = _menus;
        }

        private void CrearIndice_Load(object sender, EventArgs e) {
            TreeNodeCollection cl = arbol.SelectedNode.Parent.Nodes [0].Nodes;
            foreach (TreeNode tabla in cl) {
                caja.Items.Add(tabla.Text);
            }
        }

        private void caja_SelectedIndexChanged(object sender, EventArgs e) {
            data_set.Rows.Clear();
            Expresion.Items.Clear();

            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                int posicion = caja.SelectedIndex;
                string nombre_tabla = caja.Items [posicion].ToString();
                DB2Command cmd = new DB2Command(@"SELECT NAME FROM SYSIBM.SYSCOLUMNS WHERE TBNAME = '" + nombre_tabla + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var nombre_campo = buffer ["NAME"].ToString();
                    Expresion.Items.Add(nombre_campo);
                }
                buffer.Close();
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error\n" + ex.Message);
            }
            connection.Close();
        }
    
    public string obtenerQuery() {
        string script = "(";
        int cantidad = 0;
            try {
                foreach (DataGridViewRow row in data_set.Rows) {
                string var_name = "";
                if (cantidad < (data_set.Rows.Count - 1)) {
                    if (row.Cells [1].Value.ToString() == "NINGUNO") {
                        var_name += row.Cells [0].Value +",";
                    } else {
                        var_name += row.Cells [0].Value + " " + row.Cells [1].Value+",";
                    }
                    script += var_name;
                }
                cantidad++;
        }
      
            script = script.Substring(0, script.Length - 1);
        } catch (Exception e) {

        }
            script += ")"; 

        return script;
    }

        private void button1_Click(object sender, EventArgs e) {
            string expresiones = obtenerQuery();
            string query = "";
            int posicion = caja.SelectedIndex;
            int posicion2 = caja2.SelectedIndex;
            if (posicion == -1 || posicion2 == -1) {
                MessageBox.Show("Te falta seleccionar correctamente el tipo de indice\n");
                return;
            }
            string nombre_tabla = caja.Items [posicion].ToString();
            string tipo_indice = caja2.Items [posicion2].ToString();
            if (tipo_indice == "NO UNICO") {
                query = "CREATE INDEX " + nombre_indice.Text + " ON " + nombre_tabla + " " + expresiones + ";";
            } else {
                query = "CREATE UNIQUE INDEX " + nombre_indice.Text + " ON " + nombre_tabla + " " + expresiones + ";";
            }
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Indice creado correctamente");
                TreeNode nodo = arbol.SelectedNode.Nodes.Add(nombre_indice.Text);
                nodo.ImageIndex = 3;
                nodo.SelectedImageIndex = 3;
                nodo.ContextMenuStrip = subMenus [4];
                connection.Close();
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al crear el indice\n" + ex.Message);
            }
            connection.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabla.SelectedTab == tabla.TabPages [1]) {
                string expresiones = obtenerQuery();
                string query = "";
                int posicion = caja.SelectedIndex;
                int posicion2 = caja2.SelectedIndex;
                if (posicion == -1 || posicion2 == -1) {
                    MessageBox.Show("Te falta seleccionar correctamente el tipo de indice\n");
                    return;
                }
                string nombre_tabla = caja.Items [posicion].ToString();
                string tipo_indice = caja2.Items [posicion2].ToString();
                if (tipo_indice == "NO UNICO") {
                    query = "CREATE INDEX " + nombre_indice.Text + " ON " + nombre_tabla + " " + expresiones + ";";
                } else {
                    query = "CREATE UNIQUE INDEX " + nombre_indice.Text + " ON " + nombre_tabla + " " + expresiones + ";";
                }
                ddl.Text = query;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in data_set.SelectedRows) {
                if (!item.IsNewRow) {
                    data_set.Rows.Remove(item);
                }
            }
        }
    }
}
