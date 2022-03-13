public class Producto
{
    protected int _id;
    protected string _nombre;
    protected string _categoria;
    protected double _precio;
    protected int _ranking;
    private int? id1;
    private double? precio1;
    private int? ranking1;

    public Producto(int id, string nombre, string categoria, double precio, int ranking)
    {
        this._id = id;
        this._nombre = nombre;
        this._categoria = categoria;
        this._precio = precio;
        this._ranking = ranking;
    }

    public Producto(int? id1, string? nombre, string? categoria, double? precio1, int? ranking1)
    {
        this.id1 = id1;
        this.nombre = nombre;
        this.categoria = categoria;
        this.precio1 = precio1;
        this.ranking1 = ranking1;
    }

    public int id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public string categoria
    {
        get { return _categoria; }
        set { _categoria = value; }
    }
    public double precio
    {
        get { return _precio; }
        set { _precio = value; }
    }
    public int ranking
    {
        get { return _ranking; }
        set { _ranking = value; }
    }
    public string rankingProducto()
    {
        return $"El producto {_nombre} está en el ranking {_ranking} de los más vendidos.";
    }
    public override string ToString()
    {
        return $"El id del producto es: {_id}, el nombre es: {_nombre}, " +
            $"pertenece a la categoría de: {_categoria}, su precio es: {precio}.";
    }
}
