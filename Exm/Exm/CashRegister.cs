using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exm
{
    internal class CashRegister : Retailltem
    {
        //List<string> cash = new List<string> ();
        static public List<CashRegister> theses;
        protected List<string> pidjak_cash = new List<string>();
        protected List<string> jeance_cash = new List<string>();
        protected List<string> shirt_cash = new List<string>();
        public CashRegister aga { get; set; }
        public CashRegister() { Info2(); }
        public void Info2() 
        {
            this.num = 1;
        }
        
    }
}