using System.ComponentModel.DataAnnotations;

namespace InfoPill.Communication.Enuns
{
    public enum PillCategory
    {
        [Display(Name = "Analgésico")]
        Analgesic,

        [Display(Name = "Anti-inflamatório")]
        AntiInflammatory,

        [Display(Name = "Antibiótico")]
        Antibiotic,

        [Display(Name = "Antiviral")]
        Antiviral,

        [Display(Name = "Antifúngico")]
        Antifungal,

        [Display(Name = "Antitérmico")]
        Antipyretic,

        [Display(Name = "Antidepressivo")]
        Antidepressant,

        [Display(Name = "Antihipertensivo")]
        Antihypertensive,

        [Display(Name = "Antidiabético")]
        Antidiabetic,

        [Display(Name = "Antiácido")]
        Antacid,

        [Display(Name = "Antialérgico")]
        Antiallergic,

        [Display(Name = "Broncodilatador")]
        Bronchodilator,

        [Display(Name = "Anticonvulsivante")]
        Anticonvulsant,

        [Display(Name = "Sedativo")]
        Sedative,

        [Display(Name = "Anestésico")]
        Anesthetic
    }
}
