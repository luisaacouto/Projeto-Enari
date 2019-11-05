using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class Evaluation
    {
        private int nota, indexEmp, indexClient;

        public int Nota
        {
            set { nota = value; }
            get { return nota; }
        }
        public int IndexEmp
        {
            set { indexEmp = value; }
            get { return indexEmp; }
        }
        public int IndexClient
        {
            set { indexClient = value; }
            get { return indexClient; }
        }
    }
}
