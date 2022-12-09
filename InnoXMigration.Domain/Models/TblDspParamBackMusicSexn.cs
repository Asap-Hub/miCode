using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspParamBackMusicSexn
{
    public int FpmsIdpk { get; set; }

    public int? FpmsSexnIdfk { get; set; }

    public int? FpmsDocIdfk { get; set; }

    public int? FpmsCreatedBy { get; set; }

    public DateTime? FpmsCreationDate { get; set; }
}
