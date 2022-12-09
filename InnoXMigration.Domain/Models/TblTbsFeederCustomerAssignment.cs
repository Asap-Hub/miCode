using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsFeederCustomerAssignment
{
    public int FcaIdpk { get; set; }

    public int? FcaFdrIdfk { get; set; }

    public int? FcaCustIdfk { get; set; }

    public DateTime? FcaStartDate { get; set; }

    public DateTime? FcaEndDate { get; set; }

    public bool? FcaAssigned { get; set; }

    public bool? FcaTeeingOffFeeder { get; set; }

    public string? FcaRmks { get; set; }

    public int? FcaCreatedBy { get; set; }

    public int? FcaEditedBy { get; set; }

    public DateTime? FcaCreationDate { get; set; }

    public DateTime? FcaEditedDate { get; set; }
}
