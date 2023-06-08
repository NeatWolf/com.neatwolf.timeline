using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace com.NeatWolf.TimelineSubtitles
{
    [System.Serializable]
    public class SubtitleClip : PlayableAsset, ITimelineClipAsset
    {
        public SubtitleBehaviour template = new SubtitleBehaviour();

        public ClipCaps clipCaps
        {
            get { return ClipCaps.Blending; }
        }

        /*public override string displayName
        {
            get
            {
                // If the text is empty, default to "Subtitle Clip"
                if (string.IsNullOrEmpty(template.text))
                {
                    return "Subtitle Clip";
                }
                else
                {
                    return template.text;
                }
            }
        }*/

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<SubtitleBehaviour>.Create(graph, template);
            return playable;
        }
    }

}