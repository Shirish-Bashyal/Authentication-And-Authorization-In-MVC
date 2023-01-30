using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Authentication_And_Authorization_In_MVC.Repositories
{
    public interface IRepository<T1,T2> where T1 : class

    {
        //write all the possible tasks that are going to be done in the controller..
        Task<IEnumerable<T1>> GetAll();
        Task<T1> GetById(T2 id);
        Task<T1> Insert(T1 entity);
        Task Delete(T2 id);
        Task Save();





    }
}
