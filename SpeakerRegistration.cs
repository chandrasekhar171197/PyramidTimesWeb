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
    
    public partial class SpeakerRegistration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpeakerRegistration()
        {
            this.EventRegistrations = new HashSet<EventRegistration>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public string Topic { get; set; }
        public string Country { get; set; }
        public string Theme { get; set; }
        public string OneLineProfile { get; set; }
        public string Phone { get; set; }
        public string ProfilePicture { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsApporved { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
    }
}
