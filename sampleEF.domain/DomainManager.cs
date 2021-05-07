using System;

namespace sampleEF.domain
{
  public class DomainManager
  {
    // Singleton
    private static DomainManager _singleton = null;
    public static DomainManager Instance
    {
      get
      {
        if (_singleton == null)
        {
          _singleton = new DomainManager();
        }

        return _singleton;
      }
    }
    // Private constructor
    private DomainManager() { }
  }
}