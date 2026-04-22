

using Xunit;
using SistemaGestionGimnasio.Modelos;



namespace SistemaGestionGimnasio.Test
{
    public class RutinaTest
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista()
        {
            //Arrange
            Rutina rutina = new Rutina("Brazo", 120);
            Ejercicio ejercicio1 = new Ejercicio("Press", 4, 2, 60);
            Ejercicio ejercicio2 = new Ejercicio("Fondos", 10, 3, 60);
            Ejercicio ejercicio3 = new Ejercicio("Lagartijas", 15, 3, 60);

            //Act

            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);
            rutina.AgregarEjercicio(ejercicio3);

            //Assert

            Assert.Contains("Press", rutina.ObtenerEjercicios()[0].Nombre);
            Assert.NotEmpty(rutina.ObtenerEjercicios());

        }
    }
}
