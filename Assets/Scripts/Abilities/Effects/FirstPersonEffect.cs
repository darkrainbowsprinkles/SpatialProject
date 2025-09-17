using System;
using System.Collections;
using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Abilities.Effects
{
    [CreateAssetMenu(menuName = "Papime/Abilities/Effects/First Person Effect")]
    public class FirstPersonEffect : Effect
    {
        public override void StartEffect(GameObject user, Action finished)
        {
            user.GetComponent<MonoBehaviour>().StartCoroutine(FirstPersonRoutine(finished));
        }

        IEnumerator FirstPersonRoutine(Action finished)
        {
            SpatialBridge.cameraService.forceFirstPerson = true;
            yield return new WaitUntil(() => Input.GetKey(KeyCode.Mouse1));
            SpatialBridge.cameraService.forceFirstPerson = false;
            finished();
        }
    }
}