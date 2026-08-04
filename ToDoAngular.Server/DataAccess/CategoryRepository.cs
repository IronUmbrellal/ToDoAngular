namespace ToDoAngular.Server.DataAccess
{
    public class CategoryRepository
    {
        public readonly AppDbContext _context;

        public  CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task ChangeRepository(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
