//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PC_SHOP.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Поставки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставки()
        {
            this.Товары = new HashSet<Товары>();
        }
    
        public int Код_поставки { get; set; }
        public int Код_поставщика { get; set; }
        public System.DateTime Дата_и_время { get; set; }
    
        public virtual Поставщики Поставщики { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Товары> Товары { get; set; }
    }
}
