using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaricsGenero
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables

            int numhombres=0;
            int cantmujeres=0;

            //proceso 

            for(int i=0; i<10; i++)
            {

                Console.WriteLine("ingrese el numero de folio");
                Console.ReadLine();


                Console.WriteLine("ingrese el sueldo que gana");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("ingrese el sexo , 1 si es masculino, 2 si es femenino");
                int genero = Convert.ToInt32(Console.ReadLine());


                if(genero==2 && sueldo <= 900000)
                {
                    cantmujeres += 1;
                }
                else if (genero==1 && sueldo <= 1000000)
                {
                    numhombres += 1;
                }

                //salida 
                Console.WriteLine("lacantidad de mujeres que ganan mas de 900000 son" + cantmujeres);
                Console.WriteLine("lacantidad de hombres  que ganan menos de 1000000 son" + numhombres);

            }
        }
    }
}
