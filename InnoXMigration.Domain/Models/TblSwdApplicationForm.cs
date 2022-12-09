using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdApplicationForm
{
    public int AfmIdpk { get; set; }

    public string? AfmName { get; set; }

    public string? AfmShtName { get; set; }

    public string? AfmCode { get; set; }

    public int? AfmModuleIdfk { get; set; }

    public string? AfmType { get; set; }

    public string? AfmDesc { get; set; }

    public bool? AfmSelfService { get; set; }

    public bool? AfmActive { get; set; }

    public string? AfmRmks { get; set; }

    public int? AfmCreatedBy { get; set; }

    public int? AfmEditedBy { get; set; }

    public bool? AfmVisible { get; set; }

    public DateTime? AfmEditedDate { get; set; }

    public DateTime? AfmCreationDate { get; set; }
}
