using System.Collections.Generic;

namespace Classes
{
    public interface Room
    {
        string description { get; }
        string name { get; }
        List<string> commands();
    }
}
