using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrStaffPassportPicture
{
    public int SppIdpk { get; set; }

    public int? SppEmpIdfk { get; set; }

    public byte[]? SppPicture { get; set; }

    public DateTime? SppDate { get; set; }

    public bool? SppActive { get; set; }

    public string? SppRmks { get; set; }

    public string? SppCreatedBy { get; set; }

    public int? SppEditedBy { get; set; }

    public DateTime? SppCreationDate { get; set; }

    public DateTime? SppEditedDate { get; set; }
}
