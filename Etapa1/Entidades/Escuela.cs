namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string? UniqueId { get; private set; } = Guid.NewGuid().ToString(); 
        private string? nombre;
        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value?.ToUpper(); }
        }
        private int AñoCreacion { get; set; }
        public string? Pais { get; set; }
        public string? Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }
        public Escuela(string? nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);
        public Escuela(string? nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {
            (Nombre, AñoCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \nPaís: {Pais}, Ciudad: {Ciudad}";
        }
    }
}