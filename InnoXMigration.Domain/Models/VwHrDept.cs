using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrDept
{
    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public int? DptDirectorEmpIdfk { get; set; }

    public DateTime? DptStartDate { get; set; }

    public DateTime? DptEndDate { get; set; }

    public bool? DptActive { get; set; }

    public string DptRmks { get; set; } = null!;

    public int? DptCreatedBy { get; set; }

    public int? DptEditedBy { get; set; }

    public DateTime? DptCreationDate { get; set; }

    public DateTime? DptEditedDate { get; set; }

    public int DirEmpId { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirOnames { get; set; } = null!;

    public string DirEmpName { get; set; } = null!;

    public string DirEmpName1 { get; set; } = null!;

    public string DirEmpName2 { get; set; } = null!;

    public string DirEmpName3 { get; set; } = null!;

    public string DirEmpName4 { get; set; } = null!;

    public string DirEmpName5 { get; set; } = null!;

    public int DirDptId { get; set; }

    public string DirDptName { get; set; } = null!;

    public string DirDptShtName { get; set; } = null!;

    public int DirSxnId { get; set; }

    public string DirSxnName { get; set; } = null!;

    public string DirSxnShtName { get; set; } = null!;

    public int DirTitId { get; set; }

    public string DirTitName { get; set; } = null!;

    public int DirLocId { get; set; }

    public string DirLocName { get; set; } = null!;

    public string DirLocShtName { get; set; } = null!;

    public int DirJbtId { get; set; }

    public string DirJbtName { get; set; } = null!;

    public string DirJbtShtName { get; set; } = null!;

    public int ObrIdpk { get; set; }

    public string ObrName { get; set; } = null!;

    public string ObrShtName { get; set; } = null!;

    public string ObrCode { get; set; } = null!;

    public int HeadEmpId { get; set; }

    public string HeadStaffNo { get; set; } = null!;

    public string HeadLastName { get; set; } = null!;

    public string HeadFirstName { get; set; } = null!;
}
