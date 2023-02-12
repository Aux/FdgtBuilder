using System;
using System.Collections.Generic;
using System.Drawing;

namespace FdgtBuilder.Events
{
    public class PrimePaidUpgradeEventBuilder
    {
        private readonly List<string> _args;

        public PrimePaidUpgradeEventBuilder()
        {
            _args = new List<string>
            {
                "primepaidupgrade"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The tier of the subscription being extended. </summary>
        public PrimePaidUpgradeEventBuilder WithTier(uint value)
        {
            _args.Add($"--tier {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public PrimePaidUpgradeEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public PrimePaidUpgradeEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public PrimePaidUpgradeEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public PrimePaidUpgradeEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public PrimePaidUpgradeEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }
    }
}
