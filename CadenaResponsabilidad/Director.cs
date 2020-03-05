using ChainReponsability.DTO;
using ChainReponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainReponsability.CadenaResponsabilidad
{
    class Director : IProcesadorSolicitud
    {
        private IProcesadorSolicitud _procesadorSolicitud = null;

        public void SetSiguienteSolicitud(IProcesadorSolicitud procesadorSolicitud)
        {
            this._procesadorSolicitud = procesadorSolicitud;
        }
        public IProcesadorSolicitud GetSiguienteSolicitud()
        {
            return this._procesadorSolicitud;
        }

        public SolicitudDTO ProcesaSolicitud(decimal dImporte)
        {

            if (dImporte > 15000M && dImporte <= 50000M)
            {
                return new SolicitudDTO("Director", true);
            }
            else
            {
                return new SolicitudDTO("Director", false);
            }
        }
    }
}
