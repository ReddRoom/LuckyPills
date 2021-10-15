// -----------------------------------------------------------------------
// <copyright file="Corroding.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Corroding : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been sent to the pocket dimension";

        /// <inheritdoc />
        [YamlIgnore]
        public int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        [YamlIgnore]
        public int MaximumDuration { get; set; } = 10;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.ReferenceHub.scp106PlayerScript.GrabbedPosition = player.Position;
            player.EnableEffect<CustomPlayerEffects.Corroding>(duration);
        }
    }
}