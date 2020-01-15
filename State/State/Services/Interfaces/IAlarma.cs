namespace State.Services.Interfaces
{
    public interface IAlarma
    {
        /// <summary>
        /// Activa la alarma
        /// </summary>
        void Activar();

        /// <summary>
        /// Inactiva la alarma
        /// </summary>
        void Inactivar();
    }
}
