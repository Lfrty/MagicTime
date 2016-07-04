using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Magic
{
    public partial class form_Principal : Form
    {
        string[] nombres = { "Avacyn_Restored", "Return_to_Ravnica"};
        static ListaCartas c;
        static List<Carta> lista;
        string[] costesIncoloros = { "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}", "{7}", "{8}", "{9}" };
        string[] colores = { "{B}", "{U}", "{W}", "{G}", "{R}" };
        string[] nombreImg = { "negro", "azul", "blanco", "verde", "rojo" };
        string[] nombreImgIncoloros = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        daoMagic d = new daoMagic();
        List<PictureBox> listaImagenesMana = new List<PictureBox>();
        string cartaSeleccionada = "";
        string edicionSeleccionada = "";
        bool conectado = false;
        int numBorrar = 0;

        public form_Principal()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            try
            {
                c = new ListaCartas();
                PintaColeccionesLista();
                conectado=d.Conectar();
                ActualizaInfoConexion();
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE CARGA");
                throw;
            }
        }

        private void ActualizaInfoConexion()
        {
            if (conectado)
            {
                lbl_InfoConectado.Text = "CONECTADO";
                lbl_InfoConectado.BackColor = Color.Green;
            }
            else
            {
                lbl_InfoConectado.Text = "DESCONECTADO";
                lbl_InfoConectado.BackColor = Color.Red;
            }
        }

        private void PintaColeccionesLista()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                lBox_Ediciones.Items.Add(nombres[i]);
            }
        }

        private void PintaListaInfoCartas()
        {
            lBox_ListaCartasDesdeBD.Items.Clear();
            foreach (Carta item in lista)
            {
                lBox_ListaCartasDesdeBD.Items.Add(item.Nombre);
            }
        }


        private void MuestraDatosCarta(string carta)
        {
                string coste = "";

                foreach (Carta item in lista)
                {
                    if (carta == item.Nombre)
                    {
                        tBox_Nombre.Text = item.Nombre;
                        coste = item.Coste;
                        tBox_Texto.Text = item.Texto;
                        tBox_tipo.Text = item.Tipo;

                        if (coste.Contains("{R}"))
                        {
                            this.BackgroundImage = Image.FromFile(@"Imagenes/FondosTexto/montanya.jpg");
                        }

                        else if (coste.Contains("{G}"))
                        {
                            this.BackgroundImage = Image.FromFile(@"Imagenes/FondosTexto/bosque.jpg");
                        }
                        else if (coste.Contains("{U}"))
                        {
                            this.BackgroundImage = Image.FromFile(@"Imagenes/FondosTexto/isla.jpg");
                        }
                        else if (coste.Contains("{B}"))
                        {
                            this.BackgroundImage = Image.FromFile(@"Imagenes/FondosTexto/pantano.jpg");
                        }
                        else
                        {
                            this.BackgroundImage = Image.FromFile(@"Imagenes/FondosTexto/llanura.jpg");
                        }
                        PintaCoste(coste);
                        label5.Text = coste;
                        break;
                    }
                }
            }
        

        private void PintaCoste(string coste)
        {
            string costeActual = "";
            string nombreImagenActual = "";
            int pos=0;
            int x = 20;
            int y = 100;
            int aux = 3;

            foreach (PictureBox item in listaImagenesMana)
            {
                item.Dispose();   
            }
            
            for (int i = 0; i < coste.Length; i++)
            {
                costeActual = coste.Substring(i, 3);
                i = i + 2;
                aux = aux + 3;
                if (costesIncoloros.Contains(costeActual))
                {
                    pos = Array.IndexOf(costesIncoloros, costeActual);
                    nombreImagenActual = @Directory.GetCurrentDirectory() + @"/Imagenes/Iconos/IconosMana/CosteIncoloro/" + nombreImgIncoloros[pos] + ".png";
                    
                }
                else if (colores.Contains(costeActual))
                {
                    pos = Array.IndexOf(colores, costeActual);
                    nombreImagenActual = @Directory.GetCurrentDirectory() + @"/Imagenes/Iconos/IconosMana/Colores/" + nombreImg[pos] +".png";
                   
                }                

                if (pos!=-1)
                {
                        PictureBox imgCosteColor = new PictureBox();
                        imgCosteColor.Width = 30;
                        imgCosteColor.Height = 50;
                        imgCosteColor.Top = 55;
                        imgCosteColor.Left = y + 55;
                        imgCosteColor.ImageLocation = nombreImagenActual;
                        imgCosteColor.Size = new System.Drawing.Size(40, 40);
                        imgCosteColor.SizeMode = PictureBoxSizeMode.StretchImage;
                        Controls.Add(imgCosteColor);
                        imgCosteColor.Refresh();
                        Thread.Sleep(100);
                        listaImagenesMana.Add(imgCosteColor);       
                        y += 55;
                }
                
            }
            /*
            foreach (PictureBox item in listaImagenesMana)
            {
                item.LoadAsync();
            }
             */
        }

        #region MANEJADORES DE EVENTO
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                conectado=d.Desconectar();
            }
            else
            {
                conectado = d.Conectar();
            }
            ActualizaInfoConexion();
        }

        private void btn_CargaEdicion_Click(object sender, EventArgs e)
        {
            lista = d.Seleccionar(edicionSeleccionada);
        }

        /// <summary>
        /// Cambia el valor del campo edicion Seleccionada para uso en métodos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lBox_Ediciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            edicionSeleccionada = ((ListBox)sender).Text;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            PintaListaInfoCartas();
        }

        private void form_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            d.Desconectar();
        }

        private void lBox_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartaSeleccionada = ((ListBox)sender).Text;
            MuestraDatosCarta(cartaSeleccionada);
        }

        /// <summary>
        /// Inserta en TextBox la edicion seleccionada en lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lBox_Ediciones_DoubleClick(object sender, EventArgs e)
        {
            tBox_InsertarEdicion.Text = ((ListBox)sender).Text;
        }

        private void btn_XmlBaseDeDatos_Click(object sender, EventArgs e)
        {
            string nombreEdcion = tBox_InsertarEdicion.Text;
            int i = 0;
            try
            {
                d.CreaTabla(nombreEdcion);
                lista = c.LeerXML(@"/MagicXml/" + nombreEdcion + ".xml");
                progBar_CargarABD.Maximum = lista.Count;
                foreach (Carta item in lista)
                {
                    d.DameCartas(i, item, nombreEdcion);
                    i++;
                    progBar_CargarABD.Value = i;
                }
                i = 0;
                MessageBox.Show("SIN ERRORES APARENTES");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR INtRODUCIENDO");
                throw;
            }
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            numBorrar = int.Parse(tBox_Borrar.Text);
            edicionSeleccionada = tBox_InsertarEdicion.Text;
            if (d.Borrar(numBorrar, edicionSeleccionada))
            {
                MessageBox.Show("BORRADO TODO DE " + edicionSeleccionada);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void tBox_InsertarEdicion_TextChanged(object sender, EventArgs e)
        {
            edicionSeleccionada = tBox_InsertarEdicion.Text;
        } 
        #endregion


    }
}
