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
    
    public partial class Товары
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Товары()
        {
            this.Заказы = new HashSet<Заказы>();
        }
    
        public int Код_товара { get; set; }
        public string Наименование { get; set; }
        public string Технические_характеристики { get; set; }
        public string Описание { get; set; }
        public decimal Цена { get; set; }
        public string Наличие { get; set; }
        public int Количество { get; set; }
        public int Код_поставки { get; set; }
        public int Код_категории { get; set; }
        public byte[] Изображение { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы { get; set; }
        public virtual Категории Категории { get; set; }
        public virtual Поставки Поставки { get; set; }
    }
}
