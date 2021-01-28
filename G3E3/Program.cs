using System;

namespace G3E3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROGRAMACION ESTRUCTURADA GRUPO 07L
             * EJERCICIO 3 GUIA 3
             * 
             * OSCAR ROLANDO CAÑAS VALDIZON
             */

            /*
             * NOTA: EN ESTE PROGRAMA SE USA LA CLASE "System.Math" PARA EJECUTAR
             * CON MENOR CANTIDAD DE LINEAS DE CODIGO Y USAR MENOS VARIABLES/CONSTANTES
             * DE LOS ESPERADOS
             * 
             * Se usan un objeto y una constante de la clase antes mencionada:
             * 1. Math.Pow --> FUNCIONA PARA ELEVAR A UNA POTENCIA UNA VARIABLE DE TIPO double
             * 2. Math.PI --> CONSTANTE DE TIPO double QUE CONTIENE EL VALOR ESPECIFICO DE PI
             * 
             */

            //Se declara las variables a usar
            double radio, volumen;
            //Se declara y define la constante base
            //ESTA CONSTANTE FUE CREADA YA QUE LA CONSOLA NO PUEDE REALIZAR POR SU CUENTA LA DIVISION GRAFICA
            //(4 / 3), RESULTADO QUE DEVUELVE EN UN VALOR DE TIPO int (entero sin decimal)
            const double division = 1.3333333;
            //Se solicita el valor del radio y lo eleva al cubo con la funcion "Math.Pow"
            Console.WriteLine("Ingrese el valor del radio...");
            radio = Math.Pow(Convert.ToDouble(Console.ReadLine()), 3);
            //Realiza la operacion para obtener el volumen
            volumen =  division * Math.PI * radio;
            //Imprime el resultado y cierra el programa
            Console.WriteLine("El volumen de la esfera es de :" + volumen);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();            
        }
    }
}
