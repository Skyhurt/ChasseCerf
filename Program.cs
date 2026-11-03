using System;

namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        int arrow = 5;
        int goodShoot = 0;
        int hpCerf = 3;
        string hit = "touche";
        Console.WriteLine("===LA CHASSE COMMENCE !===");

        do
        {
            Console.WriteLine("Flèches restantes: " + arrow);
            Console.WriteLine("Vise bien ta cible ! (touche/rate)");
            hit = Console.ReadLine();
            Console.WriteLine("Résultat du tir (touche/rate): " + hit);
            if (hit != "touche" && hit != "rate")
            {
                Console.WriteLine("Commande invalide.");
                continue;
            } 
                else if (hit == "rate")
                {
                    Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");
                    arrow = arrow - 1;
                }
                    else
                    {
                        Console.WriteLine("Bien joué ! Le cerf est touché.");
                        arrow = arrow - 1;
                        hpCerf = hpCerf - 1;
                        goodShoot = goodShoot + 1;
                    }
            if (arrow == 0)
            {
                break;
            }
        Console.WriteLine("Il reste " + hpCerf + " point de vie au cerf");
        } while (hpCerf != 0);

        Console.WriteLine("===BILAN DE LA CHASSE===");
        Console.WriteLine("Tir réussis: " + goodShoot);
        Console.WriteLine("Flèches restantes: " + arrow);

        if (hpCerf == 0)
        {
            Console.WriteLine("Le cerf est abattu !");
            Console.WriteLine("Résultat: chasse réussie !");
        } else
            {
                Console.WriteLine("Résultat: chasse échouée !");
            }
        }
}