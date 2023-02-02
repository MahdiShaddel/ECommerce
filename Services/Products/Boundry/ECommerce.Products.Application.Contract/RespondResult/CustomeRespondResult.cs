using ECommerce.Products.Common;
using ECommerce.Products.Domain.Enum;

namespace ECommerce.Products.Application.Contract.RespondResult
{
    public class CustomeRespondResult<TAggregate> : ICustomeRespondResult<TAggregate>
    {
        public TAggregate Result { get; set; }
        public ResultStatus Status { get; set; }
        public object Message { get; set; } = "NotExecuted";

        public void SetResult(TAggregate result, ResultStatus status, Messages message)
        {
            Result = result;
            Status = status;
            Message = message.GetDescription();
        }

        public void SetResult(TAggregate result, ResultStatus status, string message)
        {
            Result = result;
            Status = status;
            Message = message;
        }

        public void SetBoolResult(TAggregate result)
        {
            var input = Convert.ToBoolean(result);
            if (input)
            {
                Result = result;
                Status = ResultStatus.Success;
                Message = Messages.Ok.GetDescription();
            }
            else
            {
                Result = result;
                Status = ResultStatus.Error;
                Message = Messages.Error.GetDescription();
            }
        }
    }
}
