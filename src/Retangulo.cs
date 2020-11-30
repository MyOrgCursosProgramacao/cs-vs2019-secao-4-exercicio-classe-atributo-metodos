using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2.0 * Altura + 2.0 * Largura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        public override string ToString()
        {
            return "Área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Perímetro = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Diagonal = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
