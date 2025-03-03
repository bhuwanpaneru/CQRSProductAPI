using MediatR;
using CQRSProductAPI.Domain.Entities;
using System.Collections.Generic;

namespace CQRSProductAPI.CQRS.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>> { }
}
