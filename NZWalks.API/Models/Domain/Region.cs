namespace NZWalks.API.Models.Domain;

public class Region
{
    #region Properties

    public Guid Id { get; set; }
    public string Code { get; set; }    
    public string Name { get; set; }
    public double Area { get; set; }
    public double Lat { get; set; }
    public double Long { get; set; }
    public long Population { get; set; }

    #endregion

    #region Navigation Properties

    public IEnumerable<Walk> Walks { get; set; }

    #endregion
}