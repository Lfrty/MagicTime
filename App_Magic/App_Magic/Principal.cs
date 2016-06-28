/*
 * Nombre Programa: App_Magic
 * Autor: Matías de los Ríos Aguilar
 * Versión: 1.0 (no terminada)
 * Fecha: 25/06/2016 21:45
 * Comentario: Proyecto con el propósito de cumplir un listado de Cartas Magic
 *             Incluirá buscador avanzado (Tipo, rareza texto ...)
 *             Tendrá acceso a la base de datos Magic.db
 *             El acceso se hará para añadir tablas, y hacer cambios(admin)
 */            
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Magic
{
    static class Principal
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_Principal());
        }
    }
}
