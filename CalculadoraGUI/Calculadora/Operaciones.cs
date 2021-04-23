using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        public String operacion(String [] arr) {
            Double result = Convert.ToDouble(arr[0]);
            switch (Convert.ToInt16(arr[1]))
            {
                case 1:
                    result *= Convert.ToDouble(arr[2]);
                    break;
                case 2:
                    break;
                case 3:
                    result += Convert.ToDouble(arr[2]);
                    break;
                case 4:
                    result -= Convert.ToDouble(arr[2]);
                    break;
                case 5:
                    try
                    {
                        result /= Convert.ToDouble(arr[2]);
                    }
                    catch (ArithmeticException e)
                    {
                        return e + "";
                    }
                    break;
            }
            return result + "";
        }
    }
}
