//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthenLightHospital_LA_JC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admission
    {
        public int IDAdmission { get; set; }
        public bool ChirurgieProgramme { get; set; }
        public System.DateTime DateAdmission { get; set; }
        public Nullable<System.DateTime> DateChirurgie { get; set; }
        public Nullable<System.DateTime> DateDuConge { get; set; }
        public bool Televiseur { get; set; }
        public bool Telephone { get; set; }
        public string NSS { get; set; }
        public int NumeroLit { get; set; }
        public int IDMedecin { get; set; }
        public string ContactDurgence { get; set; }
    
        public virtual Medecin Medecin { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Lit Lit { get; set; }
    }
}
