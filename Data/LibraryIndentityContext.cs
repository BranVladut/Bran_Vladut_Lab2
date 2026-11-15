using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bran_Vladut_Lab2.Data;

public class LibraryIdentityContext : IdentityDbContext<ApplicationUser>
{
    public LibraryIdentityContext(DbContextOptions<LibraryIdentityContext> options)
        : base(options)
    {
    }
}