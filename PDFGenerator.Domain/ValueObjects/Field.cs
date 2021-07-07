using System.ComponentModel.DataAnnotations;

namespace PDFGenerator.Domain.ValueObjects
{
    public class Field
    {
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Value { get; private set; }
        [Required]
        public int CoordenateX { get; private set; }
        [Required]
        public int CoordenateY { get; private set; }

        public Field(string name, string value, int coordenateX, int coordenateY)
        {
            Name = name;
            Value = value;
            CoordenateX = coordenateX;
            CoordenateY = coordenateY;
        }
    }
}
