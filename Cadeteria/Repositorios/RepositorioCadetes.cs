using Cadeteria.Models;
public class RepositorioCadetes
{
    private static List<Cadete> Lista_Cadete = new List<Cadete>();

    private static int autonumerico = 0;

    public List<Cadete> Get_Cadetes()
    {
        return Lista_Cadete;
    }

    public void Add_Cadete(Cadete _Cadete)
    {
        autonumerico++;
        _Cadete.Id = autonumerico;
        Lista_Cadete.Add(_Cadete);
    }

    public void Baja_Cadete(int _Id_Cadete)
    {
        Cadete? Cadete_Buscar = Get_Cadetes().Find( Cadete => Cadete.Id == _Id_Cadete);

        if (Cadete_Buscar != null) 
        {
            Get_Cadetes().Remove(Cadete_Buscar);
        }
    }

}