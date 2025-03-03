using CQRSProductAPI.Application.Commands;
using CQRSProductAPI.Domain.Entities;
using MediatR;
using System;
using CQRSProductAPI.Persistence;


namespace CQRSProductAPI.CQRS.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly ApplicationDbContext _context;

        public CreateProductHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
