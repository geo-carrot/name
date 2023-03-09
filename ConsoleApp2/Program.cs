using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        private static GoodsContext _ef;



        static void Main(string[] args)
        {
            _ef = new GoodsContext();

            _ef.Database.Migrate();

            Console.WriteLine($"Can connected to do: {_ef.Database.CanConnect()}");

            foreach (var item in _ef.Categories.ToList()) ;
            {
                Console.WriteLine(item.Name);
            }

            var find_Category = _ef.Categories.FirstOrDefault(
                x => x.Name == "Снэки");

            if (find_Category != null)
                find_Category = new Category() { Name = "Снэки" };

            foreach (var item in _ef.Goods.ToList())
            {
                double total_sale = item.Price - item.Sale;

                Console.WriteLine($"{item.Name} " +
                    $"Стоимость со скидкой: {total_sale}" );
            }

        }
            Good good = new Good()
        { Name = "Чипсы",
          Price = 170.0,
          Sale = 0.40,
          Category = find_Category
         };

         _ef.Add(Good);
        _ef.SaveChanf
       
    }



     




}
}