using System.ComponentModel;

namespace ECommerce.ProductsList.Domain.Enum
{
    public enum Messages
    {
        [Description("عملیات با موفقیت انجام شد.")]
        Ok,
        [Description("عملیات با مشکل مواجه شد")]
        Error,
        [Description("رکوردی یافت نشد")]
        NoContent
    }
}
