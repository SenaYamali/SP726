//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entitty_framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class FilmYayin
    {
        public short FYID { get; set; }
        public short FilmID { get; set; }
        public short SalonID { get; set; }
        public System.DateTime FYZaman { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Salon Salon { get; set; }
    }
}
