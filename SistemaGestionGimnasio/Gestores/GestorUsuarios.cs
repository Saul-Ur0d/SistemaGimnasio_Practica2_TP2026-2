using SistemaGestionGimnasio.Modelos;

namespace SistemaGestionGimnasio.Gestores
{
    public class GestorUsuarios
    {
        List<Usuario> usuarios;
        public GestorUsuarios()
        {
            usuarios = new List<Usuario>();
        }
        public void RegistrarUsuario(string nombre, int edad, string objetivo)
        {
            usuarios.Add(new Usuario(nombre, edad, objetivo));
        }
        public Usuario BuscarUsuario(string nombre)
        {
            return usuarios.FirstOrDefault(u => u.Nombre == nombre);
        }

    }
}
