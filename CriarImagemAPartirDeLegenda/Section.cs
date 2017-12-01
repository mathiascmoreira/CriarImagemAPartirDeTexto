using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarImagemAPartirDeLegenda
{
    public class Section
    {
        public int Number { get; set; }
        public TimeSpan Begin { get; set; }
        public TimeSpan End { get; set; }
        public string Text { get; set; }
    }
}
