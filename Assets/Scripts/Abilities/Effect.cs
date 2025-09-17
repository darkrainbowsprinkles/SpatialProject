using System;
using UnityEngine;

namespace Papime.Abilities
{
    public abstract class Effect : ScriptableObject
    {
        public abstract void StartEffect(GameObject user, Action finished);
    }
}