using System;

namespace sampleEF.domain.Models
{
  public class Person
  {
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }

    public virtual string SayHello()
    {
      return "Hello! I'm a Person object";
    }

    public override string ToString()
    {
      return string.Concat(this.PersonId.ToString(), " :: ", this.Name);
    }
  }
}