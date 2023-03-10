namespace ECommerce.ProductsList.Application.Contract.RespondResult
{
    public interface ICustomeResult<TAggregate>
    {
        TAggregate Result { get; set; }
        object Message { get; set; }
        bool Succeed { get; }
    }
}
