using System;
using sampleEF.domain.Models;
using sampleEF.data.Models;

namespace sampleEF.domain.Factories
{
  public class StudentFactory
  {
    public Student Fabricate(PersonDbFirst person, int registrationId)
    {
      if (person == null)
      {
        return null;
      }

      var result = new Student
      {
        PersonId = person.PersonId,
        RegistrationId = registrationId,
        Name = string.Concat(person.FirstName, " ", person.LastName),
        Phone = person.Phone
      };

      return result;
    }
  }
}