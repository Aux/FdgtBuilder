using FdgtBuilder.Events;

namespace FdgtBuilder
{
    /// <summary> Build a fdgt command string. </summary>
    public static class Fdgt
    {
        /// <summary> Bits events are fired when a user sends a message with bits to a Twitch channel. </summary>
        public static BitsEventBuilder UsingBits() => new BitsEventBuilder();

        /// <summary> Emoteonly events are fired when a Twitch channel is switched into emote-only mode. </summary>
        /// <remarks> This will not prevent non-emote only messages from being sent on fdgt. It only simulates the event of changing a channel's emote-only status. </remarks>
        public static EmoteOnlyEventBuilder UsingEmoteOnly() => new EmoteOnlyEventBuilder();

        /// <summary> Extendsub events are fired when a user extends their existing non-gifted subscription to a Twitch channel. </summary>
        public static ExtendSubEventBuilder UsingExtendSub() => new ExtendSubEventBuilder();

        /// <summary> Giftpaidupgrade events are fired when a user upgrades their subscription from one that was previously gifted to them. </summary>
        public static GiftPaidUpgradeEventBuilder UsingGiftPaidUpgrade() => new GiftPaidUpgradeEventBuilder();

        /// <summary> Primepaidupgrade events are fired when a user upgrades from a Prime subscription to a paid subscription. </summary>
        public static PrimePaidUpgradeEventBuilder UsingPrimePaidUpgrade() => new PrimePaidUpgradeEventBuilder();

        /// <summary> Raid events are fired when a channel is raided by another stream. </summary>
        public static RaidEventBuilder UsingRaid() => new RaidEventBuilder();

        /// <summary> Resubscription events are fired when a when a user continues their existing, non-gifted subscription. </summary>
        public static ResubscriptionEventBuilder UsingResubscription() => new ResubscriptionEventBuilder();

        /// <summary> Slowmode events are fired when a Twitch channel is switched into slow mode. </summary>
        /// <remarks> This will not actually set the channel to slow mode on fdgt. It only simulates the event of changing a channel's slow mode status. </remarks>
        public static SlowModeEventBuilder UsingSlowmode() => new SlowModeEventBuilder();

        /// <summary> Subgift events are fired when a user gifts a subscription to another user in the channel. </summary>
        public static SubGiftEventBuilder UsingSubGift() => new SubGiftEventBuilder();

        /// <summary> Submysterygift events are fired when a user gives mystery subscription gifts. </summary>
        public static SubMysteryGiftEventBuilder UsingSubMysteryGift() => new SubMysteryGiftEventBuilder();

        /// <summary> Subscription events are fired when a user subscribes to a channel for the first time. </summary>
        public static SubscriptionEventBuilder UsingSubscription() => new SubscriptionEventBuilder();

        /// <summary> Subsonly events are fired when a Twitch channel is switched into subs-only mode. </summary>
        public static SubsOnlyEventBuilder UsingSubsOnly() => new SubsOnlyEventBuilder();
    }
}
