using System;
using System.Collections.Generic;

namespace RC.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            this.Incidentes = new List<Incidente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Incidente> Incidentes { get; set; }
    }
}
