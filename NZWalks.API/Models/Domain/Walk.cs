﻿namespace NZWalks.API.Models.Domain;

public class Walk
{
    #region Properties

    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Length { get; set; }
    public Guid RegionId { get; set; }
    public Guid WalkDifficultyId { get; set; }

    #endregion

    #region Navigation Properties

    public Region Region { get; set; }
    public WalkDifficulty WalkDifficulty { get; set; }

    #endregion
}