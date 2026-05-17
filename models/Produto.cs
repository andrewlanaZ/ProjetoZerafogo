namespace ZeraFogoApp.models;

internal class Produto
{
    public int id;
    public readonly string tipo;
    public readonly ushort capacidadeKg;
    public readonly string fabricante;
    public readonly DateOnly anoDeFabricacao;
    public readonly DateOnly validade;

    public Produto(int id, string tipo, ushort capacidadeKg, string fabricante, DateOnly anoDeFabricacao, DateOnly validade)
    {
        this.id = id;
        this.tipo = tipo;
        this.capacidadeKg = capacidadeKg;
        this.fabricante = fabricante;
        this.anoDeFabricacao = anoDeFabricacao;
        this.validade = validade;
    }

    public override string ToString()
    {
        return $"{tipo} - {capacidadeKg}Kg - Fabricado por {fabricante} - Fabricação em {anoDeFabricacao} - Valido até {validade}";
    }
}
