//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Benmoon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRoleMaster
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public bool IsActive { get; set; }
        public byte CommandID { get; set; }
        public int CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateIP { get; set; }
        public int UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateIP { get; set; }
    }
}
