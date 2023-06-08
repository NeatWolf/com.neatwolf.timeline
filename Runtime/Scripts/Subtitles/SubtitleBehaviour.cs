using UnityEngine;
using UnityEngine.Playables;

namespace com.NeatWolf.TimelineSubtitles
{
    [System.Serializable]
    public class SubtitleBehaviour : PlayableBehaviour
    {
        [TextArea(2,10)]
        public string text;
    }
}