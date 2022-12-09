using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspParamBackMusicArea
{
    public int FpmaIdpk { get; set; }

    public int? FpmaAreaIdfk { get; set; }

    public int? FpmaDocIdfk { get; set; }

    public int? FpmaCreatedBy { get; set; }

    public DateTime? FpmaCreationDate { get; set; }
}
