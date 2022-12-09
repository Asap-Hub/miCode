using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCountriesx
{
    public int FctyIdpk { get; set; }

    public string? FctyName { get; set; }

    public string? FctyShtName { get; set; }

    public string? FctyNationality { get; set; }

    public string? FctyCapital { get; set; }

    public bool? FctyDefault { get; set; }

    public bool? FctyShowInTransport { get; set; }

    public bool? FctyShowInTam { get; set; }

    public bool? FctyActive { get; set; }

    public string? FctyRmks { get; set; }

    public int? FctyCreatedBy { get; set; }

    public int? FctyEditedBy { get; set; }

    public DateTime? FctyCreationDate { get; set; }

    public DateTime? FctyEditedDate { get; set; }
}
