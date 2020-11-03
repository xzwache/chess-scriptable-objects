using UnityEngine;

namespace StrangeGame {
    [CreateAssetMenu(fileName = "CharacterInfo", menuName = "Character/Info", order = 0)]
    public class CharacterInfo : ScriptableObject {
        [SerializeField] private FloatReference _hp;
        [SerializeField] private FloatReference _speed;

        public FloatReference Hp => _hp;
        public FloatReference Speed => _speed;
    }
}