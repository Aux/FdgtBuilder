using System.Collections.Generic;
using System.Drawing;
using System;

namespace FdgtBuilder.Events
{
    public class SubMysteryGiftEventBuilder
    {
        private readonly List<string> _args;

        public SubMysteryGiftEventBuilder()
        {
            _args = new List<string>
            {
                "submysterygift"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The number of gifts the user is currently giving in the channel. </summary>
        public SubMysteryGiftEventBuilder WithAmount(uint value)
        {
            _args.Add($"--count {value}");
            return this;
        }

        /// <summary> The total number of gifts the user has given in the channel. </summary>
        public SubMysteryGiftEventBuilder WithTotal(uint value)
        {
            _args.Add($"--totalcount {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public SubMysteryGiftEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public SubMysteryGiftEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public SubMysteryGiftEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public SubMysteryGiftEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public SubMysteryGiftEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

    }
}
