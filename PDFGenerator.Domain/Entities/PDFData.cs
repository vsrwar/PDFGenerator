using System.ComponentModel.DataAnnotations;
using PDFGenerator.Domain.ValueObjects;

namespace PDFGenerator.Domain.Entities
{
    public class PDFData
    {
        [Required]
        public string Name { get; private set; }
        [Required]
        public Field[] Fields { get; private set; }

        public PDFData(string name, Field[] fields)
        {
            Name = name;
            Fields = fields;
        }
    }
}
