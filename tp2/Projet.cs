namespace tp2;

public class Projet
{
    private int code;
    private string sujet;
    private int nbrProgrammeur;
    private int duree;
    private List<Programmeur> programmeurs;

    public static void Main(string[] args)
    {
        Console.WriteLine("lol");
    }

    public Projet(int code, string sujet, int nbrProgrammeur, int duree)
    {
        this.code = code;
        this.sujet = sujet;
        this.nbrProgrammeur = nbrProgrammeur;
        this.duree = duree;
        programmeurs = new List<Programmeur>(nbrProgrammeur);
        Programmeur.Duree = duree;
    }

    public bool exists(int id)
    {
        foreach (var programmeur in programmeurs)
        {
            if (programmeur.Id.Equals(id))
            {
                return true;
            }
        }

        return false;
    }
    public void add(Programmeur programmeur)
    {
        if (!exists(programmeur.Id))
        {
            programmeurs.Add(programmeur);
        }
    }

    public void delete(int id)
    {
        foreach (var programmeur in programmeurs)
        {
            if (programmeur.Id.Equals(id))
            {
                programmeurs.Remove(programmeur);
                return;
            }
        }
    }

    public Programmeur findProgrammeur(int id)
    {
        for (var i = 0; i < programmeurs.Count; i++)
        {
            if (programmeurs[i].Id.Equals(id))
            {
                return programmeurs[i];
            }
        }

        return null;
    }

    public void afficherProgrammeur(int id)
    {
        foreach (var programmeur in programmeurs)
        {
            if (programmeur.Id.Equals(id))
            {
                Console.WriteLine(programmeur);
                return;
            }
        }
    }

    public void afficherAllProgrammeurs()
    {
        foreach (var programmeur in programmeurs)
        {
            Console.WriteLine(programmeur);
        }
    }

    public void changerBureauProgrammeur(int bureau, int id)
    {
        findProgrammeur(id).Bureau = bureau;
    }

    public void AjouterConsommation(int nbTasse, int id)
    {
        findProgrammeur(id).ConsoCafes.Add(new ConsoCafe(nbTasse));
    }

    public int calculNbTasseConsome(int semaine)
    {
        int nbTasse = 0;
        foreach (var programmeur in programmeurs)
        {
            nbTasse += programmeur.ConsoCafes[semaine - 1].NbTaces;
        }

        return nbTasse;
    }
}