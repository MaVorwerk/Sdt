using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdt.Domain.Entities
{
    public class Spruch
    {
        public int SpruchId { get; set; }
        public string SpruchText { get; set; }
        public virtual Autor Autor { get; set; }
        public int AutorId { get; set; }
    }
}
