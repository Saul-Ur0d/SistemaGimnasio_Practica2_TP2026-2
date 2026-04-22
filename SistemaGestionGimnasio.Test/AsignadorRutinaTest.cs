
using Xunit;
using SistemaGestionGimnasio.Modelos;
using SistemaGestionGimnasio.Servicios;

namespace SistemaGestionGimnasio.Test
{
public class AsignadorRutinaTest
{
    [Fact]
    public void AsignarRutinaAlUsuario_DebeAsingarCorrectamente()
    {
            //Arrange
            Usuario usuario = new Usuario("Juan", 20, "Musculo");
            AsignadorRutinas asignador = new AsignadorRutinas();
            Rutina rutina = new Rutina("Brazo", 120);

            //Act
            asignador.AsignarRutinaAUsuario(usuario, rutina);

            //Assert

            Assert.Equal(rutina, usuario.RutinaAsignada);
        
    }
        [Fact]
        public void AsignarUsuarioAlEntrenador_DebeIncluirUsuario()
        {
            //Arrange
            Usuario usuario = new Usuario("Juan", 20, "Musculo");
            AsignadorRutinas asignador = new AsignadorRutinas();
            Entrenador entrenador = new Entrenador("Pancho", "Musculo");

            //Act

            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //Assert

            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());


        }
}
}