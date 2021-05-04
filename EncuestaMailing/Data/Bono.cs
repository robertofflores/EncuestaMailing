using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestaMailing.Data
{
    public class Bono
    {
        public int codigo { get; set; }
        public double valor { get; set; }
		public String beneficiario { get; set; }
		public String fecha { get; set; }
		public String tipo { get; set; }
		public String cedula { get; set; }
		public String email { get; set; }
		public String concepto { get; set; }

		public String observacion { get; set; }
		
	}
}
