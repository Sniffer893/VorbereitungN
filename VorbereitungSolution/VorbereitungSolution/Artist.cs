using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VorbereitungSolution
{
    class Artist
    {
        //Privates Feld, hier wird der eigentliche Wert hinterlegt. Ist aber nicht direkt erreichbar von außen
        private string _Name;

        //Default Konstruktor (kein Parameter)
        public Artist()
        {

        }

        //Copy Konstruktor
        public Artist(Artist a)
        {
            //set/get wird nicht angeschrieben, wird implizit aufgerufen weil wir Name und nicht _Name ansprechen.
            this.Name = a.Name;
        }

        //Konstruktor mit dem Namen als Parameter
        public Artist(string name)
        {
            _Name = name;
        }

        //Public "property" - also Eigenschaft, diese ist von außen abrufbar/veränderbar. Greift auf das Feld _Name zu.
        public string Name
        {
            get
            { 
                return _Name;
            }

            set
            {   //Klasse String zugreifen - https://msdn.microsoft.com/de-de/library/system.string.isnullorempty(v=vs.110).aspx
                if (!String.IsNullOrEmpty(value))
                {
                    _Name = value;
                }
            }
        }
    }
}
