using Content.Shared.Sound;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Ranged;

/// <summary>
/// Plays a sound when its non-hard fixture collides with a player.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed class FlyBySoundComponent : Component
{
    /// <summary>
    /// Probability that the sound plays
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("prob")]
    public float Prob = 0.75f;

    [ViewVariables(VVAccess.ReadWrite), DataField("sound")]
    public SoundSpecifier Sound = new SoundCollectionSpecifier("BulletMiss")
    {
        Params = AudioParams.Default.WithVolume(5f),
    };

    [ViewVariables, DataField("range")] public float Range = 1.5f;
}
