using WebAPI_RepositoryPattern.Models;
using WebAPI_RepositoryPattern.dbContext;

namespace WebAPI_RepositoryPattern.Repository
{
    public interface IProductRepo
    {
        //create
        void create(Product product);
        //read
        List<Product> read();
        //readbyid
        Product readbyid(int id);
        //update
        void update(Product product);
        //delete
        void delete(int id);
    }
}
