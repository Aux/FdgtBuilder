using System.Collections.Generic;
using System.Drawing;
using System;

namespace FdgtBuilder.Events
{
    public class GiftPaidUpgradeEventBuilder
    {
        private readonly List<string> _args;

        public GiftPaidUpgradeEventBuilder()
        {
            _args = new List<string>
            {
                "giftpaidupgrade"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The username of the user sending the message. </summary>
        public GiftPaidUpgradeEventBuilder WithSenderName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }

        /// <summary> The username of the user that originally gifted the sub. </summary>
        public GiftPaidUpgradeEventBuilder WithGifterName(string value)
        {
            _args.Add($"--username2 {value}");
            return this;
        }

        /// <summary> The number of months the subscription is being extended. </summary>
        public GiftPaidUpgradeEventBuilder WithMonths(uint value)
        {
            _args.Add($"--months {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public GiftPaidUpgradeEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public GiftPaidUpgradeEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public GiftPaidUpgradeEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public GiftPaidUpgradeEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }
    }
}
