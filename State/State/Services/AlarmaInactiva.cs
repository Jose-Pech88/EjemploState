using State.Services.Interfaces;
using System;

namespace State.Services
{
    public class AlarmaInactiva : IAlarma
    {
        private AlarmaContext AlarmaContext = null;

        /// <summary>
        /// Activa la alarma
        /// </summary>
        public void Activar()
        {
            AlarmaActiva alarma = new AlarmaActiva();
            alarma.SetContext(this.AlarmaContext);
            this.AlarmaContext.CambiandoEstadoAlarma(alarma);
            Console.Write("Se activó la alarma\r\n");
        }

        /// <summary>
        /// Inactiva la alarma
        /// </summary>
        public void Inactivar()
        {
            Console.Write("La alarma esta inactiva\r\n");
        }

        public void SetContext(AlarmaContext _context)
        {
            this.AlarmaContext = _context;
        }
    }
}
