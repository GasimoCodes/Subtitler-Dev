using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


#if SUBTITLER_LOCALIZATION
using Gasimo.Subtitles.Localization;
#endif

namespace Gasimo.Subtitles.Timeline
{
#if SUBTITLER_LOCALIZATION
    /// <summary>
    /// a clip instance containing one SubtitleDataEntry on the Timeline
    /// </summary>
    public class SubtitlerLocalizedPlayableAsset : PlayableAsset
    {

        public LocalizedSubtitleEntry entry;


        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<SubtitlerPlayableBehaviour>.Create(graph);
            var playableBehaviour = playable.GetBehaviour();
            playableBehaviour.entry = entry;

            return playable;
        }
    }
#endif
}
