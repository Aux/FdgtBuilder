using System.Collections.Generic;
using System.Drawing;
using System;

namespace FdgtBuilder.Events
{
    public class SubscriptionEventBuilder
    {
        private readonly List<string> _args;

        public SubscriptionEventBuilder()
        {
            _args = new List<string>
            {
                "subscription"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> Whether this is a Prime subscription. </summary>
        public SubscriptionEventBuilder WithIsPrime()
        {
            _args.Add($"--prime");
            return this;
        }

        /// <summary> The tier of the subscription being extended. </summary>
        public SubscriptionEventBuilder WithTier(uint value)
        {
            _args.Add($"--tier {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public SubscriptionEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public SubscriptionEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public SubscriptionEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public SubscriptionEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public SubscriptionEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }
    }
}
