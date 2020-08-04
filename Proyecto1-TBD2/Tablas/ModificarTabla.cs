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

namespace Proyecto1_TBD2.Tablas {
    public partial class ModificarTabla:Form {
        TreeView arbol;
        string nombre_Tabla;
        public ModificarTabla( TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void ModificarTabla_Load(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("SELECT NAME, COLTYPE, LENGTH, SCALE, NULLS FROM SYSIBM.SYSCOLUMNS WHERE TBNAME = '"+arbol.SelectedNode.Text+"';",connection);
                DB2DataAdapter data = new DB2DataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                data_tablas.DataSource = tabla;
                textBox1.Text = arbol.SelectedNode.Text;
                nombre_Tabla = textBox1.Text;
            } catch (DB2Exception ex) {

            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            ModificarCampos mc = new ModificarCampos(data_tablas.CurrentRow, arbol);
            mc.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("RENAME TABLE " + nombre_Tabla +" TO "+textBox1.Text+";", connection);
                cmd.ExecuteNonQuery();
                nombre_Tabla = textBox1.Text;
                MessageBox.Show("Tabla modificada correctamente");
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al modificar tabla\n"+ex.Message);

            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("ALTER TABLE " + nombre_Tabla + " DROP COLUMN "+data_tablas.CurrentRow.Cells["NAME"].Value.ToString()+";", connection);
                cmd.ExecuteNonQuery();
                nombre_Tabla = textBox1.Text;
                data_tablas.Rows.Remove(data_tablas.CurrentRow);
                MessageBox.Show("Campo Borradp correctamente");
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar campo\n" + ex.Message);

            }
            connection.Close();
        }
    }
}
