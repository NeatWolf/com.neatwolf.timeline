#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.Timeline;

namespace com.NeatWolf.TimelineSubtitles
{
    /// <summary>
    /// The SubtitleClipEditor is a Custom Editor script that is designed to allow for the visualization and manipulation 
    /// of SubtitleClip assets within the Unity editor.
    /// </summary>
    [CustomEditor(typeof(SubtitleClip))]
    public class SubtitleClipEditor : Editor
    {
        /// <summary>
        /// The OnInspectorGUI method is where the custom editor interface is created. In this case, we're adding functionality 
        /// to display the subtitle text as the clip's name in the Timeline window.
        /// </summary>
        public override void OnInspectorGUI()
        {
            // Draw the default inspector
            base.OnInspectorGUI();

            // Get a reference to the current SubtitleClip
            SubtitleClip clip = (SubtitleClip)target;

            // Check if a TimelineAsset is currently selected
            if (Selection.activeObject is TimelineAsset)
            {
                // Get all output tracks of the currently selected TimelineAsset
                var selectedTracks = (Selection.activeObject as TimelineAsset).GetOutputTracks();

                // Loop through all tracks
                foreach (var track in selectedTracks)
                {
                    // Loop through all clips in the current track
                    foreach (var tClip in track.GetClips())
                    {
                        // Check if the current clip's asset is the same as the SubtitleClip we're inspecting
                        if (tClip.asset == clip)
                        {
                            // Get the subtitle text from the template
                            string subtitleText = clip.template.text;

                            // If the subtitle text is empty or null, set a default name
                            if (string.IsNullOrEmpty(subtitleText))
                                subtitleText = "Subtitle Clip";

                            // Create a serialized object of the clip.asset (which is a SubtitleClip)
                            SerializedObject so = new SerializedObject(tClip.asset);

                            // Find the m_DisplayName property
                            SerializedProperty prop = so.FindProperty("m_DisplayName");

                            // Set the m_DisplayName property to the subtitle text
                            prop.stringValue = subtitleText;

                            // Apply the modified properties to the serialized object
                            so.ApplyModifiedProperties();

                            // Break out of the loop as we've found the clip we're interested in
                            break;
                        }
                    }
                }
            }
        }
    }
}
#endif