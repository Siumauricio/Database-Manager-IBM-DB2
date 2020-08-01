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
            connect.Close();
        }
        public string obtenerQuery() {
            string script = "";
            int cantidad = 0;
            foreach (DataGridViewRow row in contenido.Rows) {
                string pk = "", checkPK = "", nombre = "", tipo_dato = "", tamano = "", escala = "", nullo = "NOT NULL", checkNull = "";
                if (cantidad < (contenido.Rows.Count -1)) {
                    checkPK += row.Cells [0].Value;
                    if (checkPK == "True") {
                        pk = "PRIMARY KEY";
                    }
                    nombre += row.Cells [1].Value;
                    tipo_dato += row.Cells [2].Value;
                    tamano += row.Cells [3].Value;
                    escala += row.Cells [4].Value;
                    checkNull += row.Cells [5].Value;

                    if (checkNull == "True") {
                        nullo = "NULL";
                    }
                }
                if (tipo_dato == "VARCHAR") {
                   script += nombre + " " + tipo_dato + " (" + tamano + ") " + nullo + " " + pk + ",\n";
                }else if(tipo_dato == "INT" || tipo_dato == "BOOLEAN" || tipo_dato == "DOUBLE") {
                    script += nombre + " " + tipo_dato + " " + nullo + " " + pk + ",\n";
                }else if(tipo_dato == "DECIMAL" ) {
                    script += nombre + " " + tipo_dato + " (" + tamano +","+escala+ ") " + nullo + " " + pk + ",\n";
                }
                cantidad++;
            }
            try {
                script = script.Substring(0, script.Length -2);
            } catch (ArgumentOutOfRangeException e) {
                
            }

            return script;
        }

        private void Tabla_SelectedIndexChanged(object sender, EventArgs e) {
            if (Tabla.SelectedTab == Tabla.TabPages [1]){
                string query = @"CREATE TABLE " + nombre_tabla.Text + "(\n" + obtenerQuery() + "\n);";
                caja.Text = query;
            }
        }

        private void contenido_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e) {
           e.Row.Cells [0].Value = false;
           e.Row.Cells [4].Value = "0";
           e.Row.Cells [5].Value = false;
        }
    }
}
