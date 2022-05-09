using System;

namespace Armstrong
{
    class Program
    {
        //role : indique si le nombre donnee est un nombre de Armstrong
        //parametre d'entre -> nombre a tester (en entre)
        //valeur de sorie : true si valeur Armstrong
        //                  faux si pas valeur Armstrong
        static bool pop(int nombre)
        {
            int centaine , dizaine , unite, reste;
            
            centaine = nombre / 100;
            reste =  nombre % 100;
            dizaine = reste / 10;
            unite = reste % 10;  

            if(centaine * centaine * centaine + dizaine * dizaine * dizaine + unite * unite * unite == nombre)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            int nombre;
            Console.WriteLine("rentrez la valeur : ");
            nombre = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(pop(nombre));
        }
    
        
    }


}
