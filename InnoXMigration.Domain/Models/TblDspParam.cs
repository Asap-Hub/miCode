using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspParam
{
    public bool? FdpmShowMsgTitle { get; set; }

    public bool? FdpmShowEventTitle { get; set; }

    public bool? FdpmShowTipTitle { get; set; }

    public bool? FdpmDisplayTipsPanel { get; set; }

    public bool? FdpmDisplayEventsPanel { get; set; }

    public bool? FdpmScrollTipVertically { get; set; }

    public bool? FdpmScrollEventVertically { get; set; }

    public byte? FdpmPicxTime { get; set; }

    public byte? FdpmEventsTime { get; set; }

    public short? FdpmAnnouncementSpeed { get; set; }

    public string? FdpmTitleBarText { get; set; }

    public string? FdpmAnnouncementBackColour { get; set; }

    public string? FdpmAnnouncementTextColour { get; set; }

    public string? FdpmEventsTitleBackColour { get; set; }

    public string? FdpmEventsTitleTextColour { get; set; }

    public string? FdpmEventsTextColour { get; set; }

    public string? FdpmEventsBackColour { get; set; }

    public string? FdpmTipsTitleBackColour { get; set; }

    public string? FdpmTipsTitleTextColour { get; set; }

    public string? FdpmTipsTextColour { get; set; }

    public string? FdpmTipsBackColour { get; set; }

    public string? FdpmDisplayFormTitle { get; set; }

    public DateTime? FdpmCreationDate { get; set; }

    public int? FdpmEditedBy { get; set; }
}
