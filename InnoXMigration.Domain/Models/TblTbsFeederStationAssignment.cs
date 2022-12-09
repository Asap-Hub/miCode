using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsFeederStationAssignment
{
    public int FsaIdpk { get; set; }

    public int? FsaSstIdfk { get; set; }

    public int? FsaFdrIdfk { get; set; }

    public DateTime? FsaDate { get; set; }

    public DateTime? FsaEndDate { get; set; }

    public bool? FsaActive { get; set; }

    public string? FsaRmks { get; set; }

    public int? FsaCreatedBy { get; set; }

    public int? FsaEditedBy { get; set; }

    public DateTime? FsaCreationDate { get; set; }

    public DateTime? FsaEditedDate { get; set; }
}
