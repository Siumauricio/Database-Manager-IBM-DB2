﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;
using IBM.Data.DB2.iSeries;
using Proyecto1_TBD2.Cheks;
using Proyecto1_TBD2.Conexion;
using Proyecto1_TBD2.Funciones;
using Proyecto1_TBD2.Indices;
using Proyecto1_TBD2.Procedimientos;
using Proyecto1_TBD2.Tablas;
using Proyecto1_TBD2.Triggers;
using Proyecto1_TBD2.Vistas;

namespace Proyecto1_TBD2 { 
    public partial class PantallaPrincipal:Form {
        List<ContextMenuStrip> menus = new List<ContextMenuStrip>();

        public PantallaPrincipal() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void n_conexion_Click(object sender, EventArgs e) {
            menus.Add(Tablas);
            menus.Add(Basededatos);
            menus.Add(subMenustablas);
            menus.Add(Indices);
            menus.Add(subMenuIndices);
            menus.Add(Procedimientos);
            menus.Add(subMenuProcedimientos) ;
            menus.Add(Funciones);
            menus.Add(subMenuFunciones);
            menus.Add(Vistas);
            menus.Add(subMenuVistas);
            menus.Add(Triggers);
            menus.Add(subMenuTriggers);
            menus.Add(Checks);
            menus.Add(subMenuChecks);
            IngresarConexion ic = new IngresarConexion(arbol_conexiones, menus);
            ic.Show();
        }
        public void AddConexion(String db) {
            arbol_conexiones.Nodes.Add(db);
        }

        private void añadirTablaToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearTablas ct = new CrearTablas(arbol_conexiones,menus);
            ct.Show();
        }

        private void administrarConexionToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void editarTablaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

   

        private void eliminarTablaToolStripMenuItem_Click_1(object sender, EventArgs e) {
            TreeNode node = arbol_conexiones.SelectedNode;
            DB2Connection connect = obtenerConexion(node.Parent.Parent.Text);
            string query = @"DROP TABLE " + node.Text + " ;";
            try {
                connect.Open();
                DB2Command cmd = new DB2Command(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Su tabla ha sido eliminada correctamente!");
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error al eliminar su tabla!\n" + ex.Message);
            }
            connect.Close();
            arbol_conexiones.SelectedNode.Remove();
        }

        private void modificarTablaToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarTabla mt = new ModificarTabla(arbol_conexiones);
            mt.Show();
        }

        private void verTablaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void eliminarConexionToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = arbol_conexiones.SelectedNode;
            node.Remove();
        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarDatosTabla md = new MostrarDatosTabla(arbol_conexiones);
            md.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
        public DB2Connection obtenerConexion(string usuario) {
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = "db2admin";
            cn.Password = "siumauricio";
            cn.Database = usuario;
            cn.Server = "localhost";
            DB2Connection connect = new DB2Connection(cn.ToString());
            return connect;
        }

        private void crearIndicesToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearIndice cd = new CrearIndice(arbol_conexiones,menus);
            cd.Show();
        }

        private void eliminarIndiceToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                string query = "ALTER TABLE ";
                TreeNode node = arbol_conexiones.SelectedNode;
                DB2Connection connect = obtenerConexion(node.Parent.Parent.Text);
                connect.Open();
                DB2Command cmd = new DB2Command("select tabname from syscat.indexes WHERE TABSCHEMA = 'DB2ADMIN' AND INDNAME ='"+arbol_conexiones.SelectedNode.Text+"' ;", connect);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var palabra = buffer ["TABNAME"].ToString();
                    query += palabra + " DROP CONSTRAINT "+node.Text+";";
                    break;
                }
                buffer.Close();
       
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Su indice ha sido eliminado correctamente!");
                arbol_conexiones.SelectedNode.Remove();
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error al eliminar su indice!\n" + ex.Message);
            }
        }

        private void añadirProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearProcedimientos cp = new CrearProcedimientos(arbol_conexiones);
            cp.Show();
        }

        private void verProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarProcedimiento md = new MostrarProcedimiento(arbol_conexiones);
            md.Show();

        }

        private void modificarProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarProcedimiento md = new ModificarProcedimiento(arbol_conexiones);
            md.Show();
        }

        private void eliminarProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            DB2Connection connection = obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("DROP PROCEDURE "+arbol_conexiones.SelectedNode.Text+";", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Procedimiento Borrado!");
                arbol_conexiones.SelectedNode.Remove();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar procedimiento almacenado!\n"+ex.Message);
            }
            connection.Close();

        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e) {
            IngresarConexion ic = new IngresarConexion(arbol_conexiones, menus);
            string db_antigua = arbol_conexiones.SelectedNode.Text;
            arbol_conexiones.SelectedNode.Remove();
            ic.Refrescar(db_antigua);

        }

        private void agregarProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearFunciones cf = new CrearFunciones(arbol_conexiones);
            cf.Show();
        }

        private void eliminarFuncionToolStripMenuItem_Click(object sender, EventArgs e) {
            DB2Connection connection = obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("DROP FUNCTION " + arbol_conexiones.SelectedNode.Text + ";", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcion Borrada!");
                arbol_conexiones.SelectedNode.Remove();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar funcion!\n" + ex.Message);
            }
            connection.Close();
        }

        private void abrirFuncionToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarFuncion mf = new MostrarFuncion(arbol_conexiones);
            mf.Show();
        }

        private void modificarFuncionToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarFuncion mf = new ModificarFuncion(arbol_conexiones);
            mf.Show();
        }

        private void verVistaToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarVista mt = new MostrarVista(arbol_conexiones);
            mt.Show();
        }

        private void eliminarVistaToolStripMenuItem_Click(object sender, EventArgs e) {
            DB2Connection connection = obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("DROP VIEW " + arbol_conexiones.SelectedNode.Text + ";", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vista Borrada!");
                arbol_conexiones.SelectedNode.Remove();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar Vista           !\n" + ex.Message);
            }
            connection.Close();
        }

        private void agregarVistaToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearVista cv = new CrearVista(arbol_conexiones);
            cv.Show();
        }

        private void modificarVistaToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarVista mf = new ModificarVista(arbol_conexiones);
            mf.Show();
        }

        private void agregarTriggerToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearTriggers ct = new CrearTriggers(arbol_conexiones);
            ct.Show();
        }

        private void verTriggerToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarTriggers mt = new MostrarTriggers(arbol_conexiones);
            mt.Show();
        }

        private void eliminarTriggerToolStripMenuItem_Click(object sender, EventArgs e) {
            DB2Connection connection = obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("DROP TRIGGER " + arbol_conexiones.SelectedNode.Text + ";", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trigger Borrado!");
                arbol_conexiones.SelectedNode.Remove();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar Trigger!\n" + ex.Message);
            }
            connection.Close();
        }

        private void modificarTriggerToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarTrigger mt = new ModificarTrigger(arbol_conexiones);
            mt.Show();
        }

        private void eliminarCheckToolStripMenuItem_Click(object sender, EventArgs e) {
            DB2Connection connection = obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("SELECT TBNAME FROM SYSIBM.SYSCHECKS WHERE TBCREATOR='DB2ADMIN' AND NAME='"+arbol_conexiones.SelectedNode.Text+"'", connection);
                DB2DataReader buffer =  cmd.ExecuteReader();
                
                while (buffer.Read()) {
                    var nombre_tabla = buffer ["TBNAME"].ToString();
                    buffer.Close();
                    cmd.CommandText = "ALTER TABLE " + nombre_tabla + " DROP CHECK " + arbol_conexiones.SelectedNode.Text + ";";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Check Borrado!");
                    arbol_conexiones.SelectedNode.Remove();
                    break;
                }


            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar Check!\n" + ex.Message);
            }
            connection.Close();
        }

        private void agregarCheckToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearChecks ck = new CrearChecks(arbol_conexiones);
            ck.Show();
        }

        private void abrirCheckToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarCheck vc = new MostrarCheck(arbol_conexiones);
            vc.Show();
        }

        private void modificarCheckToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarCheck mc = new ModificarCheck(arbol_conexiones);
            mc.Show();
        }
    }
}
