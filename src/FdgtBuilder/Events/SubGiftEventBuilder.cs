using System;
using System.Collections.Generic;
using System.Drawing;

namespace FdgtBuilder.Events
{
    public class SubGiftEventBuilder
    {
        private readonly List<string> _args;

        public SubGiftEventBuilder()
        {
            _args = new List<string>
            {
                "subgift"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);

        /// <summary> The username of the user sending the message. </summary>
        public SubGiftEventBuilder WithGifterName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public SubGiftEventBuilder WithGifterId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The ID of the user that is receiving the sub. </summary>
        public SubGiftEventBuilder WithReceiverName(string value)
        {
            _args.Add($"--username2 {value}");
            return this;
        }

        /// <summary> The username of the user that originally gifted the sub. </summary>
        public SubGiftEventBuilder WithReceiverId(string value)
        {
            _args.Add($"--userid2 {value}");
            return this;
        }

        /// <summary> The total number of gifts the user has given in the channel. </summary>
        public SubGiftEventBuilder WithAmount(uint value)
        {
            _args.Add($"--count {value}");
            return this;
        }

        /// <summary> The number of months the subscription is being extended. </summary>
        public SubGiftEventBuilder WithMonths(uint value)
        {
            _args.Add($"--months {value}");
            return this;
        }

        /// <summary> The total number of months the recipient has been subscribed. </summary>
        public SubGiftEventBuilder WithTenure(uint value)
        {
            _args.Add($"--tenure {value}");
            return this;
        }

        /// <summary> The tier of the subscription being extended. </summary>
        public SubGiftEventBuilder WithTier(uint value)
        {
            _args.Add($"--tier {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public SubGiftEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public SubGiftEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public SubGiftEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }
    }
}
