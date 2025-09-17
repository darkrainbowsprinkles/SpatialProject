using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Abilities.Effects
{
    [CreateAssetMenu(menuName = "Papime/Abilities/Effects/Animation Effect")]
    public class AnimationEffect : Effect
    {
        [SerializeField] string animationID;

        public override void StartEffect(GameObject user)
        {
            IAvatar localAvatar = SpatialBridge.actorService.localActor.avatar;
            localAvatar.PlayEmote(AssetType.EmbeddedAsset, animationID);
        }
    }
}