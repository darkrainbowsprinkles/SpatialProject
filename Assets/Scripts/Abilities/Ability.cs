using System;
using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Abilities
{
    [CreateAssetMenu(menuName = "Papime/Abilities/New Ability")]
    public class Ability : ScriptableObject
    {
        [SerializeField] string attachment;
        [SerializeField] Effect[] effects;

        public void Attach()
        {
            if (string.IsNullOrEmpty(attachment))
            {
                return;
            }

            IAvatar localAvatar = SpatialBridge.actorService.localActor.avatar;
            localAvatar.EquipAttachment(AssetType.EmbeddedAsset, attachment);
        }

        public void Use(GameObject user, Action finished)
        {
            foreach (var effect in effects)
            {
                effect.StartEffect(user, finished);
            }
        }
    }
}

