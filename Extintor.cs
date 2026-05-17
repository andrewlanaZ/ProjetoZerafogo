namespace ZeraFogoApp;

/// <summary>
/// Modelo de dados de um extintor.
/// </summary>
public class Extintor
{
    public string Nome        { get; set; }  // Ex: "Extintor Pó ABC Pro"
    public string Fabricante  { get; set; }  // Ex: "Amerex"
    public string Capacidade  { get; set; }  // Ex: "6 kg"
    public decimal Preco      { get; set; }  // Ex: 89.90
    public string Classes     { get; set; }  // Ex: "A, B, C"
    public string Descricao   { get; set; }  // Breve descrição do produto
    public System.Drawing.Image Imagem { get; set; } // opcional
}
