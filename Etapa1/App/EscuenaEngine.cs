
namespace CoreEscuela.Entidades
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public List<Evaluaciones> listaEvaluaciones { get; set; }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, "Colombia", "Bogotá");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso { Nombre = "501", Jornada = TiposJornada.Tarde },
            };

            Random rnd = new Random();
            
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura {Nombre = "Matemáticas"},
                    new Asignatura {Nombre = "Educación Física"},
                    new Asignatura {Nombre = "Castellano"},
                    new Asignatura {Nombre = "Ciencias Naturales"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás"};
            string[] nombre2 = {"Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro"};
            string[] apellido1 = {"Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno { Nombre = $"{n1} {n2} {a1}"};

            return listaAlumnos.OrderBy((al)=> al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarEvaluaciones()
        {
            listaEvaluaciones = new List<Evaluaciones>();

            foreach (var curso in Escuela.Cursos)
            {
                Random rnd = new Random();
                int[] numEvaluaciones = {1, 2, 3, 4, 5};
                var listaEvaluacionesPorCurso = (from asg in curso.Asignaturas
                                                 from al in curso.Alumnos
                                                 from n in numEvaluaciones
                                                 select new Evaluaciones{
                                                    Nombre = $"Evaluación de {asg.Nombre} número {n}",
                                                    Alumno = al,
                                                    Asignatura = asg,
                                                    Nota = (float)Math.Round(rnd.NextDouble()*(5-0)+0.1)
                                                 }).ToList();

                listaEvaluaciones.AddRange(listaEvaluacionesPorCurso);
            }
        }
    }
}