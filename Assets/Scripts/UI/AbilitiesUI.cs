using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Papime.Abilities;

namespace Papime.UI
{
    public class AbilitiesUI : MonoBehaviour
    {
        [SerializeField] AbilityStore abilityStore;
        [SerializeField] TMP_Text abilityNameText;
        [SerializeField] Image abilityIcon;

        void OnEnable()
        {
            abilityStore.onAbilityCycled += RefreshUI;
        }

        void OnDisable()
        {
            abilityStore.onAbilityCycled -= RefreshUI;
        }

        void RefreshUI()
        {
            abilityNameText.text = abilityStore.GetCurrentAbility().GetDisplayName();
            abilityIcon.sprite = abilityStore.GetCurrentAbility().GetIcon();
        }
    }
}
