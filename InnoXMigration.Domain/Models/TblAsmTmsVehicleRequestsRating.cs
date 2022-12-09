using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestsRating
{
    public int VrrIdpk { get; set; }

    public int? VrrVehicleRequestIdfk { get; set; }

    public string? VrrSatisfactionRmks { get; set; }

    public decimal? VrrEffectiveCommunicationByRequester { get; set; }

    public decimal? VrrTimeConsciousnessByRequester { get; set; }

    public decimal? VrrDriverNeatnessByRequester { get; set; }

    public decimal? VrrVehicleNeatnessByRequester { get; set; }

    public decimal? VrrSatisfiedWithGeneralConductOfDriverByRequester { get; set; }

    public decimal? VrrDriverInappropriateOvertakingByRequester { get; set; }

    public decimal? VrrDriverOverSpeedingByRequester { get; set; }

    public bool? VrrSuspectedProblemWithEyeSightByRequester { get; set; }

    public bool? VrrDriverSuspectedOfAlcoholUsageByRequester { get; set; }

    public decimal? VrrAverageRatingByRequester { get; set; }

    public decimal? VrrEffectiveCommunicationByDriver { get; set; }

    public decimal? VrrTimeConsciousnessByDriver { get; set; }

    public decimal? VrrRequesterNeatnessOfVehicleInteriorByDriver { get; set; }

    public decimal? VrrAskingDriverToOverSpeedByDriver { get; set; }

    public decimal? VrrAskingDriverToDriveLongerThanUsualByDriver { get; set; }

    public decimal? VrrSatisfiedWithGeneralConductOfRequesterByDriver { get; set; }

    public decimal? VrrAverageRatingByDriver { get; set; }

    public bool? VrrSatisfied { get; set; }

    public bool? VrrActive { get; set; }

    public bool? VrrDriversRatingAcknowledged { get; set; }

    public bool? VrrRequestersRatingAcknowledged { get; set; }

    public string? VrrRmks { get; set; }

    public string? VrrCreatedBy { get; set; }

    public int? VrrEditedBy { get; set; }

    public DateTime? VrrCreationDate { get; set; }

    public DateTime? VrrEditedDate { get; set; }
}
