using UnityEngine;

namespace Papime.Abilities
{
    public class AbilityStore : MonoBehaviour
    {
        [SerializeField] KeyCode cycleAbilityKey;
        [SerializeField] KeyCode useAbilityKey;
        [SerializeField] Ability[] abilities;
        int currentAbilityIndex = 0;
        bool initialAttachmentDone = false;

        void Update()
        {
            if (!initialAttachmentDone)
            {
                abilities[0].Attach();
                initialAttachmentDone = true;
            }

            if (Input.GetKeyDown(cycleAbilityKey))
            {
                CycleCurrentAbility();
            }

            if (Input.GetKeyDown(useAbilityKey))
            {
                UseCurrentAbility();
            }
        }

        void UseCurrentAbility()
        {
            abilities[currentAbilityIndex].Use(gameObject);
        }

        void CycleCurrentAbility()
        {
            if (currentAbilityIndex == abilities.Length - 1)
            {
                currentAbilityIndex = 0;
            }
            else
            {
                currentAbilityIndex++;
            }

            abilities[currentAbilityIndex].Attach();
        }
    }
}