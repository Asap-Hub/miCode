using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOmgApplicantCategory
{
    public int ApcIdpk { get; set; }

    public string? ApcName { get; set; }

    public string? ApcShtName { get; set; }

    public string? ApcCode { get; set; }

    public bool? ApcGenerator { get; set; }

    public bool? ApcActive { get; set; }

    public string? ApcRmks { get; set; }

    public int? ApcCreatedBy { get; set; }

    public int? ApcEditedBy { get; set; }

    public DateTime? ApcCreationDate { get; set; }

    public DateTime? ApcEditedDate { get; set; }
}
