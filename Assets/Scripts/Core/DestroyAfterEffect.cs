using UnityEngine;

public class DestroyAfterEffect : MonoBehaviour
{
    new ParticleSystem particleSystem;

    void Awake()
    {
        particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        if (!particleSystem.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
