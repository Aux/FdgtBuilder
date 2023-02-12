using System.Collections.Generic;

namespace FdgtBuilder.Events
{
    public class EmoteOnlyEventBuilder
    {
        private readonly List<string> _args;

        public EmoteOnlyEventBuilder()
        {
            _args = new List<string>
            {
                "emoteonly"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        public EmoteOnlyEventBuilder WithIsDisabled()
        {
            _args.Add("--off");
            return this;
        }
    }
}
