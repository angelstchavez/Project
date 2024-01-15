using System;

namespace Project.Entity
{
    public class Printer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PrintingArea Area { get; set; }
        public DateTime CreatetAt { get; set; }
    }
}
