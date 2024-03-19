using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Taxpayer : AuditableBaseEntity
    {
        public string Name { get; set; }
        public TaxpayerType Type { get; set; }
        public TaxpayerStatus Status { get; set; }
        public ICollection<TaxReceipt> TaxReceipts { get; set; }
    }
}
