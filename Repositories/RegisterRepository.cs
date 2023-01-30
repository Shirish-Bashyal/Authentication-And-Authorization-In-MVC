
using Authentication_And_Authorization_In_MVC.Data;
using Authentication_And_Authorization_In_MVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;


namespace Authentication_And_Authorization_In_MVC.Repositories;

public class RegisterRepository : IRepository<UserDetail, int>
{
    private readonly ApplicationDbContext context;
    public RegisterRepository(ApplicationDbContext context)
    {
        this.context = context;
    }
    


    






    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserDetail>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserDetail> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public  async Task<UserDetail> Insert(UserDetail entity)
    {
        await context.tbl_UserDetails.AddAsync(entity);

        return entity;



    }

    public async Task Save()
    {
       // context.tbl_UserDetails.Add(user);
          await context.SaveChangesAsync();
    }
}
