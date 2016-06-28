using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Magic
{
    public partial class form_Principal : Form
    {
        string[] nombres = { "Avacyn_Restored" };
        static ListaCartas c;
        static List<Carta> lista;
        PictureBox imgCosteColor = new PictureBox();
        PictureBox imgCoste = new PictureBox();
        string[] costesIncoloros = { "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}", "{7}", "{8}", "{9}" };
        string[] colores = { "{B}", "{U}", "{W}", "{G}", "{R}" };
        string[] nombreImg = { "negro", "azul", "blanco", "verde", "rojo" };
        string[] nombreImgIncoloros = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        daoMagic d = new daoMagic();
        string edicionSeleccionada = "";
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
                AnyadeColeccionesLista();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void AnyadeColeccionesLista()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                lBox_Ediciones.Items.Add(nombres[i]);
            }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            lBox_Lista.Items.Clear();
            foreach (Carta item in lista)
            {
                lBox_Lista.Items.Add(item.Nombre);
            }
        }

        private void lBox_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coste = "";

            foreach (Carta item in lista)
            {
                if (((ListBox)sender).Text == item.Nombre)
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
            bool color = false;
            bool incoloro = false;
            for (int i = 0; i < coste.Length; i++)
            {
                costeActual = coste.Substring(i, 3);
                i = i + 2;
                aux = aux + 3;
                if (costesIncoloros.Contains(costeActual))
                {
                    pos = Array.IndexOf(costesIncoloros, costeActual);
                    nombreImagenActual = @Directory.GetCurrentDirectory() + @"/Imagenes/Iconos/IconosMana/CosteIncoloro/" + nombreImgIncoloros[pos] + ".png";
                    incoloro = true;
                }
                else if (colores.Contains(costeActual))
                {
                    pos = Array.IndexOf(colores, costeActual);
                    nombreImagenActual = @Directory.GetCurrentDirectory() + @"/Imagenes/Iconos/IconosMana/Colores/" + nombreImg[pos] +".png";
                    color = true;
                }                

                if (pos!=0)
                {
                    if (color)
                    {
                        imgCosteColor.Width = 30;
                        imgCosteColor.Height = 50;
                        imgCosteColor.Top = 55;
                        imgCosteColor.Left = y + 55;
                        imgCosteColor.ImageLocation = nombreImagenActual;
                        imgCosteColor.Size = new System.Drawing.Size(40, 40);
                        imgCosteColor.SizeMode = PictureBoxSizeMode.StretchImage;
                        Controls.Add(imgCosteColor);
                        imgCosteColor.Load(nombreImagenActual);
                        imgCosteColor.Refresh();
                        color = false;
                    }
                    else
                    {
                        imgCoste.Width = 30;
                        imgCoste.Height = 50;
                        imgCoste.Top = 55;
                        imgCoste.Left = y + 55;
                        imgCoste.ImageLocation = nombreImagenActual;
                        imgCoste.Size = new System.Drawing.Size(40, 40);
                        imgCoste.SizeMode = PictureBoxSizeMode.StretchImage;
                        Controls.Add(imgCoste);
                        imgCoste.Load(nombreImagenActual);
                        imgCoste.Refresh();
                        incoloro = false;
                    }
                    y += 55;
                }               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lBox_Ediciones.Left += 10;
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (!d.Conectar())
            {
                MessageBox.Show("NO CONECTASTE MEN", "NO CONECTADO");
            }
            else
            {
                MessageBox.Show("CONECTADO", "BIEN BIEN");                
            }
        }

        private void btn_anyadeColeccion_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string item in nombres)
                {
                    d.CreaTabla(item);
                    lista = c.LeerXML(@"/MagicXml/" + item+ ".xml");
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (!d.DameCartas(i, lista[i], item))
                        {
                            MessageBox.Show("ERROR al insertar");
                        }
                        
                    }
                }
                MessageBox.Show("COMPLETADO");

                
            }
            catch (Exception)
            {
                
                throw;
            }
           
            MessageBox.Show("HECHO");
        }

        private void btn_CargaEdicion_Click(object sender, EventArgs e)
        {
            lista = d.Seleccionar(edicionSeleccionada);
        }

        private void lBox_Ediciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            edicionSeleccionada = ((ListBox)sender).Text;
        }
    }
}
