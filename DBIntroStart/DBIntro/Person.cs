using SQLite;
namespace DBIntro;

[Table("person")]
public class Person
{
    // PrimaryKey is typically numeric 
    // [PrimaryKey, AutoIncrement, Column("_id")]
    // public int Id { get; set; }

    [PrimaryKey, AutoIncrement, Column("_id")]
    public int Id { get; set; }
    [Unique]
    public string SSN { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public string Income { get; set; }
    
    


    public override string ToString()
    {
        return string.Format("{0}({1}) {2} {3} {4}", Name, Id, DOB, SSN, Income);
    }
}
