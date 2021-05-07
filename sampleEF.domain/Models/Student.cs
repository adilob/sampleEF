using System;

namespace sampleEF.domain.Models
{
  public class Student : Person
  {
    public int RegistrationId { get; set; }

    public override string SayHello()
    {
      return "Hello! I'm a Student object";
    }
  }
}