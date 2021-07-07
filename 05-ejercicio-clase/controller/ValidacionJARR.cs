using System;
using System.Windows.Forms;

namespace _05_ejercicio_clase{
    class ValidacionJARR{

        internal bool EsReal(string monto){
            bool flag = false;
            double x = 0.0;
            try {
                x = Convert.ToDouble(monto);
                flag = true;
            }catch {
                MessageBox.Show("Error: Existen campos mal insertados");
                //flag = false;
            }
            return flag;
        }

        internal double LeerReal(string mensaje){
            double x = 0;
            bool flag = true;
            string entrada = "";

            while (flag){
                Console.Write(mensaje);
                entrada = Console.ReadLine();

                try{
                    x = Convert.ToDouble(entrada); 
                    flag = false;
                }
                catch{
                    Console.WriteLine($"Por favor digite un numero real");
                    flag = true;
                }
            }
            return x;
        }

        internal int AEntero(string entrada){
            int x = 0;
            try {
                x = Convert.ToInt32(entrada);
            } catch {
                MessageBox.Show("ERROR: Hay campos mal insertados");
            }
            return x;
        }

        internal double AReal(string monto){
            double x = 0;
            try{
                x = Convert.ToDouble(monto);
            }catch{
                MessageBox.Show("ERROR: Hay campos mal insertados");
            }
            return x;
        }

    }
}