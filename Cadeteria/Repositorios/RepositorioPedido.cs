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

    public Pedido Buscar_Pedido(int _Id_Pedido)
    {
        Pedido? Pedido_Buscar = Get_Pedidos().Find(Pedido => Pedido.Id == _Id_Pedido);

        return Pedido_Buscar;
    }

    public void Modificar_Pedido(Pedido _Pedido)
    {
        Pedido? Pedido_Buscar = Buscar_Pedido(_Pedido.Id);

        if (Pedido_Buscar != null)
        {
            Pedido_Buscar.Id = _Pedido.Id;
            Pedido_Buscar.Precio = _Pedido.Precio;
            Pedido_Buscar.Observaciones = _Pedido.Observaciones;
            Pedido_Buscar.Estado = _Pedido.Estado;
        }
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