using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Inventories
{
    public class Pickup : MonoBehaviour
    {
        [SerializeField] string itemID;

        // Called in Unity Events
        public void PickItem()
        {
            IAvatar localAvatar = SpatialBridge.actorService.localActor.avatar;
            localAvatar.EquipAttachment(AssetType.EmbeddedAsset, itemID);
        }
    }
}