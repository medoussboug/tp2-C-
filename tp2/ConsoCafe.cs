namespace tp2;

public class ConsoCafe
{
    private int nbTaces;

    public ConsoCafe(int nbTaces)
    {
        this.nbTaces = nbTaces;
    }

    public int NbTaces
    {
        get => nbTaces;
        set => nbTaces = value;
    }
}