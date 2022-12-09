using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamGenerationPlantType
{
    public int GptIdpk { get; set; }

    public string? GptName { get; set; }

    public string? GptShtName { get; set; }

    public bool? GptActive { get; set; }

    public string? GptRmks { get; set; }

    public int? GptCreatedBy { get; set; }

    public int? GptEditedBy { get; set; }

    public DateTime? GptCreationDate { get; set; }

    public DateTime? GptEditedDate { get; set; }
}
