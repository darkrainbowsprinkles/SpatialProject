using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Inventories
{
    public class Equipment : MonoBehaviour
    {
        [SerializeField] string[] equipmentItems;
        IAvatar localAvatar;
        bool itemsEquipped = false;

        void Awake()
        {
            localAvatar = SpatialBridge.actorService.localActor.avatar;
        }

        void Update()
        {
            // Attaching items on Start() or OnEnable() doesn't work for some reason 
            if (!itemsEquipped)
            {
                EquipItems();
                itemsEquipped = true;
            }
        }

        void EquipItems()
        {
            foreach (var itemID in equipmentItems)
            {
                localAvatar.EquipAttachment(AssetType.EmbeddedAsset, itemID);
            }
        }
    }
}