using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace com.NeatWolf.TimelineSnapshots
{
    [CreateAssetMenu(menuName = "Timeline Assets/Mixer Snapshot Asset")]
    public class AudioMixerSnapshotAsset : PlayableAsset
    {
        public AudioMixerSnapshot snapshot;

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<AudioMixerSnapshotBehaviour>.Create(graph);
            var behaviour = playable.GetBehaviour();
            behaviour.snapshot = snapshot;

            return playable;
        }
    }
}