using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Authentication_And_Authorization_In_MVC.Models;

namespace Authentication_And_Authorization_In_MVC.Data
{
    

        public class ApplicationDbContext : IdentityDbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            { }
        public DbSet<Authentication_And_Authorization_In_MVC.Models.UserDetail> tbl_UserDetails { get; set; }



    }
}
