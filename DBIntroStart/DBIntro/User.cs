﻿using SQLite;
namespace DBIntro;

[Table("user")]
public class User
{
    // PrimaryKey is typically numeric 
    [PrimaryKey, AutoIncrement, Column("_id")]
    public int Id { get; set; }
    public String Name { get; set; }

    [Unique]
    public string Username { get; set; }
    public override string ToString()
    {
        return string.Format("{0} ({1})", Name, Id);
    }
}