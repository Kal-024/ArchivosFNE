using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlujoNetoSinFinanciamiento.core
{
    public class Fne
    {
        public int Id { get; set; } //4
        public decimal Inversion { get; set; } //32
        public decimal Ingresos { get; set; } //32
        public decimal Egresos { get; set; } //32
        public int Plazo { get; set; } //8
        public decimal Tasa { get; set; } //32
        public decimal Inflacion { get; set; } //32
        public decimal ValorSalvamento { get; set; } //32
    }
}
