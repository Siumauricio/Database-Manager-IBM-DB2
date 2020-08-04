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
        public CrearProcedimientos() {
            InitializeComponent();
        }

        private void CrearProcedimientos_Load(object sender, EventArgs e) {
            insertarDDL();
        }
       public void insertarDDL() {
            string comando = "\"C:\\Program Files\\IBM\\SQLLIB\\BIN\\DB2CMD.exe\" DB2SETCP.BAT DB2.EXE";
            string crear = "CONNECT TO BOOKS USER DB2ADMIN USING siumauricio";
            //System.Diagnostics.Process.Start(comando, "CREATE");
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();
            string query = @"CREATE OR REPLACE PROCEDURE Prueba ()
	DYNAMIC RESULT SETS 1
    LANGUAGE SQL
P1: BEGIN
	DECLARE cursor1 CURSOR WITH RETURN for
	SELECT NAME FROM SYSIBM.SYSTABLES;
	OPEN cursor1;
END P1";
            using (StreamWriter sw = p.StandardInput) {
                if (sw.BaseStream.CanWrite) {
                    sw.WriteLine(comando + " " + crear +" "+ query);
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
            }
        }

    }
}
