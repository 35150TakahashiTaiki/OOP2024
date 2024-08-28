using System;
using System.Security.Policy;
using System.Text.Json.Serialization;

public class Employee {
    [JsonIgnore]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime HireDate { get; set; }
    public override string ToString() {
        return string.Format("[Id={0}, Name={1}, HireDate={2}]",
                              Id, Name, HireDate);
    }
}