public class Pelicula
{
    protected String _nombre;
    protected String _formato;
    protected String _genero;
    protected String _anio;
    protected String _nombreProductora;
    protected String _ubicacion;

    public Pelicula(string nombre, string formato, string genero, String anio, string nombreProductora, string ubicacion)
    {
        this._nombre = nombre;
        this._formato = formato;
        this._genero = genero;
        this._anio = anio;
        this._nombreProductora = nombreProductora;
        this._ubicacion = ubicacion;
    }

    public String nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public String formato
    {
        get { return _formato; }
        set { _formato = value; }
    }

    public String genero
    {
        get { return _genero; }
        set { _genero = value; }
    }

    public String anio
    {
        get { return _anio; }
        set { _anio = value; }
    }

    public string nombreProductora
    {
        get { return _nombreProductora; }
        set { _nombreProductora = value;}
    }
    public string ubicacion
    {
        get { return _ubicacion; }
        set { _ubicacion = value; }
    }

    public override string ToString()
    {
        return $"Nombre de la pelicula: {_nombre}, Formato: {_formato}, Genero: {_genero}, " +
            $"Año: {_anio}, Productora: {_nombreProductora} y su ubicación es: {_ubicacion}";
    }

    public String mostrarUbicacion()
    {
        return $"La película se encuentra en el estante: {_ubicacion}";
    }
}
