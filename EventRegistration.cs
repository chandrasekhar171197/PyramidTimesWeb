//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PyramidTimesWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public Nullable<int> SpeakerId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual SpeakerRegistration SpeakerRegistration { get; set; }
    }
}
