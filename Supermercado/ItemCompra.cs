public class ItemCompra
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }

    public decimal Total
    {
        get { return Quantidade * Preco; }
    }
}