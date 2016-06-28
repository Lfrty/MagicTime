using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace App_Magic
{
    class ListaCartas
    {
        List<Carta> _Cartas = new List<Carta>();
        bool Anyadir = false;
        internal List<Carta> Cartas
        {
            get { return _Cartas; }
        }

        public List<Carta> LeerXML(string coleccion)
        {
            string n="", c="", t="", ty = "";
 
            XmlDocument docXml = new XmlDocument();
            docXml.Load(@Directory.GetCurrentDirectory() + @coleccion);

            foreach (XmlNode nodos in docXml.DocumentElement.ChildNodes)
            {
                foreach (XmlNode item in nodos)
                {
                    if (item.Name == "name")
                    {
                        n = item.InnerText;
                    }

                    if (item.Name == "cost")
                    {
                        c = item.InnerText;
                    }

                    if (item.Name == "text")
                    {
                        t = item.InnerText;
                    }

                    if (item.Name == "type")
                    {
                        ty = item.InnerText;
                    }

                    if (item.Name == "lang")
                    {
                        Anyadir = true;
                    }
                }
                if (Anyadir)
                {
                    Carta unaCarta = new Carta(n, c, t, ty);
                    _Cartas.Add(unaCarta);
                    Anyadir = false;
                }
                
            }

            return Cartas;
        }
    }
}
