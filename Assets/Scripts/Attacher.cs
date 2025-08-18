using UnityEngine;
using SpatialSys.UnitySDK;

public class Attacher : MonoBehaviour
{
    [SerializeField] AssetType assetType;
    [SerializeField] string assetID;

    public void EquipAttachment()
    {
        IAvatar localAvatar = SpatialBridge.actorService.localActor.avatar;
        localAvatar.EquipAttachment(assetType, assetID);
    }
}
