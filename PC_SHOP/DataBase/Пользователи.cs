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
    
    public partial class Пользователи
    {
        public int ID_Пользователя { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public int ID_Роли { get; set; }
    
        public virtual Роли Роли { get; set; }
    }
}
