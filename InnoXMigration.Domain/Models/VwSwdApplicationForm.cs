using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdApplicationForm
{
    public int AfmIdpk { get; set; }

    public string AfmName { get; set; } = null!;

    public string AfmShtName { get; set; } = null!;

    public string AfmType { get; set; } = null!;

    public string AfmDesc { get; set; } = null!;

    public bool? AfmActive { get; set; }

    public bool? AfmVisible { get; set; }

    public DateTime? AfmCreationDate { get; set; }

    public int? AfmModuleIdfk { get; set; }

    public int ApmIdpk { get; set; }

    public string ApmName { get; set; } = null!;

    public string ApmShtName { get; set; } = null!;

    public bool ApmActive { get; set; }

    public string ApmCode { get; set; } = null!;

    public string? ApmRmks { get; set; }

    public int? ApmCreatedBy { get; set; }

    public DateTime? ApmCreationDate { get; set; }

    public string AfmRmks { get; set; } = null!;

    public DateTime? AfmEditedDate { get; set; }

    public int? AfmEditedBy { get; set; }

    public int? AfmCreatedBy { get; set; }

    public byte? ApmOrder { get; set; }

    public bool? AfmSelfService { get; set; }

    public string AfmCode { get; set; } = null!;
}
