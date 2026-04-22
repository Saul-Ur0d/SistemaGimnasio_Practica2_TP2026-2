
using Xunit;
using SistemaGestionGimnasio.Modelos;


namespace SistemaGestionGimnasio.Test
{
    public class UsuarioTests
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange
            Usuario usuario = new Usuario("Juan", 20, "Musculo");
            Rutina rutina = new Rutina("Brazo", 120);

            //Act

            usuario.AsignarRutina(rutina);

            //Assert
            Assert.Equal("Brazo", usuario.RutinaAsignada.Nombre);

        }
    }
}