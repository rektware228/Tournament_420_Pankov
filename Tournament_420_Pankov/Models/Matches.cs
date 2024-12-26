//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_420_Pankov.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Matches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matches()
        {
            this.Participants1 = new HashSet<Participants>();
        }
    
        public int MatchID { get; set; }
        public int TournamentID { get; set; }
        public string MatchStage { get; set; }
        public System.DateTime MatchStartTime { get; set; }
        public Nullable<int> WinnerParticipantID { get; set; }
        public string Score { get; set; }
        public Nullable<int> DurationMinutes { get; set; }
    
        public virtual Tournaments Tournaments { get; set; }
        public virtual Participants Participants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participants> Participants1 { get; set; }
    }
}
