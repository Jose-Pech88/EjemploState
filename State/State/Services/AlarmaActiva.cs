using State.Services.Interfaces;
using System;

namespace State.Services
{
    public class AlarmaActiva : IAlarma
    {
        private AlarmaContext AlarmaContext = null;

        /// <summary>
        /// Activa la alarma
        /// </summary>
        public void Activar()
        {
            Console.Write("La alarma esta activa\r\n");
        }

        /// <summary>
        /// Inactiva la alarma
        /// </summary>
        public void Inactivar()
        {
            AlarmaInactiva alarmaInactiva = new AlarmaInactiva();
            alarmaInactiva.SetContext(this.AlarmaContext);
            this.AlarmaContext.CambiandoEstadoAlarma(alarmaInactiva);
            Console.Write("Se inactivo la alarma\r\n");
        }

        /// <summary>
        /// Asigna el contexto
        /// </summary>
        /// <param name="_context">Asigna el contexto a la propiedad</param>
        public void SetContext(AlarmaContext _context)
        {
            this.AlarmaContext = _context;
        }
    }
}
