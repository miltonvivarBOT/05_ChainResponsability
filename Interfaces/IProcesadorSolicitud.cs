using ChainReponsability.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainReponsability.Interfaces
{
    interface IProcesadorSolicitud
    {
        SolicitudDTO ProcesaSolicitud(decimal dImporte);
        void SetSiguienteSolicitud(IProcesadorSolicitud procesadorSolicitud);
        IProcesadorSolicitud GetSiguienteSolicitud();

    }
}
