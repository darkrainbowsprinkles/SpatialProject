using System;
using System.Collections;
using UnityEngine;
using SpatialSys.UnitySDK;
using Papime.Control;

namespace Papime.Abilities.Effects
{
    [CreateAssetMenu(menuName = "Papime/Abilities/Effects/Animation Effect")]
    public class AnimationEffect : Effect
    {
        [SerializeField] string animationID;
        [SerializeField] float animationTime = 1f;

        public override void StartEffect(GameObject user, Action finished)
        {
            IAvatar localAvatar = SpatialBridge.actorService.localActor.avatar;
            localAvatar.PlayEmote(AssetType.EmbeddedAsset, animationID);
            user.GetComponent<MonoBehaviour>().StartCoroutine(WaitForAnimationFinished(user, localAvatar, finished));
        }

        IEnumerator WaitForAnimationFinished(GameObject user, IAvatar localAvatar, Action finished)
        {
            user.GetComponent<InputReader>().ToggleInput(true);
            yield return new WaitForSeconds(animationTime);
            user.GetComponent<InputReader>().ToggleInput(false);
            localAvatar.StopEmote();
            finished();
        }
    }
}