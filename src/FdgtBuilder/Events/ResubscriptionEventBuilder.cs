using System;
using System.Collections.Generic;
using System.Drawing;

namespace FdgtBuilder.Events
{
    public class ResubscriptionEventBuilder
    {
        private readonly List<string> _args;

        public ResubscriptionEventBuilder()
        {
            _args = new List<string>
            {
                "resubscription"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The number of months the user has been subscribed to the channel. </summary>
        public ResubscriptionEventBuilder WithMonths(uint value)
        {
            _args.Add($"--months {value}");
            return this;
        }

        /// <summary> Whether this is a Prime subscription. </summary>
        public ResubscriptionEventBuilder WithIsPrime()
        {
            _args.Add($"--prime");
            return this;
        }

        /// <summary> The tier of the subscription being extended. </summary>
        public ResubscriptionEventBuilder WithTier(uint value)
        {
            _args.Add($"--tier {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public ResubscriptionEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public ResubscriptionEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public ResubscriptionEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public ResubscriptionEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public ResubscriptionEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }
    }
}
