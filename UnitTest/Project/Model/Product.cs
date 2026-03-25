using Project.Advanced;

namespace Project.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReturnProductClassBasedOnPrice(int price)
        {
            if (price > 1000)
            {
                return ProductClassEnum.FirstClass.ToString();
            }
            else
            {
                return ProductClassEnum.SecondClass.ToString();
            }


        }
    }
}
