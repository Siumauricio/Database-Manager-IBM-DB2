using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Proyecto1_TBD2.Tablas {
    public partial class MostrarDatosTabla:Form {
        TreeView arbol_conexiones;
        string PK = "";
        string dato_antiguo = "";
        string nombre_llave = "";
        string query_ = "";
        public MostrarDatosTabla(TreeView _arbol_conexiones) {
            InitializeComponent();
            arbol_conexiones = _arbol_conexiones;
        }
        DataTable table = new DataTable();
        private void MostrarDatosTabla_Load(object sender, EventArgs e) {
                if (arbol_conexiones.SelectedNode == null || arbol_conexiones.SelectedNode.Parent == null) {
                    Hide();
                    return;
                    
                }
                tabla_name.Text = "DATOS DE TABLA : " + arbol_conexiones.SelectedNode.Text;
                PantallaPrincipal pn = new PantallaPrincipal();
                DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
                try {
                    connection.Open();
                    DB2Command cmd = new DB2Command();
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM " + arbol_conexiones.SelectedNode.Text + ";";
                    //DB2DataReader buffer = cmd.ExecuteReader();
                    DB2DataAdapter adapter = new DB2DataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    data_tablas.DataSource = tabla;
                    //Extraer nombre de columnas de la tabla seleccionada y asignarlas al DATAGRIDVIEW
                    //List<string> nombre_col = new List<string>();
                    //    while (buffer.Read()) {
                    //        var Names = buffer ["NAME"].ToString();
                    //        nombre_col.Add(Names);
                    //    }
                    //    data_tablas.ColumnCount = nombre_col.Count;
                    //    for (int i = 0; i < nombre_col.Count; i++) {
                    //        data_tablas.Columns [i].Name = nombre_col [i];

                    //    }
                    //    buffer.Close();
                    //    cmd.CommandText = @"SELECT * FROM " + arbol_conexiones.SelectedNode.Text;
                    //    buffer = cmd.ExecuteReader();
                    //    //Asignar los datos de la tabla seleccionada al datagridview en sus filas
                    //    while (buffer.Read()) {
                    //        int cant_filas = data_tablas.Rows.Add();
                    //        for (int i = 0; i < nombre_col.Count; i++) {
                    //            var data = buffer [nombre_col [i]].ToString();
                    //            data_tablas.Rows [cant_filas].Cells [i].Value = data;
                    //        }
                    //    }
                    //    buffer.Close();

                } catch (DB2Exception ex) {

                }
                //    connection.Close();
                //} catch (Exception ex) {

                //}
            }
        
        private void data_tablas_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
                int? rowIdx = e?.RowIndex;
                int? colIdx = e?.ColumnIndex;
                if (rowIdx.HasValue && colIdx.HasValue) {
                    var dgv = (DataGridView)sender;
                    var cell = dgv?.Rows? [rowIdx.Value]?.Cells? [colIdx.Value]?.Value;
                    if (!string.IsNullOrEmpty(cell?.ToString())) {
                        PantallaPrincipal pn = new PantallaPrincipal();
                        DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
                        try {
                            connection.Open();
                            string nombre_Columna = data_tablas.Columns [e.ColumnIndex].HeaderText;
                            DB2Command cmd = new DB2Command("UPDATE "+ arbol_conexiones.SelectedNode.Text +" SET "+ ""+ nombre_Columna+"='"+cell+"' " + query_+";",connection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tabla modificada correctamente\n"+cmd.CommandText);
                        } catch (DB2Exception ex) {
                            MessageBox.Show("Error al modificar su tabla\n"+ex.Message);
                            dgv.Rows [rowIdx.Value].Cells [colIdx.Value].Value = dato_antiguo;
                        }
                    };
                };
        }

        private void data_tablas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection cn = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                cn.Open();
                string llave = "";
                DB2Command cmd = new DB2Command(@"SELECT COLNAMES FROM sysibm.sysindexes WHERE TBNAME = '"+ arbol_conexiones.SelectedNode.Text + "'", cn);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                     llave = buffer ["COLNAMES"].ToString();
                }
                string [] pk = llave.Split('+');
                string [] where = new string [pk.Length];
                string texto = "";

                if (data_tablas.Rows[e.RowIndex].Cells[pk[1]].Value != null ) {
                    for (int i = 1; i < pk.Length; i++) {
                        string query_builder = "";
                        if (i == 1) {
                            PK = data_tablas.Rows [e.RowIndex].Cells [pk [i]].Value.ToString();
                            query_builder = "WHERE  " + pk [i] + "=" + "'" + PK + "' ";
                            where [i] = query_builder;
                        } else {
                            PK = data_tablas.Rows [e.RowIndex].Cells [pk [i]].Value.ToString();
                            query_builder = pk [i] + "=" + "'" + PK + "' ";
                            where [i] = query_builder;
                        }
                    }
                    for (int i = 1; i < where.Length; i++) {
                        if (i < (where.Length - 1)) {
                            texto += where [i] + " AND ";
                        } else {
                            texto += where [i];
                        }
                    }

                    query_ = texto;
                    dato_antiguo = data_tablas [e.ColumnIndex, e.RowIndex].Value.ToString();
                    nombre_llave = pk [1];
                    buffer.Close();
                }

            } catch (DB2Exception ex) {
                MessageBox.Show("Ha Ocurrido un error\n\n" + ex.Message);
            }
            cn.Close();
        }
        string eliminar = "";
        private void button1_Click(object sender, EventArgs e) {
            if (data_tablas.Rows.Count == 0 || data_tablas.Rows[data_tablas.CurrentRow.Index].IsNewRow) {
                return; 
            }
            if (data_tablas.CurrentRow.Selected) {
                PantallaPrincipal pn = new PantallaPrincipal();
                DB2Connection cn = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
                try {
                    cn.Open();
                    string llave = "";
                    DB2Command cmd = new DB2Command(@"SELECT COLNAMES FROM sysibm.sysindexes WHERE TBNAME = '" + arbol_conexiones.SelectedNode.Text + "'", cn);
                    DB2DataReader buffer = cmd.ExecuteReader();
                    while (buffer.Read()) {
                        llave = buffer ["COLNAMES"].ToString();
                    }
                    string [] pk = llave.Split('+');
                    string [] where = new string [pk.Length];
                    string texto = "";
                    if (data_tablas.Rows [data_tablas.CurrentRow.Index].Cells [pk [1]].Value != null) {

                        for (int i = 1; i < pk.Length; i++) {
                            string query_builder = "";
                            if (i == 1) {
                                PK = data_tablas.Rows [data_tablas.CurrentRow.Index].Cells [pk [i]].Value.ToString();
                                query_builder = "WHERE  " + pk [i] + "=" + "'" + PK + "' ";
                                where [i] = query_builder;
                            } else {
                                PK = data_tablas.Rows [data_tablas.CurrentRow.Index].Cells [pk [i]].Value.ToString();
                                query_builder = pk [i] + "=" + "'" + PK + "' ";
                                where [i] = query_builder;
                            }
                        }
                        for (int i = 1; i < where.Length; i++) {
                            if (i < (where.Length - 1)) {
                                texto += where [i] + " AND ";
                            } else {
                                texto += where [i];
                            }
                        }
                        buffer.Close();
                        cmd.CommandText = "DELETE FROM " + arbol_conexiones.SelectedNode.Text + " " + texto;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro borrado correctamente");
                        foreach (DataGridViewRow item in data_tablas.SelectedRows) {
                            data_tablas.Rows.RemoveAt(item.Index);
                        }
                    }
                } catch (DB2Exception ex) {
                    MessageBox.Show("Fallo al borrar este registro\n"+ex.Message);

                }
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
           InsertarDatosTablas idt = new InsertarDatosTablas(data_tablas,arbol_conexiones);
           idt.Show();
            
        }
    }
}
