using UnityEngine;
using UnityEngine.Audio;

namespace com.NeatWolf.TimelineSnapshots
{
    [System.Serializable]
    public class AudioMixerSnapshotPlayable : UnityEngine.Playables.PlayableAsset
    {
        public AudioMixerSnapshot snapshot;
        public float transitionDuration = 1f;

        public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, GameObject owner)
        {
            var playable = UnityEngine.Playables.ScriptPlayable<AudioMixerSnapshotBehaviour>.Create(graph);

            var audioMixerSnapshotBehaviour = playable.GetBehaviour();
            audioMixerSnapshotBehaviour.snapshot = snapshot;
            audioMixerSnapshotBehaviour.transitionDuration = transitionDuration;

            return playable;
        }
    }
}