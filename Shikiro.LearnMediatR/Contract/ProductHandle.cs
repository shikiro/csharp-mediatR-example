using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Shikiro.LearnMediatR.Contract
{
    public class ProductHandle : IRequestHandler<ProductRequest, ProductResponse>
    {
        public Task<ProductResponse> Handle(ProductRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ProductResponse { Id = 1, Name = "test" });
        }
    }
}
