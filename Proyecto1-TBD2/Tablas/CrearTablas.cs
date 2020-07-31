using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2.Tablas {
    public partial class CrearTablas:Form {
        TreeView arbol;
        public CrearTablas(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
            contenido.Rows.Add();
        }

        private void CrearTablas_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            contenido.Rows.Add();
        }

        private void button3_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in contenido.SelectedRows) {
                if (!item.IsNewRow) {
                    contenido.Rows.Remove(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            string script = obtenerQuery();
            CrearTabla(script);
        }

        public void CrearTabla(string script) {
            TreeNode node = arbol.SelectedNode;
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = "db2admin";
            cn.Password = "siumauricio";
            cn.Database = node.Parent.Text;
            cn.Server = "localhost";
            DB2Connection connect = new DB2Connection(cn.ToString());
            string query = @"CREATE TABLE " + nombre_tabla.Text +"( "+script+");";
            try {
                connect.Open();
                DB2Command cmd = new DB2Command(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Su tabla ha sido creada correctamente!");
            } catch (DB2Exception e) {
                MessageBox.Show("Ha ocurrido un error al crear su tabla!\n" +e.Message);
            }
        }
        public string obtenerQuery() {
            string script = "";
            foreach (DataGridViewRow row in contenido.Rows) {
                string pk = "", nombre = "", tipo_dato = "", tamano = "", nullo = "";
                for (int i = 0; i < contenido.Columns.Count; i++) {
                    string cellText = "";
                    bool primary = false;
                    bool valor = false;
                    bool isNull = false;
                    String header = contenido.Columns [i].HeaderText;
                    if (i == 0) {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells ["PK"];

                        if (Convert.ToBoolean(cell.Value)) {
                            primary = true;
                        } else {
                            primary = false;
                        }
                    }
                    if (i == 4) {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells ["Nullo"];

                        if (Convert.ToBoolean(cell.Value)) {
                            valor = true;
                        } else {
                            valor = false;
                        }

                    } else {
                        if (row.Cells [i].Value == null) {
                            isNull = true;
                        } else {
                            cellText = row.Cells [i].Value.ToString();
                        }
                    }
                    if (!isNull) {
                        if (header == "PK" && primary) {
                            pk = "PRIMARY KEY";
                        }
                        if (header == "Nombre") {
                            nombre = cellText;
                        }
                        if (header == "Tipo de dato") {
                            tipo_dato = cellText;
                        }
                        if (header == "Tamaño") {
                            tamano = cellText;
                        }
                        if (header == "Nullo") {
                            if (valor) {
                                nullo = "NULL";
                            } else {
                                nullo = "NOT NULL";
                            }
                        }
                    }
                }
                if (tipo_dato == "VARCHAR") {
                    script += nombre + " " + tipo_dato + " (" + tamano + ") " + nullo + " " + pk + ",";
                } else {
                    script += nombre + " " + tipo_dato + " " + nullo + " " + pk + ",";
                }
            }
            string _script = "";
            string [] wordArray = script.Split(',');
            wordArray [0].Insert(0, " \n");
            for (int i = 0; i < wordArray.Length -1; i++) {
                if (i != (wordArray.Length - 2)) {
                    _script += string.Concat(wordArray [i], ",\n");
                } else {
                    _script += wordArray [i];
                }
                

            }
            //script = script.Substring(0, script.Length - 1);
            return _script;
        }

        private void Tabla_SelectedIndexChanged(object sender, EventArgs e) {
            if (Tabla.SelectedTab == Tabla.TabPages [1]){
                string query = @"CREATE TABLE " + nombre_tabla.Text + "(\n" + obtenerQuery() + "\n);";

                caja.Text = query;
            }
        }
    }
}
