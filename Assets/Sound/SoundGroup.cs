using System.Linq;
using UnityEngine;

namespace Sound {
    [CreateAssetMenu(fileName = "SoundGroup", menuName = "Sound/Group", order = 0)]
    public class SoundGroup : ScriptableObject {
        [SerializeField] private string _id;
        [SerializeField] private SoundInfo[] _sounds;

        public string ID => _id;
        public SoundInfo[] Sounds => _sounds;

        public string[] GetIds() {
            return _sounds.Select(sound => sound.ID).ToArray();
        }

        public SoundInfo GetSoundInfo(string soundId) {
            return _sounds.FirstOrDefault(sound => sound.ID == soundId);
        }
    }
}