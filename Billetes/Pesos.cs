﻿using System;

namespace Billetes
{
    //Crear un proyecto de tipo biblioteca de clases.Construir tres clases dentro de un namespace
    //llamado Billetes: Pesos, Euro y Dolar.

    //Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con
    //total normalidad como si fueran tipos numéricos,
    //teniendo presente que 1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.

    //Para operar dos tipos de monedas distintos, primero se deberá convertir todo a una misma moneda y luego
    //realizar la operación.Por ejemplo, si quiero sumar Dolar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.

    //El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

    //Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.

    //Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.

    //Los operadores de comparación == compararán cantidades.

    //Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.

    //Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.


    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;


    }
}
