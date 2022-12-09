using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSdaGenPlant
{
    public int FgptIdpk { get; set; }

    public int? FgptPlantTypeIdfk { get; set; }

    public string? FgptName { get; set; }

    public string? FgptShtName { get; set; }

    public bool? FgptGas { get; set; }

    public bool? FgptLco { get; set; }

    public bool? FgptHfo { get; set; }

    public bool? FgptDfo { get; set; }

    public bool? FgptWater { get; set; }

    public bool? FgptActive { get; set; }

    public string? FgptRmks { get; set; }

    public int? FgptCreatedBy { get; set; }

    public int? FgptEditedBy { get; set; }

    public DateTime? FgptCreationDate { get; set; }

    public DateTime? FgptEditedDate { get; set; }
}
