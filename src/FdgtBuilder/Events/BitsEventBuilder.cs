using System;
using System.Collections.Generic;
using System.Drawing;

namespace FdgtBuilder.Events
{
    public class BitsEventBuilder
    {
        private readonly List<string> _args;

        public BitsEventBuilder()
        {
            _args = new List<string>
            {
                "bits"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The number of bits to attach to the message. </summary>
        public BitsEventBuilder WithAmount(uint value)
        {
            _args.Add($"--bitscount {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public BitsEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The body of the message. </summary>
        public BitsEventBuilder WithMessage(string value)
        {
            _args.Add(value);
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public BitsEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public BitsEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public BitsEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public BitsEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }
    }
}
