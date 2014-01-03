using System;
using System.Collections.Generic;

namespace RC.Models
{
    public partial class Incidente
    {
        public int Id { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
