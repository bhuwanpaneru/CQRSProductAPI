using MediatR;
using Microsoft.EntityFrameworkCore;
using CQRSProductAPI.Domain.Entities;
using CQRSProductAPI.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProductAPI.CQRS.Queries
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllProductsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
