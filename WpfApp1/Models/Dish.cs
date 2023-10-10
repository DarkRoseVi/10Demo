//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            this.CookingStage = new HashSet<CookingStage>();
            this.OrderDish = new HashSet<OrderDish>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Description { get; set; }
        public Nullable<int> DegreeSharpnessId { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<int> OrdelId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> CountyOriginId { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CookingStage> CookingStage { get; set; }
        public virtual CountryOrigin CountryOrigin { get; set; }
        public virtual DegreeSharpness DegreeSharpness { get; set; }
        public virtual Otdel Otdel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDish> OrderDish { get; set; }
    }
}
