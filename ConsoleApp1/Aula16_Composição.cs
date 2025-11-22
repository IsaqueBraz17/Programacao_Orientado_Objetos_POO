public class Casa
{
    private readonly Telhado _telhado;
    private readonly Porta _porta;

    public Casa()
    {
        _telhado = new Telhado();
        _porta = new Porta();
    }

}