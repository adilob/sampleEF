using System;
using sampleEF.domain.Models;
using sampleEF.data.Models;

namespace sampleEF.domain.Factories
{
  public class PersonFactory
  {
    public Person Fabricate(PersonDbFirst person)
    {
      if (person == null)
      {
        return null;
      }

      var result = new Person
      {
        PersonId = person.PersonId,
        Name = string.Concat(person.FirstName, " ", person.LastName),
        Phone = person.Phone
      };

      return result;
    }
  }
}