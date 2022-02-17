namespace tp2;

public class Programmeur
{
    private static int duree;


    private int id;
    private string nom;
    private string prenom;
    private int bureau;
    private List<ConsoCafe> consoCafes;

    public Programmeur(int id, string nom, string prenom, int bureau)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.bureau = bureau;
        consoCafes = new List<ConsoCafe>(duree);
    }

    public static int Duree
    {
        get => duree;
        set => duree = value;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nom
    {
        get => nom;
        set => nom = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Prenom
    {
        get => prenom;
        set => prenom = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Bureau
    {
        get => bureau;
        set => bureau = value;
    }

    public List<ConsoCafe> ConsoCafes
    {
        get => consoCafes;
    }

    public override string ToString()
    {
        return id + " " + prenom + " " + nom + " " + bureau;
    }
}