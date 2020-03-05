using ChainReponsability.DTO;
using ChainReponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainReponsability.CadenaResponsabilidad
{
    class Subdirector : IProcesadorSolicitud
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

            if (dImporte > 10000M && dImporte <= 15000M)
            {
                return new SolicitudDTO("Subdirector", true);
            }
            else
            {
                return this._procesadorSolicitud.ProcesaSolicitud(dImporte);
            }
        }

    }
}
