using Microsoft.EntityFrameworkCore;
using PortfolioTracker.Model;

namespace PortfolioTracker.Context
{
    public class GraphProvider
    {
        private readonly DatabaseContext _context;

        public GraphProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Graph>> GetAllGraphsAsync()
        {
            return await _context.Graphs.ToListAsync();
        }

        public async Task<Graph?> GetGraphByIdAsync(int id)
        {
            return await _context.Graphs
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task AddGraphAsync(Graph graph)
        {
            _context.Graphs.Add(graph);
            await _context.SaveChangesAsync();
        }
    }
}
