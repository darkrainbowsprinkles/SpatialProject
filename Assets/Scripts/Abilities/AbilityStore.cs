using System;
using UnityEngine;

namespace Papime.Abilities
{
    public class AbilityStore : MonoBehaviour
    {
        [SerializeField] KeyCode cycleAbilityKey;
        [SerializeField] KeyCode useAbilityKey;
        [SerializeField] Ability[] abilities;
        int currentAbilityIndex = -1;
        Ability currentAbility;

        void Update()
        {
            if (Input.GetKeyDown(cycleAbilityKey))
            {
                CycleCurrentAbility();
            }

            if (Input.GetKeyDown(useAbilityKey))
            {
                Use();
            }
        }

        void Use()
        {
            if (currentAbility != null)
            {
                return;
            }

            currentAbility = abilities[currentAbilityIndex];
            currentAbility.Use(gameObject, CancelCurrentAbility);
        }

        void CancelCurrentAbility()
        {
            currentAbility = null;
        }

        void CycleCurrentAbility()
        {
            if (currentAbility != null)
            {
                return;
            }

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