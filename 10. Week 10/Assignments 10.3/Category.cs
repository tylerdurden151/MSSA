using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Assignment_10._3
{

    public class Category
    {
        public int CategoryId { get; set; }

        public string? Name { get; set; }

        public virtual ObservableCollectionListSource<Product> Products { get; } = new();
    }
}