using UnityEngine;

namespace Papime.Core
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] float rotationSpeed = 10f;

        void Update()
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
        }
    }
}