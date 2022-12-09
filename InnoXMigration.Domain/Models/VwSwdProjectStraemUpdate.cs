using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectStraemUpdate
{
    public int PsuIdpk { get; set; }

    public int? PsuStreamIdfk { get; set; }

    public int? PsuStreamDetailIdfk { get; set; }

    public int? PsuStreamLeadEmpIdfk { get; set; }

    public int PsuPresenterEmpIdfk { get; set; }

    public string PsuTitle { get; set; } = null!;

    public string PsuSummary { get; set; } = null!;

    public string PsuProgressActivities { get; set; } = null!;

    public string PsuNextActivities { get; set; } = null!;

    public string PsuRisks { get; set; } = null!;

    public bool PsuActive { get; set; }

    public string PsuRmks { get; set; } = null!;

    public int PsdIdpk { get; set; }

    public DateTime? PsdStartDate { get; set; }

    public DateTime? PsdEndDate { get; set; }

    public string PsdName { get; set; } = null!;

    public int PrjIdpk { get; set; }

    public string PrjName { get; set; } = null!;

    public string PrjShtName { get; set; } = null!;

    public int TinIdpk { get; set; }

    public string TinName { get; set; } = null!;

    public string TinShtName { get; set; } = null!;

    public string TinColour { get; set; } = null!;

    public int PsgIdpk { get; set; }

    public string PsgName { get; set; } = null!;

    public string PsgShtName { get; set; } = null!;

    public int PsnIdpk { get; set; }

    public string PsnName { get; set; } = null!;

    public string PsnShtName { get; set; } = null!;

    public int TeamLeadEmpId { get; set; }

    public string TeamLeadStaffNo { get; set; } = null!;

    public string TeamLeadLname { get; set; } = null!;

    public string TeamLeadFname { get; set; } = null!;

    public string TeamLeadEmpName { get; set; } = null!;

    public string TeamLeadEmpName4 { get; set; } = null!;

    public int PresenterEmpId { get; set; }

    public string PresenterStaffNo { get; set; } = null!;

    public string PresenterLname { get; set; } = null!;

    public string PresenterFname { get; set; } = null!;

    public string PresenterEmpName { get; set; } = null!;

    public string PresenterEmpName1 { get; set; } = null!;

    public string PresenterEmpName4 { get; set; } = null!;

    public bool PsdActive { get; set; }
}
