namespace ConsoleApp1
{
    public class Libro
    {
        // Atributos privados
        private string titulo;
        private string autor;
        private int anyo;
        private bool disponible;

        // Constructor con cuatro parámetros
        public Libro(string titulo, string autor, int anyo, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anyo = anyo;
            this.disponible = disponible;
        }

        // Propiedades públicas (solo lectura)
        public string Titulo => titulo;
        public string Autor => autor;
        public int Anyo => anyo;
        public bool Disponible => disponible;

        // ToString override: "Titulo - Autor (Anyo)"
        public override string ToString()
        {
            return $"{titulo} - {autor} ({anyo})";
        }
    }
}
