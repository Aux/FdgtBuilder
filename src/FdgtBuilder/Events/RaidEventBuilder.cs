using System;
using System.Collections.Generic;
using System.Drawing;

namespace FdgtBuilder.Events
{
    public class RaidEventBuilder
    {
        private readonly List<string> _args;

        public RaidEventBuilder()
        {
            _args = new List<string>
            {
                "raid"
            };
        }

        public string Build() => ToString();
        public override string ToString()
            => string.Join(" ", _args);


        /// <summary> The number of viewers that joined the raid. </summary>
        public RaidEventBuilder WithViewerCount(uint value)
        {
            _args.Add($"--viewercount {value}");
            return this;
        }

        /// <summary> The color of the user's name in chat. </summary>
        public RaidEventBuilder WithColor(Color value)
        {
            _args.Add($"--color #{ColorTranslator.ToHtml(value)}");
            return this;
        }

        /// <summary> The ID of the message. </summary>
        public RaidEventBuilder WithMessageId(string value)
        {
            _args.Add($"--messageid {value}");
            return this;
        }

        /// <summary> The millisecond timestamp when the message was sent. </summary>
        public RaidEventBuilder WithTimestamp(DateTimeOffset value)
        {
            _args.Add($"--timestamp {value.ToUnixTimeMilliseconds()}");
            return this;
        }

        /// <summary> The ID of the user sending the message. </summary>
        public RaidEventBuilder WithUserId(string value)
        {
            _args.Add($"--userid {value}");
            return this;
        }

        /// <summary> The username of the user sending the message. </summary>
        public RaidEventBuilder WithUserName(string value)
        {
            _args.Add($"--username {value}");
            return this;
        }
    }
}
