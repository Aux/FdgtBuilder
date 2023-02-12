using System.Collections.Generic;

namespace FdgtBuilder.Events
{
    public class SubsOnlyEventBuilder
    {
        private readonly List<string> _args;

        public SubsOnlyEventBuilder()
        {
            _args = new List<string>
            {
                "subsonly"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        public SubsOnlyEventBuilder WithIsDisabled()
        {
            _args.Add("--off");
            return this;
        }
    }
}
