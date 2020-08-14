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
    public partial class CrearForeignKey:Form {
        TreeView arbol;
        public CrearForeignKey(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void CrearForeignKey_Load(object sender, EventArgs e) {
            TreeNodeCollection cl = arbol.SelectedNode.Parent.Nodes [0].Nodes;
            foreach (TreeNode tabla in cl) {
                comboBox1.Items.Add(tabla.Text);
                comboBox3.Items.Add(tabla.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox2.Items.Clear();
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox4.Items.Clear();
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                int posicion = comboBox3.SelectedIndex;
                string nombre_tabla = comboBox3.Items [posicion].ToString();
                DB2Command cmd = new DB2Command(@"SELECT NAME FROM SYSIBM.SYSCOLUMNS WHERE TBNAME = '" + nombre_tabla + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var nombre_campo = buffer ["NAME"].ToString();
                    comboBox4.Items.Add(nombre_campo);
                }
                buffer.Close();
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error\n" + ex.Message);
            }
            connection.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                richTextBox1.Text = "ALTER TABLE " + comboBox1.SelectedItem.ToString() + " ADD CONSTRAINT " + textBox1.Text + " FOREIGN KEY(" + comboBox2.SelectedItem.ToString() + ") REFERENCES " + comboBox3.SelectedItem.ToString() + "(" + comboBox4.SelectedItem.ToString() + ");";
            } catch { }
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("LLave foranea creada correctamente!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error\n" + ex.Message);
            }
            connection.Close();
        }
    }
}
