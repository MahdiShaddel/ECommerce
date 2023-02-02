using ECommerce.Products.Domain.Enum;

namespace ECommerce.Products.Application.Contract.RespondResult
{
    public interface ICustomeRespondResult<TAggregate>
    {
        TAggregate Result { get; set; }
        ResultStatus Status { get; set; }
        object Message { get; set; }
        void SetResult(TAggregate result, ResultStatus status, Messages message);
        void SetBoolResult(TAggregate result);
    }
}
