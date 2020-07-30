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
        public CrearTablas() {
            InitializeComponent();
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
    }
}
