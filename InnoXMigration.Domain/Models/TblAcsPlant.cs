using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsPlant
{
    public int FpltIdpk { get; set; }

    public string? FpltName { get; set; }

    public string? FpltShtName { get; set; }

    public double? FpltCapacity { get; set; }

    public int? FpltOwnerIdfk { get; set; }

    public int? FpltPlantTypeIdfk { get; set; }

    public int? FpltLocIdfk { get; set; }

    public bool? FpltAssigned { get; set; }

    public bool? FpltActive { get; set; }

    public string? FpltRmks { get; set; }

    public int? FpltCreatedBy { get; set; }

    public int? FpltEditedBy { get; set; }

    public DateTime? FpltCreationDate { get; set; }

    public DateTime? FpltEditedDate { get; set; }
}
