using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace com.NeatWolf.TimelineSnapshots
{
    public class AudioMixerSnapshotBehaviour : PlayableBehaviour
    {
        public AudioMixerSnapshot snapshot;
        public float transitionDuration;
        private double lastTransitionDuration;

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (snapshot == null) return;

            // Transition to snapshot
            snapshot.TransitionTo(transitionDuration);

            // Check if transitionDuration has been changed
            if (!Mathf.Approximately((float) lastTransitionDuration, transitionDuration))
            {
                lastTransitionDuration = transitionDuration;
            }
        }
    }
}