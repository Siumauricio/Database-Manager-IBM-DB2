using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2.Procedimientos {
    public partial class CrearProcedimientos:Form {
        TreeView arbol;
        public CrearProcedimientos(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void CrearProcedimientos_Load(object sender, EventArgs e) {
            //insertarDDL();
        }
       public void insertarDDL() {
            //            string comando = "\"C:\\Program Files\\IBM\\SQLLIB\\BIN\\DB2CMD.exe\" DB2SETCP.BAT DB2.EXE";
            //            string crear = "CONNECT TO BOOKS USER DB2ADMIN USING siumauricio";
            //System.Diagnostics.Process.Start(comando, "CREATE");
            //            Process p = new Process();
            //            ProcessStartInfo info = new ProcessStartInfo();
            //            info.FileName = "cmd.exe";
            //            info.RedirectStandardInput = true;
            //            info.UseShellExecute = false;

            //            p.StartInfo = info;
            //            p.Start();
            //            string query = @"CREATE OR REPLACE PROCEDURE Prueba ()
            //	DYNAMIC RESULT SETS 1
            //    LANGUAGE SQL
            //P1: BEGIN
            //	DECLARE cursor1 CURSOR WITH RETURN for
            //	SELECT NAME FROM SYSIBM.SYSTABLES;
            //	OPEN cursor1;
            //END P1";
            //            using (StreamWriter sw = p.StandardInput) {
            //                if (sw.BaseStream.CanWrite) {
            //                    sw.WriteLine(comando + " " + crear +" "+ query);
            //                    //sw.WriteLine(@"CREATE OR REPLACE PROCEDURE Prueba ()

            //    DYNAMIC RESULT SETS 1
            //P1: BEGIN
            //    -- Declare cursor

            //    DECLARE cursor1 CURSOR WITH RETURN for

            //    -- #######################################################################
            //	-- # Replace the SQL statement with your statement.
            //	-- #  Note: Be sure to end statements with the terminator character (usually ';')
            //	-- #
            //	-- # The example SQL statement SELECT NAME FROM SYSIBM.SYSTABLES
            //	-- # returns all names from SYSIBM.SYSTABLES.
            //	-- ######################################################################
            //	SELECT NAME FROM SYSIBM.SYSTABLES;

            //    --Cursor left open for client application

            //   OPEN cursor1;
            //                    END P1");
            //sw.WriteLine("mypassword");
            ///sw.WriteLine("use mydb;");
        }

        public string obtenerQuery() {
            int cantidad = 0;
            string query = "CREATE OR REPLACE PROCEDURE " + textBox1.Text+" (";
            foreach (DataGridViewRow row in contenido.Rows) {
                string modo = "", tipodato = "", nombre = "";
                if (cantidad < (contenido.Rows.Count - 1)) {
                    nombre += row.Cells [0].Value;
                    if (row.Cells[1].Value.ToString()!="NINGUNO") {
                        modo += row.Cells [1].Value;
                    }
                    tipodato += row.Cells [2].Value;
                    query += modo + " " + nombre + " " + tipodato + ",";
                }
                cantidad++;
   
            }
            query = query.Substring(0, query.Length - 1);
            query += ")\n P1:BEGIN \n \n END P1";


            return query;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.Text = obtenerQuery();
           
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Procedimiento creado satisfactoriamente!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al crear procedimiento\n" + ex.Message);
            }
            connection.Close();
        }
    }

}
