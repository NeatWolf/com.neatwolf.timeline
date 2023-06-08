using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace com.NeatWolf.SnapshotSignal
{
    [CreateAssetMenu(fileName = "SnapshotSignal", menuName = "Timeline/Snapshot Signal")]
    public class SnapshotSignalAsset : PlayableAsset, ITimelineClipAsset
    {
        public float transitionDuration = 1f;

        public ClipCaps clipCaps => ClipCaps.None;

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<SnapshotSignalBehaviour>.Create(graph);

            SnapshotSignalBehaviour snapshotSignalBehaviour = playable.GetBehaviour();
            snapshotSignalBehaviour.transitionDuration = transitionDuration;

            return playable;
        }
    }
}