using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ParametroSQL
    {
        private string parametro;
        private string valor;

        public string Parametro 
        {  
            get { return Parametro; } 
            set { parametro = value; }
      
        }

        public string Valor  // propfull = atalho 
        {
            get { return valor; }
            set { valor = value; }
        }

     

    }
}
