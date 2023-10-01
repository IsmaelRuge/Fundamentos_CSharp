using CoreEscuela.Entidades;
using CoreEscuela.Util;

var engine = new EscuelaEngine();
engine.Inicializar();

Printer.WriteTitle("Bienvenidos a la Escuela");
Printer.Beep();

ImprimirCursosEscuela(engine.Escuela);

void ImprimirCursosEscuela(Escuela escuela)
{
    
    Printer.WriteTitle("Cursos de la Escuela");

    if (escuela?.Cursos == null) return;

    foreach (var i in escuela.Cursos)
    {
        Console.WriteLine($"Nombre: {i.Nombre}, Id {i.UniqueId}");
    }
}