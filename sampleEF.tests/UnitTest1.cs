using NUnit.Framework;
using sampleEF.data.Models;
using sampleEF.domain.Factories;
using System.Linq;

namespace sampleEF.tests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      Assert.Pass();
    }

    [Test]
    public void GetPersonFromDataLayer()
    {
      using (var context = new testdbContext())
      {
        var first = context.PersonDbFirsts.First();
        Assert.IsNotNull(first);
      }
    }

    [Test]
    public void FabricatePersonFromDomain()
    {
      using (var context = new testdbContext())
      {
        var first = context.PersonDbFirsts.First();
        var factory = new PersonFactory();

        var person = factory.Fabricate(first);
        Assert.IsNotNull(person);
      }
    }

    [Test]
    public void FabricateStudentFromDomain()
    {
      using (var context = new testdbContext())
      {
        var first = context.PersonDbFirsts.First();
        var factory = new StudentFactory();

        var student = factory.Fabricate(first, 123456);
        Assert.IsNotNull(student);
        Assert.AreEqual(123456, student.RegistrationId);
      }
    }
  }
}