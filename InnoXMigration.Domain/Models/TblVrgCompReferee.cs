using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompReferee
{
    public int FcrdIdpk { get; set; }

    public string? FcrdCompIdfk { get; set; }

    public string? FcrdRefereeIdfk { get; set; }

    public string? FcrdContact { get; set; }

    public string? FcrdPhoneNo { get; set; }

    public DateTime? FcrdStartDate { get; set; }

    public DateTime? FcrdEndDate { get; set; }

    public bool? FcrdPrimary { get; set; }

    public bool? FcrdActive { get; set; }

    public string? FcrdRmks { get; set; }

    public int? FcrdCreatedBy { get; set; }

    public int? FcrdEditedBy { get; set; }

    public DateTime? FcrdCreationDate { get; set; }

    public DateTime? FcrdEditedDate { get; set; }
}
