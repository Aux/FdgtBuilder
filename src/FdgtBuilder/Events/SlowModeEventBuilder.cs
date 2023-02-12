using System.Collections.Generic;

namespace FdgtBuilder.Events
{
    public class SlowModeEventBuilder
    {
        private readonly List<string> _args;

        public SlowModeEventBuilder()
        {
            _args = new List<string>
            {
                "slowmode"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        public SlowModeEventBuilder WithIsDisabled()
        {
            _args.Add("--off");
            return this;
        }
    }
}
