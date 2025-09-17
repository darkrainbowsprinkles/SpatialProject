using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Core
{
    public class CameraModeSetter : MonoBehaviour
    {
        [SerializeField] SpatialCameraRotationMode cameraRotationMode;

        void Start()
        {
            SpatialBridge.cameraService.rotationMode = cameraRotationMode;
        }
    }
}