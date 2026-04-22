using SistemaGestionGimnasio.Modelos;
using SistemaGestionGimnasio.Gestores;
using SistemaGestionGimnasio.Servicios;

Console.WriteLine("Sistema de Gestion de gimnasio");

//Crear usuario

Console.WriteLine("Ingresa el nombre del usuario: ");
string nombreUsuario = Console.ReadLine() ?? "";
Console.WriteLine("Ingresa la edad del usuario: ");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ingresa el objetivo del usuario: ");
string objetivoUsuario = Console.ReadLine() ?? "";
Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear entrenador

Console.WriteLine("Ingresa el nombre del entrenador: ");
string nombreEntrenador = Console.ReadLine() ?? "";
Console.WriteLine("Ingresa la especialidad del entrenador: ");
string especialidadEntrenador = Console.ReadLine() ?? "";
Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear rutina

Console.WriteLine("Ingresa el nombre de la rutina: ");
string nombreRutina = Console.ReadLine() ?? "";
Console.WriteLine("Ingresa la duracion de la rutina: ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a rutina 

Console.WriteLine("Cuantos ejercicios tendra la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <= numEjercicios; i++)
{
    Console.WriteLine($"Ejercicio {i}: ");
    Console.WriteLine("Nombre del ejercicio: ");
    string nombreEjercicio = Console.ReadLine() ?? "";

    Console.WriteLine("Numero de repeticiones:");
    int repeticionesEjercicio = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Numero de series:");
    int seriesEjercicio = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Numero de series:");
    int descansoEjercicio = int.Parse(Console.ReadLine() ?? "");

    rutina.AgregarEjercicio(new Ejercicio(nombreEjercicio, repeticionesEjercicio, seriesEjercicio, descansoEjercicio));
}

//Asignar rutina y entrenador a usuario

AsignadorRutinas asignador = new AsignadorRutinas();

asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen

Console.WriteLine("Resumen de asignacion: ");
Console.WriteLine($"Usuario: {usuario.Nombre} | Objetivo: {usuario.Objetivo}");
Console.WriteLine($"Rutina asignada: {usuario.RutinaAsignada.Nombre} | Duracion: {usuario.RutinaAsignada.Duracion}");
Console.WriteLine($"Entrenador: {entrenador.Nombre}");

GestorUsuarios gestorUsuarios = new GestorUsuarios();
gestorUsuarios.RegistrarUsuario(usuario.Nombre, usuario.Edad, usuario.Objetivo);
var usuarioBuscado = gestorUsuarios.BuscarUsuario(usuario.Nombre);
var usuariosAsignados = entrenador.ObtenerUsuariosAsignados();
if (usuariosAsignados.Contains(usuarioBuscado))
{
    Console.WriteLine($"Entrenador Asignado: {entrenador.Nombre}");
}




