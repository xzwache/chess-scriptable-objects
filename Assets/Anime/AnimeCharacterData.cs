
using UnityEngine;

namespace Anime {
    [CreateAssetMenu(fileName = "AnimeCharacter", menuName = "Anime/Character", order = 0)]
    public class AnimeCharacterData : ScriptableObject {
        [SerializeField] [Range(0.75f, 1.25f)] private float _legSize = 1f;
        [SerializeField] [Range(0.75f, 1.4f)] private float _kneeSize = 1f;
        [SerializeField] [Range(0.9f, 1.1f)] private float _chestSize = 1f;
        [SerializeField] [Range(0.8f, 1.4f)] private float _neckSize = 1f;
        [SerializeField] [Range(0.75f, 1.3f)] private float _breastSize = 1f;

        public Vector3 GetLegSize(Vector3 size) => new Vector3(_legSize, size.y, _legSize);
        public Vector3 GetKneeSize(Vector3 size) => new Vector3(_kneeSize, size.y, _kneeSize);
        public Vector3 ChestSize => Vector3.one * _chestSize;
        public Vector3 NeckSize => Vector3.one * _neckSize;
        public Vector3 BreastSize => Vector3.one * _breastSize;
    }
}