using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.Service
{
    public interface IProductService
    {
        //create
        void create_product(Product product);
        //read
        List<Product> read_product();
        //readbyid
        Product readbyid_product(int id);
        //update
        void update_product(Product product);
        //delete
        void delete_product(int id);
    }
}
