using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxRegOrg
{
    public int FrorIdpk { get; set; }

    public DateTime? FrorDate { get; set; }

    public string? FrorName { get; set; }

    public string? FrorShtName { get; set; }

    public string? FrorAddress { get; set; }

    public string? FrorCeoSalutation { get; set; }

    public string? FrorCeoShtSalutation { get; set; }

    public string? FrorTelNo { get; set; }

    public string? FrorEmail { get; set; }

    public string? FrorFax { get; set; }

    public string? FrorRmks { get; set; }

    public string? FrorCreatedBy { get; set; }

    public string? FrorEditedBy { get; set; }

    public DateTime? FrorCreationDate { get; set; }

    public DateTime? FrorEditedDate { get; set; }
}
