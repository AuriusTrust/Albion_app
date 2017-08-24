using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_app_2.Models
{
    public class Cuirs_Equipements
    {
        public int cuirId { get; set; }
        public int cuirRang { get; set; }
        public int cuirEnchantement { get; set; }
        public string cuirTitre { get; set; }
        public string cuirDescription { get; set; }
        public string cuirCaract { get; set; }
        public string cuirImage { get; set; }
        public string cuirFabrication { get; set; }
        public string cuirType { get; set; }

    }

    public class CuirManager
    {
        public static List<Cuirs_Equipements> GetCuirs()
        {
            var cuirsReturn = new List<Cuirs_Equipements>();

            cuirsReturn.Add(new Cuirs_Equipements { cuirId = 1, cuirRang = 1, cuirEnchantement = 0, cuirTitre = "mercenaire", cuirType = "tete", cuirDescription = "Equipement de type cuir pour le DPS", cuirCaract = "rend gay", cuirFabrication = "Coute un bras", cuirImage = "Cuir/capuche_mercenaire_t1.png" });
            cuirsReturn.Add(new Cuirs_Equipements { cuirId = 2, cuirRang = 1, cuirEnchantement = 0, cuirTitre = "mercenaire", cuirType = "torse", cuirDescription = "Equipement de type cuir pour le DPS", cuirCaract = "rend gay", cuirFabrication = "Coute un bras", cuirImage = "Cuir/veste_mercenaire_t1.jpg" });
            cuirsReturn.Add(new Cuirs_Equipements { cuirId = 3, cuirRang = 1, cuirEnchantement = 0, cuirTitre = "mercenaire", cuirType = "pied", cuirDescription = "Equipement de type cuir pour le DPS", cuirCaract = "rend gay", cuirFabrication = "Coute un bras", cuirImage = "Cuir/chaussures_mercenaire_t1.jpg" });

            return cuirsReturn;
            
        }
    }

    /*public class SelectionCuir
    {
        
    }*/


}



