//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VDolgah
{
    using System;
    using System.Collections.Generic;
    
    public partial class debt
    {
        public int row { get; set; }
        public int column { get; set; }
        public Nullable<decimal> value { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
