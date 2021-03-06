using System.Collections.Generic;

namespace Wechaty
{
    public abstract class FileBoxJsonObject
    {
        public abstract FileBoxType BoxType { get; }
        public Dictionary<string, object> Metadata { get; set; }
        public string Name { get; set; }
    }
}
