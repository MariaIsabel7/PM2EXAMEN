using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM2E11397.Models
{
    public class Localizacion
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(70)]
        public String latitud { get; set; }

        [MaxLength(70)]
        public String longitud { get; set; }


        [MaxLength(200)]
        public String descripcionLarga { get; set; }

        [MaxLength(100)]
        public String descripcionCorta { get; set; }
    }
}
