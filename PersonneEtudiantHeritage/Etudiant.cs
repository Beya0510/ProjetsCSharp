namespace PersonneEtudiantHeritage;

public class Etudiant
{
    private int _id;
    private int _niveau;
    private DateTime _dateInscription;

    public Etudiant(int id, int niveau, DateTime dateInscription)
    {
        this._id = _id;
        this._niveau = _niveau;
        this._dateInscription = _dateInscription;
    }

    public void SePresenter()
    {
        Console.WriteLine($"ID: {_id}, Niveau: {_niveau}, Date d'inscription: {_dateInscription.ToShortDateString()}");
    }
}
