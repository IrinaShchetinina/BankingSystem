//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class bank_account
    {
        public int id { get; set; }
        public string Number { get; set; }
        public string User_login { get; set; }
        public Nullable<int> Sum { get; set; }
    
        public virtual bank_deposit bank_deposit { get; set; }
        public virtual user user { get; set; }
    }
}
