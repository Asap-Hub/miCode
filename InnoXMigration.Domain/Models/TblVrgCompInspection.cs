using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompInspection
{
    public int CinIdpk { get; set; }

    public int? CinCompanyIdfk { get; set; }

    public DateTime? CinInspectionDate { get; set; }

    public int? CinInspectedByEmpIdfk { get; set; }

    public string? CinComment { get; set; }

    public bool? CinInspectionOk { get; set; }

    public int? CinDeletedByUsaIdfk { get; set; }

    public string? CinDeletionRmks { get; set; }

    public bool? CinActive { get; set; }

    public string? CinRmks { get; set; }

    public int? CinCreatedBy { get; set; }

    public int? CinEditedBy { get; set; }

    public DateTime? CinCreationDate { get; set; }

    public DateTime? CinEditedDate { get; set; }
}
