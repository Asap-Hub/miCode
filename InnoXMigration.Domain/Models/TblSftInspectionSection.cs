using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftInspectionSection
{
    public int IsnIdpk { get; set; }

    public string? IsnName { get; set; }

    public string? IsnShtName { get; set; }

    public bool? IsnFirstAidKitChecklist { get; set; }

    public bool? IsnActive { get; set; }

    public string? IsnRmks { get; set; }

    public int? IsnCreatedBy { get; set; }

    public int? IsnEditedBy { get; set; }

    public DateTime? IsnCreationDate { get; set; }

    public DateTime? IsnEditedDate { get; set; }
}
