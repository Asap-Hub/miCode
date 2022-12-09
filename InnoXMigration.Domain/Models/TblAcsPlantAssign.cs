using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsPlantAssign
{
    public int FplaIdpk { get; set; }

    public DateTime? FplaDate { get; set; }

    public int? FplaApplIdfk { get; set; }

    public int? FplaPltIdfk { get; set; }

    public string? FplaRmks { get; set; }

    public int? FplaCreatedBy { get; set; }

    public int? FplaEditedBy { get; set; }

    public DateTime? FplaCreationDate { get; set; }

    public DateTime? FplaEditedDate { get; set; }
}
