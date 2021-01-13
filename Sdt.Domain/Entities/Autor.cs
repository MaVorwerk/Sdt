using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdt.Domain.Entities
{
    public class Autor
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutorId { get; set; }   //Id , ID, KlassenName + Id => AutorId

        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public virtual IList<Spruch> Sprueche { get; set; } = new List<Spruch>();

        public byte[] Photo { get; set; }
        public string PhotoMimeType { get; set; }
    }
}
