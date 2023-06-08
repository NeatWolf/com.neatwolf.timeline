using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace com.NeatWolf.TimelineSubtitles
{
    [TrackColor(0.75f, 0.75f, 0.75f)]
    [TrackClipType(typeof(SubtitleClip))]
    [TrackBindingType(typeof(TMPro.TextMeshProUGUI))]
    public class SubtitleTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            // Create a script playable and pass the behaviour class and input count
            return ScriptPlayable<SubtitleMixerBehaviour>.Create(graph, inputCount);
        }
    }
}