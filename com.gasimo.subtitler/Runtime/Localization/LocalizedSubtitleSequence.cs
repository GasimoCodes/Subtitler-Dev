using UnityEngine;

namespace Gasimo.Subtitles.Localization
{
    /// <summary>
    /// Localized Subtitle Sequence
    /// </summary>
    [CreateAssetMenu(fileName = "Localized Sequence", menuName = "Gasimo/Subtitler/Localized Sequence")]
    public class LocalizedSubtitleSequence : ScriptableObject, ISubtitleSequence
    {
        [SerializeField]
        public LocalizedSubtitleEntry[] Sequence;

        public ISubtitleEntry[] GetSubtitleEntries()
        {
            return Sequence;
        }
    }
}
