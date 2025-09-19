using System;
using UnityEngine;

namespace Papime.Abilities
{
    public class AbilityStore : MonoBehaviour
    {
        [SerializeField] KeyCode cycleAbilityKey;
        [SerializeField] KeyCode useAbilityKey;
        [SerializeField] Ability[] abilities;
        public event Action onAbilityCycled;
        int currentAbilityIndex = -1;
        Ability currentAbility;

        public Ability GetCurrentAbility()
        {
            return abilities[currentAbilityIndex];
        }

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
            onAbilityCycled?.Invoke();
        }
    }
}