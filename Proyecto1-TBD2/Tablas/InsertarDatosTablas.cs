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
    public partial class InsertarDatosTablas:Form {
        DataGridView data_tablas;
        TreeView arbol_conexiones;
        List<Label> id = new List<Label>();
        List<TextBox> id_caja = new List<TextBox>();
        public InsertarDatosTablas(DataGridView data , TreeView arbol) {
            InitializeComponent();
            data_tablas = data;
            arbol_conexiones = arbol;
        }

        private void InsertarDatosTablas_Load(object sender, EventArgs e) {
            int pointX = 30;
            int pointY = 40;
            panel1.Controls.Clear();
            int i = 0;
            foreach (DataGridViewColumn item in data_tablas.Columns) {
                TextBox box = new TextBox();
                Label a = new Label();
                a.Size = new Size(150, 25);
                a.Text = item.HeaderText;
                a.Location = new Point(pointX+180, pointY);
                box.Location = new Point(pointX+ 370, pointY);
                panel1.Controls.Add(a);
                panel1.Controls.Add(box);
                panel1.Show();
                pointY += 40;
                id.Add(a);
                id_caja.Add(box);
                i++;
            }
            ingresar.Location = new Point(pointX+373,pointY+30);
            panel1.Controls.Add(ingresar);
        }

        private void ingresar_Click(object sender, EventArgs e) {
            string ids = "";
            string values = "";
            for (int i = 0; i < id.Count; i++) {
                if (i < (id.Count-1)) {
                    ids += id [i].Text+",";
                    values += "'"+id_caja [i].Text + "',";
                } else {
                    ids += id [i].Text;
                    values += "'" + id_caja [i].Text+"'" ;
                }
            }
            string query = "INSERT INTO "+arbol_conexiones.SelectedNode.Text+" ("+ ids + ") VALUES ("+values+");";

            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro insertado correctamente");
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error al insertar\n" + ex.Message);
            }
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
