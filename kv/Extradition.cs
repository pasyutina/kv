//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kv
{
    using System;
    using System.Collections.Generic;
    
    public partial class Extradition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Extradition()
        {
            this.SummaryList = new HashSet<SummaryList>();
        }
    
        public int Id { get; set; }
        public int Id_agent { get; set; }
        public Nullable<System.DateTime> DateOfUssue { get; set; }
        public Nullable<long> Quantity { get; set; }
        public int Id_shipment { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Shipment Shipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SummaryList> SummaryList { get; set; }
    }
}