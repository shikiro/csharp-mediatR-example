using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Shikiro.LearnMediatR.Contract
{
    public class ProductRequest: IRequest<ProductResponse>
    {
        public int Id { get; set; }
    }
}
