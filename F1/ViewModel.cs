using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1
{
    public class ViewModel
    {   public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private ICommand _calc;

        public ICommand Calc
        {
            get
            {
                return _calc ?? (_calc =>(Re()=>Z=X+Y;))

            }

        }       
    }
}
