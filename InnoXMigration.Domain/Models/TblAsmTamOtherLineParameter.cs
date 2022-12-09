using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamOtherLineParameter
{
    public int OlpIdpk { get; set; }

    public int? OlpLineDetailsIdfk { get; set; }

    public int? OlpParameterIdfk { get; set; }

    public string? OlpValue { get; set; }

    public bool? OlpActive { get; set; }

    public string? OlpRmks { get; set; }

    public string? OlpCreatedBy { get; set; }

    public int? OlpEditedBy { get; set; }

    public DateTime? OlpCreationDate { get; set; }

    public DateTime? OlpEditedDate { get; set; }
}
