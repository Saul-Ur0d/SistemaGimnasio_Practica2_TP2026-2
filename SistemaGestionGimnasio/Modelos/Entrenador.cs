

namespace SistemaGestionGimnasio.Modelos
{
    public class Entrenador
    {
        public string Nombre {  get; set; }
        public string Especialidad { get; set; }
        private List<Usuario> usuariosAsignados {  get; set; }

        public Entrenador(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuariosAsignados.Add(usuario);
        }

        public List<Usuario> ObtenerUsuariosAsignados()
        {
            return usuariosAsignados;
        }
    }
}
