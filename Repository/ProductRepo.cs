using WebAPI_RepositoryPattern.Models;
using WebAPI_RepositoryPattern.dbContext;

namespace WebAPI_RepositoryPattern.Repository
{
    public class ProductRepo:IProductRepo
    {
        private readonly ProductDbContext _context;
        public ProductRepo(ProductDbContext context) { _context = context; }
        //create
        public void create(Product product)
        { 
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        //read
        public List<Product> read()
        {
            
            return _context.Products.ToList();
        }
        //readbyid
        public Product readbyid(int id)
        {
            return _context.Products.FirstOrDefault(p=>p.Id == id);
        }
        //update
        public void update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        //delete
        public void delete(int id)
        {
            var product = readbyid(id);
            if (product != null) 
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
