using Microsoft.EntityFrameworkCore;
using TableDbContextSample.Entities;

namespace TableDbContextSample.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
        {
        }

		public DbSet<Table> Tables { get; set; }

		public DbSet<Column> Column { get; set; }

		public DbSet<Row> Rows { get; set; }

		public DbSet<Cell> Cells { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Table>()
				.HasMany(x => x.Columns)
				.WithOne(x => x.Table)
				.HasForeignKey(x => new { x.TableId, x.Name });

			builder.Entity<Column>()
				.HasKey(x => new { x.TableId, x.Name });

			builder.Entity<Row>()
				.HasOne(x => x.Table)
				.WithMany(x => x.Rows);
			builder.Entity<Row>()
				.HasMany(x => x.Cells)
				.WithOne(x => x.Row)
				.HasForeignKey(x => new { x.RowId, x.ColumnName, x.TableId });

			builder.Entity<Cell>()
				.HasKey(x => new { x.RowId, x.ColumnName, x.TableId });
		}
	}
}
