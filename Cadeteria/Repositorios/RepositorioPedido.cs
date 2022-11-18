using Cadeteria.Models;

public class RepositorioPedido
{
    private static List<Pedido> Lista_Pedido = new List<Pedido>();

    private static int autonumerico = 0;

    public List<Pedido> Get_Pedidos()
    {
        return Lista_Pedido;
    }

    public void Add_Pedido(Pedido _Pedido)
    {
        autonumerico++;
        _Pedido.Id = autonumerico;
        _Pedido.Estado = false;
        Lista_Pedido.Add(_Pedido);
    }

    public void Baja_Pedido(int _Id_Pedido)
    {
        Pedido? Pedido_Buscar = Get_Pedidos().Find(Pedido => Pedido.Id == _Id_Pedido);

        if (Pedido_Buscar != null)
        {
            Get_Pedidos().Remove(Pedido_Buscar);
        }
    }
}