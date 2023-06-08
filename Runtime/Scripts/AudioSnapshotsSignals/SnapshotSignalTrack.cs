using UnityEngine.Audio;
using UnityEngine.Timeline;

namespace com.NeatWolf.SnapshotSignal
{
    [TrackColor(0.855f, 0.8623f, 0.87f)]
    [TrackClipType(typeof(SnapshotSignalAsset))]
    [TrackBindingType(typeof(AudioMixerSnapshot))]
    public class SnapshotSignalTrack : TrackAsset
    {
    }
}