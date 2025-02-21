using Exiled.API.Interfaces;

namespace AutomaticCassie
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
