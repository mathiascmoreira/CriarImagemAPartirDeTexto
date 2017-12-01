using System.Collections.Generic;

namespace CriarImagemAPartirDeLegenda
{
    public class Subtitle
    {
        public Subtitle()
        {
            Sections = new List<Section>();
        }

        public List<Section> Sections { get; set; }
    }
}
