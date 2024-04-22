using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApplication.Entities;

[Table("CORPORATE", Schema="CSPS")]
public class Corporate {

    [Column("ID")]
    public long? Id { get; set; }

    [Column("TS")]
    public DateTime? timestamp { get; set; }

    [Column("MODIFIED_BY")]
    public string? modifiedBy { get; set; }

    [Column("ROW_VERSION")]
    public int rowVersion { get; set; }

    [Column("CODE")]
    public long? code { get; set; }

    [Column("NAME")]
    public string? name { get; set; }

    [Column("NATIONAL_IDENTITY")]
    public string? nationalIdentity { get; set; }

}
