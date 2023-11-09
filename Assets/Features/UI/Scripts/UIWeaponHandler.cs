using TMPro;
using UnityEngine;

namespace Features.UI.Scripts
{
    public class UIWeaponHandler : MonoBehaviour
    {
        [SerializeField] private WeaponView _weapon;
        [SerializeField] private TMP_Text _text;

        private int _count;

        public void Reset()
        {
            _count = 0;
            UpdateUICounter();
        }
        
        private void OnEnable()
        {
            UpdateUICounter();
            _weapon.EnemyHitEvent += OnEnemyHitEvent;
        }

        private void UpdateUICounter()
        {
            _text.text = _count.ToString();
        }

        private void OnEnemyHitEvent(object sender, int e)
        {
            _count++;
            UpdateUICounter();
        }

        private void OnDisable()
        {
            _weapon.EnemyHitEvent -= OnEnemyHitEvent;
        }
    }
}