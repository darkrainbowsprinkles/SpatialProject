using UnityEngine;
using SpatialSys.UnitySDK;

public class CameraModeSetter : MonoBehaviour
{
    [SerializeField] SpatialCameraRotationMode cameraRotationMode;

    void Start()
    {
        SpatialBridge.cameraService.rotationMode = cameraRotationMode;
    }
}
