using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form : System.Windows.Forms.Form
    {
        

        public Form()
        {
            InitializeComponent();

            //// 
            //Listas          
            ///
            listMostrarJugador.Visible = false;
            listMostrarJugador.View = View.Details;
            listMostrarJugador.FullRowSelect = true;

            listMostrarJugador.Columns.Add("Nom : ", 150);
            listMostrarJugador.Columns.Add("Apellido : ", 150);

            listLiga.Visible = false;
            listLiga.View = View.Details;
            listLiga.FullRowSelect = true;

            listLiga.Columns.Add("Nom Jugador 1 ", 150);
            listLiga.Columns.Add("Apellido Jugador 1 ", 150);
            listLiga.Columns.Add("puntos jugador 1 ", 150);
            listLiga.Columns.Add("puntos jugador 2 ", 150);
            listLiga.Columns.Add("Nom Jugador 2 ", 150);
            listLiga.Columns.Add("Apellido Jugador 2 ", 150);

            listResultado.Visible = false;
            listResultado.View = View.Details;
            listResultado.FullRowSelect = true;
        }

        private List<Jugador> listaJugadors = new List<Jugador>();
        private List<Partidas> listaPartidas = new List<Partidas>();  

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tBnomJugador.Text != "")
            {
                Jugador j = new Jugador();
                j.Nom = tBnomJugador.Text;
                if (tBapellido.Text != "")
                {
                    j.Apellido = tBapellido.Text;
                }

                tBnomJugador.Text = null;
                tBapellido.Text = null;
                listaJugadors.Add(j);
                bMostrarJ.Enabled = true;
            }
            else
            {
                MessageBox.Show("Escribe el nom del jugador");
            }
        }

        private void bMostrarJ_Click(object sender, EventArgs e)
        {
            labelPuntos1.Enabled = false;
            tbPuntosJugador1.Enabled = false;
            labPuntos2.Enabled = false;
            tbPuntosJugador2.Enabled = false;
            btAplicar.Enabled = false;

            listLiga.Visible = false;
            listMostrarJugador.Visible = true;
            if (listaJugadors.Count > 0)
            {
                LabNomJugador.Enabled = false;
                Lapellido.Enabled = false;
                tBnomJugador.Enabled = false;
                tBapellido.Enabled = false;
                btSave.Enabled = false;
                listMostrarJugador.Items.Clear();
                foreach (Jugador jugador in listaJugadors)
                {
                    string[] fila = { jugador.Nom, jugador.Apellido };
                    ListViewItem item = new ListViewItem(fila);
                    listMostrarJugador.Items.Add(item);
                }
                bempezarLiga.Visible = true;
            }
            else { MessageBox.Show("Pero Si No Hay jugadores, idiota, que quieres que te muestre  !!!!!"); }
        }

        private void bempezarLiga_Click(object sender, EventArgs e)
        {
            btEliminar.Enabled = false;
            btModificar.Enabled = false;
            btAplicar.Enabled = false;

            int TotalJugadores = listaJugadors.Count;
            if (TotalJugadores % 2 == 0)
            {
                listMostrarJugador.Visible = false;
                listLiga.Visible = true;
                listaPartidas.Clear();
                for (int i = 0; i < listaJugadors.Count; i++)
                {
                    for (int j = i + 1; j < listaJugadors.Count; j++)
                    {
                        Partidas par = new Partidas();
                        par.NomJugador1 = listaJugadors[i].Nom;
                        par.ApellidoJugador1 = listaJugadors[i].Apellido;
                        par.NomJugador2 = listaJugadors[j].Nom;
                        par.ApellidoJugador2 = listaJugadors[j].Apellido;
                        listaPartidas.Add(par);
                    }
                }
                listLiga.Items.Clear();
                foreach (Partidas par in listaPartidas)
                {
                    string[] fila = { par.NomJugador1, par.ApellidoJugador1, par.resultado1.ToString(),par.resultado2.ToString(), par.NomJugador2, par.ApellidoJugador2 };
                    ListViewItem item = new ListViewItem(fila);
                    listLiga.Items.Add(item);
                }
                buResultado.Enabled = true;
            }
            else
            {
                MessageBox.Show("el numero Total de jugadores tiene que ser parell");
                LabNomJugador.Enabled = true;
                Lapellido.Enabled = true;
                tBnomJugador.Enabled = true;
                tBapellido.Enabled = true;
                btSave.Enabled = true;
            }
                        
        }

        private void ListMostrarJugador_MouseClick(object sender, MouseEventArgs e)
        {
            btModificar.Enabled = true;
            btEliminar.Enabled = true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (listMostrarJugador.Items.Count > 0)
            {
                if (MessageBox.Show("Estas Segur que vols eliminar ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    foreach (Jugador jug in listaJugadors)
                    {
                        if (jug.Nom.Equals(listMostrarJugador.SelectedItems[0].SubItems[0].Text) &&
                        jug.Apellido.Equals(listMostrarJugador.SelectedItems[0].SubItems[1].Text))
                        {
                            listaJugadors.Remove(jug);
                        }
                    }
                    listMostrarJugador.Items.RemoveAt(listMostrarJugador.SelectedIndices[0]);
                }
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            btEliminar.Enabled = false;
            LabNomJugador.Enabled = true;
            Lapellido.Enabled = true;
            tBnomJugador.Enabled = true;
            tBapellido.Enabled = true;
            btAplicar.Enabled = true;
        }

        private void btAplicar_Click(object sender, EventArgs e)
        {
            if (labelPuntos1.Enabled == true && labPuntos2.Enabled == true)
            {
                listLiga.SelectedItems[0].SubItems[2].Text = tbPuntosJugador1.Text;
                listLiga.SelectedItems[0].SubItems[3].Text = tbPuntosJugador2.Text;
                
                
                foreach (Partidas par in listaPartidas)
                {
                    if (par.NomJugador1.Equals(listLiga.SelectedItems[0].SubItems[0].Text) && 
                        par.ApellidoJugador1.Equals(listLiga.SelectedItems[0].SubItems[1].Text) &&
                        par.NomJugador2.Equals(listLiga.SelectedItems[0].SubItems[4].Text) &&
                        par.ApellidoJugador2.Equals(listLiga.SelectedItems[0].SubItems[5].Text)
                        )
                    {
                        par.resultado1 = Int32.Parse(tbPuntosJugador1.Text);
                        par.resultado2 = Int32.Parse(tbPuntosJugador2.Text);
                    }
                }
                
                
                tbPuntosJugador1.Text = null;
                tbPuntosJugador2.Text = null;
                labelPuntos1.Enabled = false;
                tbPuntosJugador1.Enabled = false;
                labPuntos2.Enabled = false;
                tbPuntosJugador2.Enabled = false;
                btAplicar.Enabled = false;
            }
            else
            {
                foreach (Jugador jug in listaJugadors)
                {
                    if (jug.Nom.Equals(listMostrarJugador.SelectedItems[0].SubItems[0].Text) && 
                        jug.Apellido.Equals(listMostrarJugador.SelectedItems[0].SubItems[1].Text))
                    {
                        jug.Nom = tBnomJugador.Text;
                        jug.Apellido = tBapellido.Text;
                    }
                }
                listMostrarJugador.SelectedItems[0].SubItems[0].Text = tBnomJugador.Text;
                listMostrarJugador.SelectedItems[0].SubItems[1].Text = tBapellido.Text;
                
                tBnomJugador.Text = null;
                tBapellido.Text = null;
                LabNomJugador.Enabled = false;
                Lapellido.Enabled = false;
                tBnomJugador.Enabled = false;
                tBapellido.Enabled = false;
                btModificar.Enabled = false;
                btAplicar.Enabled = false;
            }
        }

        private void ListLiga_MouseClick(object sender, MouseEventArgs e)
        {

            labelPuntos1.Enabled = true;
            tbPuntosJugador1.Enabled = true;
            labPuntos2.Enabled = true;
            tbPuntosJugador2.Enabled = true;
            btAplicar.Enabled = true;
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            listResultado.Visible = true;
            listResultado.Items.Clear();
            for (int i = 0; i < listLiga.Items.Count; i++)
            {
                if (Int32.Parse(listLiga.Items[i].SubItems[2].Text) > Int32.Parse(listLiga.Items[i].SubItems[3].Text))
                {
                    foreach (Jugador jug in listaJugadors)
                    {
                        if (jug.Nom.Equals(listLiga.Items[i].SubItems[0].Text) && jug.Apellido.Equals(listLiga.Items[i].SubItems[1].Text))
                        {
                            jug.Puntos = jug.Puntos + 3;
                            string[] linea = { jug.Nom + " " + jug.Apellido, jug.Puntos.ToString() };
                            ListViewItem listItem = new ListViewItem(linea);
                            listResultado.Items.Add(listItem);
                        }
                    }
                }
                else if (Int32.Parse(listLiga.Items[i].SubItems[2].Text) < Int32.Parse(listLiga.Items[i].SubItems[3].Text))
                {
                    foreach (Jugador jug in listaJugadors)
                    {
                        if (jug.Nom.Equals(listLiga.Items[i].SubItems[4].Text) && jug.Apellido.Equals(listLiga.Items[i].SubItems[5].Text))
                        {
                            jug.Puntos = jug.Puntos + 3;
                            string[] linea = { jug.Nom + " " + jug.Apellido, jug.Puntos.ToString() };
                            ListViewItem listItem = new ListViewItem(linea);
                            listResultado.Items.Add(listItem);
                        }   
                    }
                }
            }
            int max = Int32.Parse(listResultado.Items[0].SubItems[1].Text);
            string jugador = null;
            for (int i = 0; i < listResultado.Items.Count; i++)
            {
                if (Int32.Parse(listResultado.Items[i].SubItems[1].Text) > max)
                {
                    max = Int32.Parse(listResultado.Items[i].SubItems[1].Text);
                    jugador = listResultado.Items[i].SubItems[0].Text;
                }
            }

            listResultado.Items.Clear();
            string[] fila = { jugador, max.ToString() };
            ListViewItem item = new ListViewItem(fila);
            listResultado.Items.Add(item);
        }
    }
}
