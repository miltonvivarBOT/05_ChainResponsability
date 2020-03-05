using ChainReponsability.DTO;
using ChainReponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainReponsability.CadenaResponsabilidad
{
    class AdministradorBOT : IProcesadorSolicitud
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
            Coordinador coordinador = new Coordinador();
            Gerente gerente = new Gerente();
            Subdirector subdirector = new Subdirector();
            Director director = new Director();

            this._procesadorSolicitud = coordinador;
            coordinador.SetSiguienteSolicitud(gerente);
            gerente.SetSiguienteSolicitud(subdirector);
            subdirector.SetSiguienteSolicitud(director);

            return this._procesadorSolicitud.ProcesaSolicitud(dImporte);
        }
    }
}
