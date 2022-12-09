using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsDriversPermitholdersAssignment
{
    public int DpaIdpk { get; set; }

    public int? DpaEmpIdfk { get; set; }

    public DateTime? DpaStartDate { get; set; }

    public DateTime? DpaEndDate { get; set; }

    public bool? DpaPermitHolder { get; set; }

    public bool? DpaDriver { get; set; }

    public DateTime? DpaLicenseExpiryDate { get; set; }

    public DateTime? DpaLastExpiryAlertDate { get; set; }

    public bool? DpaActive { get; set; }

    public string? DpaRmks { get; set; }

    public int? DpaCreatedBy { get; set; }

    public int? DpaEditedBy { get; set; }

    public DateTime? DpaCreationDate { get; set; }

    public DateTime? DpaEditedDate { get; set; }
}
