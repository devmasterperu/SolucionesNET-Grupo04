using ConsoleApp1.BEAN;
using ConsoleApp1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region POO
            ///*
            // = -> Asignación
            //== -> Comparación
            // */
            //ClienteBEAN cliBEAN = new ClienteBEAN();
            //cliBEAN.Nombre = "Hervey";
            //cliBEAN.Apellido = "Quiñones";
            //cliBEAN.Edad = 27;
            //cliBEAN.Genero = 'M';
            //cliBEAN.Carrera = "Ing. Informática";

            //ClienteBEAN cliBEAN2 = new ClienteBEAN();
            //cliBEAN2.Nombre = "Nombre Cliente 2";
            //cliBEAN2.Apellido = "Apellido Cliente2";


            ////Console.WriteLine("Nombre: "+ cliBEAN.Nombre + " Apellido: " + cliBEAN.Apellido + " Género: "+ cliBEAN.Genero);
            ////Console.WriteLine("Nombre: "+ cliBEAN2.Nombre + " Apellido: " + cliBEAN2.Apellido);

            //Console.WriteLine(cliBEAN.ConcatenarDatos());
            //Console.WriteLine(cliBEAN.ConcatenarDatosConParametros("Juan","García") );
            //Console.WriteLine(cliBEAN2.ConcatenarDatos());
            //Console.WriteLine(cliBEAN2.ConcatenarDatosConParametros("Nombre Cliente 3","Apellido Cliente 3"));
            #endregion

            #region Listas con un tipo de dato
            /*Colección de datos
            Listas - List
            Diccionario - Dictionary
            Colas - Queue
            Pilas - Stack
             */
            //List<int> listaNumeros = new List<int>();
            //listaNumeros.Add(40);// indice 0
            //listaNumeros.Add(9);// indice 1
            //listaNumeros.Add(10);//indice 2
            ////inicialización; validación; incremento
            //Console.WriteLine("Lista de Números con FOR");
            //for (int i = 0; i < listaNumeros.Count; i++)
            //{
            //    //indice[0] = 40
            //    //indice[1]= 9
            //    Console.WriteLine("Nro de indice:" + i + " - valor: " + listaNumeros[i]);
            //}

            //Console.WriteLine("Lista de Números con FOREACH");            
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}

            /*Elaborar un programa que ingrese los valores, 
             * si es cero (0) que termine su ejecución y 
             * muestre todos los valores ingresados previamente*/

            //int numero = 0;
            //List<int> listaNum = new List<int>();
            //do
            //{
            //    //num=0
            //    Console.Write("Ingrese número: ");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    listaNum.Add(numero);

            //} while (numero!=0);//F
            ////
            //Console.WriteLine("Lista de números ingresados");
            //foreach (var item in listaNum)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Lista con Clases
            //ClienteBEAN cliBEAN = new ClienteBEAN();
            //cliBEAN.Nombre = "Hervey";
            //cliBEAN.Apellido = "Quiñones";

            //ClienteBEAN cliBEAN2 = new ClienteBEAN() { Nombre = "Carlos", Apellido = "Miroquesada" };

            //List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();
            //listaCliente.Add(cliBEAN);
            //listaCliente.Add(cliBEAN2);
            //listaCliente.Add(new ClienteBEAN { Nombre = "Carol", Apellido = "Mercedes" });

            //Console.WriteLine("Lista de Cliente");
            //foreach (var item in listaCliente)
            //{
            //    Console.WriteLine(item.Nombre + " "+ item.Apellido);
            //}

            #endregion

            #region Diccionary - Diccionario de datos
            //Key - Value
            //Dictionary<int, string> datos = new Dictionary<int, string>();
            //datos.Add(1, "Lunes");
            //datos.Add(2, "Martes");
            //datos.Add(3, "Miercoles");
            //datos.Add(4, "Jueves");
            //datos.Add(5, "Viernes");
            //datos.Add(6, "Sábado");
            //datos.Add(7, "Domingo");

            ///*que se ingrese los valores entre 1 al 7 y que se muestre el día de la semana*/
            //Console.Write("Ingrese valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El nombre del día es: " + datos[valor]);

            #endregion

            #region Ejercicio1
            /*
            Teniendo en cuenta que la hora hombre es de 6 soles y al día se trabaja 8 horas,
            esto equivale a un costo de 80 S/. x día. Por ello se requiere elaborar un diccionario 
            con la siguiente información que compete a la hora extra.
            El cálculo se realizará si excede las 8 horas, caso contrario solo se realizará el 
            cálculo al costo por hora hombre.
               * 1 a 3, precio por hora extra 12
               * 4 a 5, precio por hora extra 13
               * 6, precio por hora extra 15
             Se debe ingresar por pantalla la cantidad de horas trabajadas y se deberá mostrar:
             horas trabajadas, costo horas normales, horas extras, costo horas extras y pago total a realizar             
             */
            // 8 horas -> 10 Soles = 80 soles
            // 10 horas ->  8 horas = 80 soles
            //              2 extra = 24 soles
            //              104 Soles

            //hora, precio*h
            //Dictionary<int, int> listaCostoExtra = new Dictionary<int, int>();
            //listaCostoExtra.Add(0, 10);
            //listaCostoExtra.Add(1, 12);
            //listaCostoExtra.Add(2, 12);
            //listaCostoExtra.Add(3, 12);
            //listaCostoExtra.Add(4, 13);
            //listaCostoExtra.Add(5, 13);
            //listaCostoExtra.Add(6, 15);
            //listaCostoExtra.Add(7, 15);
            //listaCostoExtra.Add(8, 15);

            //Console.Write("Ingrese horas trabajadas: ");
            //int horas = Convert.ToInt32(Console.ReadLine());
            //int horaExtra = 0;
            //int costoHoraExtra = 0;
            //int costodia = 0;
            //if (horas > 8)
            //{
            //    horaExtra = horas - 8;
            //    costoHoraExtra = listaCostoExtra[horaExtra] * horaExtra;
            //    costodia = 8 * listaCostoExtra[0];
            //}
            //else
            //{
            //    costodia= horas * listaCostoExtra[0];
            //}

            //Console.WriteLine("Horas Trabajadas: " + horas);
            //Console.WriteLine("Costo horas normales: " + costodia + " S/.");
            //Console.WriteLine("Horas Extras: " + horaExtra);
            //Console.WriteLine("Costo Horas Extras: " + costoHoraExtra + " S/.");
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Pago a realizar es de: " + (costodia + costoHoraExtra) + " S/.");
            #endregion
            #region Ejercicio2
            /*
             Luego de haber calculado el costo de hora normal y hora extra, se requiere almacenar:
            los datos del trabajador (codigo, nombre, horas de trabajo y pago total a realizar)
            Crear una lista que pueda almacenar los datos de los trabajadores ingresados por pantalla,
            excepto que el pago total debe ser calculado

             */

            List<TrabajadorBEAN> lista = new List<TrabajadorBEAN>();
            string rpta = "N";
            do
            {
                TrabajadorBEAN trabBEAN = new TrabajadorBEAN();
                TrabajadorDAO trabDAO = new TrabajadorDAO();
                Console.Write("Ingrese Código: ");
                trabBEAN.Codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Nombre: ");
                trabBEAN.Nombres = Console.ReadLine();
                Console.Write("Ingrese horas de trabajo: ");
                trabBEAN.HorasTrabajo = Convert.ToInt32(Console.ReadLine());

                trabBEAN.PagoTotal = trabDAO.CalculoHorasExtra(trabBEAN.HorasTrabajo);

                lista.Add(trabBEAN);

                Console.Write("¿Desea continuar? (S/N): ");
                rpta = Console.ReadLine();
            } while (rpta == "S" || rpta == "s");

            Console.WriteLine("Código \tNombre \tHoras Trabajo \tPago");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Codigo + "\t" + item.Nombres + "\t\t" + item.HorasTrabajo + "\t" + item.PagoTotal);
            }

            #endregion
            Console.ReadLine();
        }
    }
}
