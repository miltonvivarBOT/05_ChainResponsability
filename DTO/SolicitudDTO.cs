using System;
using System.Collections.Generic;
using System.Text;

namespace ChainReponsability.DTO
{
    class SolicitudDTO
    {
        public SolicitudDTO()
        {
        }
        public SolicitudDTO(string cPuesto, bool lAutoriza)
        {
            this.cPuestoAutoriza = cPuesto;
            this.lAutorizada = lAutoriza;
        }
        public string cPuestoAutoriza { get; set; }
        public bool lAutorizada { get; set; }
    }
}
