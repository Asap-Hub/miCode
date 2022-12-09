using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAirCondDetail
{
    public int AcdIdpk { get; set; }

    public string? AcdTag { get; set; }

    public string? AcdSerialNo { get; set; }

    public string? AcdCapacity { get; set; }

    public int? AcdClassIdfk { get; set; }

    public int? AcdBrandIdfk { get; set; }

    public int? AcdModelIdfk { get; set; }

    public int? AcdRefrigeranIdfk { get; set; }

    public DateTime? AcdPurchaseDate { get; set; }

    public DateTime? AcdFirstInstallationDate { get; set; }

    public DateTime? AcdManufactureDate { get; set; }

    public bool? AcdWarranty { get; set; }

    public decimal? AcdWarrantyDuration { get; set; }

    public int? AcdWarrantyUnitIdfk { get; set; }

    public decimal? AcdEnergyStarRating { get; set; }

    public bool? AcdActive { get; set; }

    public string? AcdRmks { get; set; }

    public string? AcdCreatedBy { get; set; }

    public int? AcdEditedBy { get; set; }

    public DateTime? AcdCreationDate { get; set; }

    public DateTime? AcdEditedDate { get; set; }
}
