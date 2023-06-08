using UnityEngine.Audio;
using UnityEngine.Playables;

namespace com.NeatWolf.SnapshotSignal
{
    public class SnapshotSignalBehaviour : PlayableBehaviour
    {
        public float transitionDuration;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            AudioMixerSnapshot snapshot = playerData as AudioMixerSnapshot;
            if (snapshot != null)
            {
                snapshot.TransitionTo(transitionDuration);
            }
        }
    }
}