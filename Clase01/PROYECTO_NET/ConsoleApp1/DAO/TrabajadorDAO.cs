using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DAO
{
    public class TrabajadorDAO
    {
        public int CalculoHorasExtra(int horas)
        {
            Dictionary<int, int> listaCostoExtra = new Dictionary<int, int>();
            listaCostoExtra.Add(0, 10);
            listaCostoExtra.Add(1, 12);
            listaCostoExtra.Add(2, 12);
            listaCostoExtra.Add(3, 12);
            listaCostoExtra.Add(4, 13);
            listaCostoExtra.Add(5, 13);
            listaCostoExtra.Add(6, 15);
            listaCostoExtra.Add(7, 15);
            listaCostoExtra.Add(8, 15);
            int resultado = 0;

            int horaExtra = 0;
            int costoHoraExtra = 0;
            int costodia = 0;
            if (horas > 8)
            {
                horaExtra = horas - 8;
                costoHoraExtra = listaCostoExtra[horaExtra] * horaExtra;
                costodia = 8 * listaCostoExtra[0];
            }
            else
            {
                costodia = horas * listaCostoExtra[0];
            }

            resultado = costodia + costoHoraExtra;
            return resultado;
        }
    }
}
