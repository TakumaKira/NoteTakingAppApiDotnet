using Microsoft.EntityFrameworkCore;

namespace NoteTakingAppApiDotnet.Models;

public class NotesContext : DbContext
{
  public NotesContext(DbContextOptions<NotesContext> options)
    : base(options)
  {
  }

  public DbSet<Note> Note { get; set; } = null!;
}
