using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenCountry
{
    public int CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public string? CtyCapital { get; set; }

    public bool? CtyDefault { get; set; }

    public bool? CtyShowInTransport { get; set; }

    public bool? CtyShowInTam { get; set; }

    public bool? CtyActive { get; set; }

    public string? CtyRmks { get; set; }

    public int? CtyCreatedBy { get; set; }

    public int? CtyEditedBy { get; set; }

    public DateTime? CtyCreationDate { get; set; }

    public DateTime? CtyEditedDate { get; set; }
}
