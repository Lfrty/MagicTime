using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Magic
{
    class Carta
    {
        #region CAMPOS
        private string _id;
        private string _nombre;
        private string _coste;
        private string _tipo;
        private string _poder;
        private string _resistencia;
        private string _textoIngles;
        private string _texto;
        private string _rareza;
        private string _artista;
        private string _numEdicion; 
        #endregion

        #region PROPIEDADES
        public string Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Coste
        {
            get { return _coste; }
        }

        public string Tipo
        {
            get { return _tipo; }
        }

        public string Poder
        {
            get { return _poder; }
        }

        public string Resistencia
        {
            get { return _resistencia; }
        }

        public string TextoIngles
        {
            get { return _textoIngles; }
        }

        public string Texto
        {
            get { return _texto; }
        }

        public string Rareza
        {
            get { return _rareza; }
        }

        public string Artista
        {
            get { return _artista; }
        }

        public string NumEdicion
        {
            get { return _numEdicion; }
        } 
        #endregion

        public Carta()
        {

        }

        public Carta(string nombre, string coste, string texto, string tipo)
        {
            _nombre = nombre;
            _coste = coste;
            _texto = texto;
            _tipo = tipo;
        }
    }
}
