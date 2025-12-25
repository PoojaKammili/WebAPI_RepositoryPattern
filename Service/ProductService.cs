using WebAPI_RepositoryPattern.Models;
using WebAPI_RepositoryPattern.Repository;

namespace WebAPI_RepositoryPattern.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductRepo _repo;
        public ProductService(IProductRepo repo) { _repo = repo; }
        //create
        public void create_product(Product product)
        {
            _repo.create(product);
        }
        //read
        public List<Product> read_product()
        {
            return _repo.read();
        }
        //readbyid
        public Product readbyid_product(int id) 
        {
            return _repo.readbyid(id);
        }
        //update
        public void update_product(Product product) 
        {
            _repo.update(product);
        }
        //delete
        public void delete_product(int id) 
        {
            _repo.delete(id);
        }
    }
}
