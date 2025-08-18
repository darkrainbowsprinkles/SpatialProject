using UnityEngine;
using SpatialSys.UnitySDK;

public class TestScript : MonoBehaviour
{
    public void PrintMessage(string message)
    {
        SpatialBridge.coreGUIService.DisplayToastMessage(message);
    }
}
