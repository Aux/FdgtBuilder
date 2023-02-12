using FdgtBuilder.Events;
using FdgtBuilder;
using System;

namespace TwitchLib.Client
{
    public static class TwitchClientExtensions
    {
        private const string FdgtChannel = "#fdgt";

        /// <inheritdoc cref="Fdgt.UsingBits"/>
        public static void SendBitsEvent(this TwitchClient twitch, Action<BitsEventBuilder> action)
        {
            var builder = new BitsEventBuilder();
            action(builder);
            SendBitsEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendBitsEvent"/>
        public static void SendBitsEvent(this TwitchClient twitch, BitsEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingEmoteOnly"/>
        public static void SendEmotOnlyEvent(this TwitchClient twitch, Action<EmoteOnlyEventBuilder> action)
        {
            var builder = new EmoteOnlyEventBuilder();
            action(builder);
            SendEmotOnlyEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendEmotOnlyEvent"/>
        public static void SendEmotOnlyEvent(this TwitchClient twitch, EmoteOnlyEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingExtendSub"/>
        public static void SendExtendSubEvent(this TwitchClient twitch, Action<ExtendSubEventBuilder> action)
        {
            var builder = new ExtendSubEventBuilder();
            action(builder);
            SendExtendSubEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendExtendSubEvent"/>
        public static void SendExtendSubEvent(this TwitchClient twitch, ExtendSubEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingGiftPaidUpgrade"/>
        public static void SendGiftPaidUpgradeEvent(this TwitchClient twitch, Action<GiftPaidUpgradeEventBuilder> action)
        {
            var builder = new GiftPaidUpgradeEventBuilder();
            action(builder);
            SendGiftPaidUpgradeEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendGiftPaidUpgradeEvent"/>
        public static void SendGiftPaidUpgradeEvent(this TwitchClient twitch, GiftPaidUpgradeEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingPrimePaidUpgrade"/>
        public static void SendPrimePaidUpgradeEvent(this TwitchClient twitch, Action<PrimePaidUpgradeEventBuilder> action)
        {
            var builder = new PrimePaidUpgradeEventBuilder();
            action(builder);
            SendPrimePaidUpgradeEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendPrimePaidUpgradeEvent"/>
        public static void SendPrimePaidUpgradeEvent(this TwitchClient twitch, PrimePaidUpgradeEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingRaid"/>
        public static void SendRaidEvent(this TwitchClient twitch, Action<RaidEventBuilder> action)
        {
            var builder = new RaidEventBuilder();
            action(builder);
            SendRaidEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendRaidEvent"/>
        public static void SendRaidEvent(this TwitchClient twitch, RaidEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingResubscription"/>
        public static void SendResubscriptionEvent(this TwitchClient twitch, Action<ResubscriptionEventBuilder> action)
        {
            var builder = new ResubscriptionEventBuilder();
            action(builder);
            SendResubscriptionEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendResubscriptionEvent"/>
        public static void SendResubscriptionEvent(this TwitchClient twitch, ResubscriptionEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingSlowmode"/>
        public static void SendSlowModeEvent(this TwitchClient twitch, Action<SlowModeEventBuilder> action)
        {
            var builder = new SlowModeEventBuilder();
            action(builder);
            SendSlowModeEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendSlowModeEvent"/>
        public static void SendSlowModeEvent(this TwitchClient twitch, SlowModeEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingSubGift"/>
        public static void SendSubGiftEvent(this TwitchClient twitch, Action<SubGiftEventBuilder> action)
        {
            var builder = new SubGiftEventBuilder();
            action(builder);
            SendSubGiftEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendSubGiftEvent"/>
        public static void SendSubGiftEvent(this TwitchClient twitch, SubGiftEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingSubMysteryGift"/>
        public static void SendMysteryGiftEvent(this TwitchClient twitch, Action<SubMysteryGiftEventBuilder> action)
        {
            var builder = new SubMysteryGiftEventBuilder();
            action(builder);
            SendMysteryGiftEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendMysteryGiftEvent"/>
        public static void SendMysteryGiftEvent(this TwitchClient twitch, SubMysteryGiftEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingSubscription"/>
        public static void SendSubscriptionEvent(this TwitchClient twitch, Action<SubscriptionEventBuilder> action)
        {
            var builder = new SubscriptionEventBuilder();
            action(builder);
            SendSubscriptionEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendSubscriptionEvent"/>
        public static void SendSubscriptionEvent(this TwitchClient twitch, SubscriptionEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }

        /// <inheritdoc cref="Fdgt.UsingSubsOnly"/>
        public static void SendSubsOnlyEvent(this TwitchClient twitch, Action<SubsOnlyEventBuilder> action)
        {
            var builder = new SubsOnlyEventBuilder();
            action(builder);
            SendSubsOnlyEvent(twitch, builder);
        }
        /// <inheritdoc cref="SendSubsOnlyEvent"/>
        public static void SendSubsOnlyEvent(this TwitchClient twitch, SubsOnlyEventBuilder builder)
        {
            twitch.SendMessage(FdgtChannel, builder.ToString());
        }
    }
}
