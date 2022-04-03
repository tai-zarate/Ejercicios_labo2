using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_U3I05
{
    public class Rectangulo
    {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        /*Tiene los atributos de tipo Punto: vertice1, vertice2, vertice3 y vertice4 (que corresponden a
         * los cuatro vértices del rectángulo).
        La base de todos los rectángulos de esta clase será siempre horizontal. El constructor para calculará
        los vértices 2 y 4 del rectángulo a partir de los vértices 1 y 3. Utilizar el método Abs de
        la clase Math que retorna el valor absoluto de un número y será necesario para obtener la distancia entre puntos.

        Realizar los métodos getters para los atributos privados area y perimetro.

        El área (base * altura) y el perímetro ((base + altura) / 2) se deberán calcular sólo
        una vez cuando se llame por primera vez a su correspondiente método getter. En las siguientes
        invocaciones de dichos métodos se deberá retornar siempre el valor calculado anteriormente.*/

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(Math.Abs(this.vertice1.GetX() - this.vertice3.GetX()), this.vertice1.GetY());
            this.vertice4 = new Punto(this.vertice1.GetX(), Math.Abs(this.vertice1.GetY() - this.vertice3.GetY()));
        }

        public float Area()
        {
            this.area = (float)Math.Abs(this.vertice1.GetX() - this.vertice3.GetX()) * Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

            return this.area;
        }

        public float Perimetro()
        {
            this.perimetro = (float)(Math.Abs(this.vertice1.GetX() - this.vertice3.GetX()) + Math.Abs(this.vertice1.GetY() - this.vertice3.GetY())) / 2;
            return this.perimetro;
        }
    }
}
