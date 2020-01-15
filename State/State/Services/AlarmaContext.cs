using State.Services.Interfaces;
using System;

namespace State.Services
{
    public class AlarmaContext
    {
        private IAlarma Estado;
        public AlarmaContext(IAlarma _estado)
        {
            Estado = _estado ?? throw new ArgumentNullException(nameof(_estado));            
            this.CambiandoEstadoAlarma(Estado);
        }

        public void CambiandoEstadoAlarma(IAlarma _estado)
        {
            Console.WriteLine($"Cambiando Estado a {_estado.GetType().Name}.");
            this.Estado = _estado;

        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Activar()
        {
            this.Estado.Activar();
        }

        public void Inactivar()
        {
            this.Estado.Inactivar();
        }
    }
}
