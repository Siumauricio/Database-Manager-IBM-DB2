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
    public partial class CrearTriggers:Form {
        bool canPass = false;
        TreeView arbol;
        string selectedItemText = "";
        int selectedIndex;
        public CrearTriggers(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void button1_Click(object sender, EventArgs e) {
            selectedItemText = listBox1.SelectedItem?.ToString();
            selectedIndex = listBox1.SelectedIndex;
            listBox2.Items.Add(selectedItemText);
            if (listBox1.Items.Count>0) {
                listBox1.Items.RemoveAt(selectedIndex);
                foreach (var item in listBox2.Items) {
                    if (item.ToString() == "UPDATE" && caja.SelectedItem!=null) {
                        button5.Enabled = true;
                        button6.Enabled = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            selectedItemText = listBox2.SelectedItem?.ToString();
            selectedIndex = listBox2.SelectedIndex;
            listBox1.Items.Add(selectedItemText);
            if (listBox2.Items.Count > 0) {
                foreach (var item in listBox1.Items) {
                    if (item.ToString() == "UPDATE" && caja.SelectedItem != null) {
                        button5.Enabled = false;
                        button6.Enabled = false;
                        listBox4.Items.Clear();
                    }
                }
                listBox2.Items.RemoveAt(selectedIndex);
            }
        }

        private void CrearTriggers_Load(object sender, EventArgs e) {
            TreeNodeCollection cl = arbol.SelectedNode.Parent.Nodes [0].Nodes;
            foreach (TreeNode tabla in cl) {
                caja.Items.Add(tabla.Text);
            }
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void caja_SelectedIndexChanged(object sender, EventArgs e) {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
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
                    listBox3.Items.Add(nombre_campo);
                }
                buffer.Close();
            } catch (DB2Exception ex) {
            }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            selectedItemText = listBox3.SelectedItem?.ToString();
            selectedIndex = listBox3.SelectedIndex;
            listBox4.Items.Add(selectedItemText);
            if (listBox3.Items.Count > 0) {
                listBox3.Items.RemoveAt(selectedIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            selectedItemText = listBox4.SelectedItem?.ToString();
            selectedIndex = listBox4.SelectedIndex;
            listBox3.Items.Add(selectedItemText);
            if (listBox4.Items.Count > 0) {
                listBox4.Items.RemoveAt(selectedIndex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            try {
            string metodos = "";
            bool hasUpdate = false;
            for (int i = 0; i < listBox2.Items.Count; i++) {
                if (listBox2.Items [i].ToString() == "UPDATE") {
                    hasUpdate = true;
                }
                if (i != (listBox2.Items.Count - 1)) {
                    metodos += listBox2.Items[i].ToString()+" OR ";
                } else {
                    metodos += listBox2.Items [i].ToString();
                }
            }
            if (!hasUpdate) {
                richTextBox1.Text = "CREATE OR REPLACE  TRIGGER " + textBox1.Text + "\n" + comboBox2.SelectedItem.ToString() + " " + metodos + " ON "+caja.SelectedItem.ToString()+"\nBEGIN\n" + "\nEND";
            } else {
                string parametros = "";

                if (listBox4.Items.Count !=0) {
                    for (int i = 0; i < listBox4.Items.Count; i++) {
                        if (i != (listBox4.Items.Count-1)) {
                            parametros += listBox4.Items [i].ToString() +",";
                        } else {
                            parametros += listBox4.Items [i].ToString();
                        }
                    }
                    richTextBox1.Text = "CREATE OR REPLACE  TRIGGER " + textBox1.Text + "\n" + comboBox2.SelectedItem.ToString() + " " + metodos + " OF " + parametros + " ON " + caja.SelectedItem.ToString() + "\nBEGIN\n" + "\nEND";
                } else {
                    richTextBox1.Text = "CREATE OR REPLACE  TRIGGER " + textBox1.Text + "\n" + comboBox2.SelectedItem.ToString() + " " + metodos +  " ON " + caja.SelectedItem.ToString() + "\nBEGIN\n" + "\nEND";
                }
            }
            } catch  {
            }
         
        }

        private void button2_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trigger Creado correctamente!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error  al crear trigger\n" + ex.Message);
            }catch (Exception ex2) { }
            connection.Close();
        }
    }
}
