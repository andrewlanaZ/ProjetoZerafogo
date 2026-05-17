using ZeraFogoApp.models;

namespace ZeraFogoApp;
static internal class Actions
{
    static internal void ListItems(List<Produto> items)
    {
        Console.WriteLine("Produtos: \n");
        foreach (Produto item in items)
        {
            Console.Write($"{item.ToString()}\n");
        }

        Console.ReadLine();
        Console.Clear();
    }

    static internal void Pesquisar(List<Produto> items)
    {
        Console.Write("Pesquisar: ");
        string filter = Console.ReadLine();
        Console.Clear();

        List<Produto> filteredItems = items.Where<Produto>((item) => item.Search(filter)).ToList();

        if (filteredItems.Count <= 0)
        {
            Console.WriteLine("Sem resultados de pesquisa");
        }
        else
        {
            Console.WriteLine("Produtos: \n");
            foreach (Produto item in filteredItems)
            {
                Console.Write($"{item.ToString()}\n");
            }
        }

        Console.ReadLine();
        Console.Clear();
    }

    static internal void Ordenar(List<Produto> items, bool crescente = true)
    {
        Console.Write("Ordem crescente / decrescente ( cres / desc ): ");
        string filter = Console.ReadLine().ToString();

        List<Produto> ordenado = filter == "desc"
            ? items.OrderByDescending(item => item.tipo).ToList()
            : items.OrderBy(item => item.tipo).ToList();

        Console.Clear();

        Console.WriteLine("Produtos: \n");
        foreach (Produto item in ordenado)
        {
            Console.Write($"{item.ToString()}\n");
        }

        Console.ReadLine();
        Console.Clear();
    }
}