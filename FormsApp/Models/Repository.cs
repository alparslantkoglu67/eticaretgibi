namespace FormsApp.Models
{
    public class Repository{
        private static readonly List<Product>_products =new();
        private static readonly List<Category>_categories=new();
        static Repository()
        {
            _categories.Add(new Category{CategoryId=1, CategoryName="Telefon"});
            _categories.Add(new Category{CategoryId=2, CategoryName="Bilgisayar"});

            _products.Add(new Product{ProductId=1, Name="Samsung Galaxy a24", Price=10999, Image="a24.jpg", IsActive=true, CategoryId=1});
            _products.Add(new Product{ProductId=2, Name="Macbook Air Pro M1", Price=50999, Image="airm1.jpg", IsActive=false, CategoryId=2});
            _products.Add(new Product{ProductId=3, Name="iPhone 11 Pro", Price=45999, Image="i11.webp", IsActive=true, CategoryId=1});
            _products.Add(new Product{ProductId=4, Name="iPhone 13 Pro", Price=60999, Image="i13.jpg", IsActive=true, CategoryId=1});
            _products.Add(new Product{ProductId=5, Name="iPhone 15 Pro Max", Price=80999, Image="ipro15.webp", IsActive=true, CategoryId=1});
            _products.Add(new Product{ProductId=6, Name="Lenovo İdeapad Gaming 3", Price=40999, Image="leonovo.webp", IsActive=true, CategoryId=2});
            _products.Add(new Product{ProductId=7, Name="Macbook Air Pro M2", Price=100999, Image="macprom2.jpg", IsActive=false, CategoryId=2});
            _products.Add(new Product{ProductId=8, Name="Samsung Galaxy s24", Price=20999, Image="s24.webp", IsActive=false, CategoryId=1});
        }
        public static  List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static void CreateProduct(Product entity)
        {
          _products.Add(entity);

        }
        public static void EditProduct(Product updatedProduct)
        {
            var entity=_products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if(entity !=null)
            {
                entity.Name=updatedProduct.Name;
                entity.Price=updatedProduct.Price;
                entity.Image=updatedProduct.Image;
                entity.CategoryId=updatedProduct.CategoryId;
                entity.IsActive=updatedProduct.IsActive;
            }
        }
        public static void EditIsActive(Product updatedProduct)
        {
            var entity=_products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if(entity !=null)
            {
                entity.IsActive = updatedProduct.IsActive;
            }
        }
        public static void DeleteProduct(Product deletedProduct)
        {
            var entity=_products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);
            if(entity !=null)
            {
                _products.Remove(entity);
            }

        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        
    }
}