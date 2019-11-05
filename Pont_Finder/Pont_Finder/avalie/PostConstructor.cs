using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.avalie
{
    class PostConstructor
    {
        private string desc,localizao,tipoproblema,tempohora,modulo;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }

        }

        public string Localizao
        {
            get { return localizao; }
            set { localizao = value; }
        }

        public string Tipoproblema
        {
            get { return tipoproblema; }
            set { tipoproblema = value; }

        }

        public string Tempohora
        {
            get { return tempohora; }
            set { tempohora = value; }
        }

        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

    }
}
