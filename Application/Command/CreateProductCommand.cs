using MediatR;
using CQRSProductAPI.Domain.Entities;

namespace CQRSProductAPI.Application.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
