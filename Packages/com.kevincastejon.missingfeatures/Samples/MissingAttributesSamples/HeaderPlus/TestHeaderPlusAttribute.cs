using UnityEngine;
using KevinCastejon.MissingFeatures.MissingAttributes;

namespace KevinCastejon.MissingFeatures.MissingAttributesSamples
{
    public class TestHeaderPlusAttribute : MonoBehaviour
    {
        [HeaderPlus("Assets/Samples/MissingAttributesSamples/Shared/Icons/greencrossicon.png", "Health", (int)HeaderPlusColor.green)]
        [SerializeField] private int _currentHealth;
        [SerializeField] private int _maxHealth;
        [HeaderPlus("Assets/Samples/MissingAttributesSamples/Shared/Icons/atk.png", "Attack", (int)HeaderPlusColor.red)]
        [SerializeField] private int _damagePoints;
        [SerializeField] private int _attackSpeed;
    }
}
