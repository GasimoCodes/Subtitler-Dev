using UnityEngine;

namespace Gasimo.Subtitles
{
    /// <summary>
    /// Interface for SubtitleSequences. Implement this to define your own sequence.
    /// </summary>
    public interface ISubtitleSequence
    {
        public ISubtitleEntry[] GetSubtitleEntries();
    }
}
