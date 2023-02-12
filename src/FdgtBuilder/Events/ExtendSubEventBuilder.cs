using System.Collections.Generic;
using System.Drawing;
using System;

namespace FdgtBuilder.Events
{
    public class ExtendSubEventBuilder
    {
        private readonly List<string> _args;

        public ExtendSubEventBuilder()
        {
            _args = new List<string>
            {
                "extendsub"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The number of months the subscription is being extended. </summary>
        public ExtendSubEventBuilder WithMonths(uint value)
        {
            _args.Add($"--months {value}");
            return this;
        }

        /// <summary> The tier of the subscription being extended. </summary>
        public ExtendSubEventBuilder WithTier(uint value)
        {
            _args.Add($"--tier {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public ExtendSubEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public ExtendSubEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public ExtendSubEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public ExtendSubEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public ExtendSubEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }
    }
}
