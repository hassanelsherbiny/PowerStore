﻿using PowerStore.Domain.Data;
using PowerStore.Domain.Orders;
using PowerStore.Services.Queries.Models.Orders;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Queries.Handlers.Orders
{
    public class GetReturnRequestCountQueryHandler : IRequestHandler<GetReturnRequestCountQuery, int>
    {
        private readonly IRepository<ReturnRequest> _returnRequestRepository;

        public GetReturnRequestCountQueryHandler(IRepository<ReturnRequest> returnRequestRepository)
        {
            _returnRequestRepository = returnRequestRepository;
        }

        public async Task<int> Handle(GetReturnRequestCountQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(
                _returnRequestRepository.Table.Where(x => x.ReturnRequestStatusId == request.RequestStatusId &&
                (string.IsNullOrEmpty(request.StoreId) || x.StoreId == request.StoreId)).Count());
        }
    }
}
