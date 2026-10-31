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
        int Arrow;
        Console.WriteLine("===LA CHASSE COMMENCE !===");
        Console.WriteLine("Flèches restantes: ");
        Console.WriteLine("Résultat du tir (touche/rate): ");
        
        Console.WriteLine("Bien joué ! Le cerf est touché.");
        Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");

        Console.WriteLine("Le cerf est abattu !");

        Console.WriteLine("===BILAN DE LA CHASSE===");
        Console.WriteLine("Tir réussis: ");
        Console.WriteLine("Flèches restantes: ");
        Console.WriteLine("Résultat: chasse réussie !");
        Console.WriteLine("Résultat: chasse échouée !");
    }
}