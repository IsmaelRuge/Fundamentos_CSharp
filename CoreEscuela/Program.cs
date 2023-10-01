var miEscuela = new Escuela();
miEscuela.Nombre = "Platzi Academy";
miEscuela.Direccion = "Cra 9 N° 72";
miEscuela.AñoFundacion = 2012;
Console.WriteLine("Timbrando");
miEscuela.Timbrar();

class Escuela
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public int AñoFundacion { get; set; }
    public string? Ceo { get; set; }
    
    public void Timbrar()
    {
        Console.Beep(2000, 3000);
    }
}