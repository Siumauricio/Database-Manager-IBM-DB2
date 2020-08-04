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
    public partial class ModificarCampos:Form {
        DataGridViewRow data_tablas;
        TreeView arbol;
        string nombre_campo;
        public ModificarCampos(DataGridViewRow view, TreeView _arbol) {
            InitializeComponent();
             data_tablas = view;
             arbol = _arbol;
             checkBox1.Checked = false;
             nombre.Text = data_tablas.Cells ["NAME"].Value.ToString();
             nombre_campo = nombre.Text;
             tamano.Text = data_tablas.Cells ["LENGTH"].Value.ToString();
             escala.Text = data_tablas.Cells ["SCALE"].Value.ToString();
            if (data_tablas.Cells ["NULLS"].Value.ToString() == "Y") {
                checkBox2.Checked = true;
            }
            List<string> ls = new List<string>();
            ls.Add("VARCHAR ");
            ls.Add("DECIMAL ");
            ls.Add("INTEGER ");
            ls.Add("DOUBLE ");
                for (int i = 0; i < ls.Count; i++) {
                    dato.Items.Add(ls [i].ToString());
                }
                int x = ls.IndexOf(data_tablas.Cells ["COLTYPE"].Value.ToString());
            if ( x >= 0 ) {
                dato.SelectedIndex = x;
            }
        }

        private void ModificarCampos_Load_1(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);

            try {
                connection.Open();
                DB2Command cmd = new DB2Command("select NAME from SYSIBM.SYSCOLUMNS where tbname = '" + arbol.SelectedNode.Text + "' AND NAME ='" + data_tablas.Cells ["NAME"].Value.ToString() + "' and keyseq > 0 order by keyseq", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                if (buffer.Read()) {
                    checkBox1.Checked = true;
                }

            } catch (DB2Exception ex) {

            }
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button7_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                if (checkBox1.Checked) {
                    DB2Command cmd = new DB2Command("ALTER TABLE " + arbol.SelectedNode.Text + " ADD CONSTRAINT "+ nombre_campo +"_pk ADD PRIMARY KEY ("+nombre_campo +");", connection);
                    cmd.ExecuteNonQuery();
                } else {
                            DB2Command cmd = new DB2Command("ALTER TABLE " + arbol.SelectedNode.Text + " ADD CONSTRAINT " + nombre_campo + "_pk ADD PRIMARY KEY (" + nombre_campo + ");", connection);
                            cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Campo modificado");

            } catch (DB2Exception ex) {
                MessageBox.Show("Error al modificar\n" + ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e) {
            nombre_campo = nombre.Text;
        }
    }
}
