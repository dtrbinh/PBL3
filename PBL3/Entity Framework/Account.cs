//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account() { }
        public Account(string fullName, string username, string password, bool permission)
        {
            this.Fullname = fullName;
            this.Username = username;
            this.Password = password;
            this.Permission = permission;
        }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public bool Permission { get; set; }
    }
}