using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Core
{
    public class GameSettings : MonoBehaviour
    {
        [SerializeField] SpatialCameraRotationMode cameraRotationMode;

        void Start()
        {
            SpatialBridge.cameraService.rotationMode = cameraRotationMode;
        }
    }
}