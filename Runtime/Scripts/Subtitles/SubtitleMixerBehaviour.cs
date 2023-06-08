using TMPro;
using UnityEngine;
using UnityEngine.Playables;

namespace com.NeatWolf.TimelineSubtitles
{
    public class SubtitleMixerBehaviour : PlayableBehaviour
    {
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            TextMeshProUGUI trackBinding = playerData as TextMeshProUGUI;

            if (!trackBinding)
                return;

            int inputCount = playable.GetInputCount();

            // Evaluate current clips and get the one with highest weight
            string currentText = "";
            float maxWeight = 0f;
            for (int i = 0; i < inputCount; i++)
            {
                float inputWeight = playable.GetInputWeight(i);
                if (inputWeight > maxWeight)
                {
                    ScriptPlayable<SubtitleBehaviour> inputPlayable = (ScriptPlayable<SubtitleBehaviour>)playable.GetInput(i);
                    SubtitleBehaviour input = inputPlayable.GetBehaviour();

                    maxWeight = inputWeight;
                    currentText = input.text;
                }
            }

            // Set the text and opacity of the bound TextMeshProUGUI
            trackBinding.text = currentText;
            trackBinding.color = new Color(trackBinding.color.r, trackBinding.color.g, trackBinding.color.b, maxWeight);
        }
    }
}