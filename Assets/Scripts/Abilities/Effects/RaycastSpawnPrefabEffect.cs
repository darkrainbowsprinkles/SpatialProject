using System;
using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Abilities.Effects
{
    [CreateAssetMenu(menuName = "Papime/Abilities/Effects/Raycast Spawn Prefab Effect")]
    public class RaycastSpawnPrefabEffect : Effect
    {
        [SerializeField] GameObject prefab;
        [SerializeField] LayerMask raycastLayer;
        [SerializeField] float rayOffset = 3f;
        [SerializeField] float rayLength = 1f;

        public override void StartEffect(GameObject user, Action finished)
        {
            IAvatar localAvatar = SpatialBridge.actorService.localActor.avatar;
            Vector3 origin = localAvatar.position + Vector3.up * rayOffset;

            bool found = Physics.Raycast(origin, localAvatar.rotation * Vector3.forward,
                out RaycastHit hit, rayLength, raycastLayer);

            if (found)
            {
                SpatialBridge.coreGUIService.DisplayToastMessage("Found");
                Instantiate(prefab, hit.point, Quaternion.identity);
            }

            finished();
        }
    }
}