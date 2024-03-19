using Domain.Common;

namespace Domain.Entities
{
    public class TaxReceipt : AuditableBaseEntity
    {
        public string Nfc { get; set; }
        public double Amount { get; set; }
        public double Itbis18 { get; set; }
        public Taxpayer Taxpayer { get; set; }
    }
}
