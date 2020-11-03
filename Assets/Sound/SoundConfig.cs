using System;
using System.Linq;
using UnityEngine;

namespace Sound {
    [CreateAssetMenu(fileName = "SoundConfig", menuName = "Sound/Config", order = 0)]
    public class SoundConfig : ScriptableObject {
        [SerializeField] private SoundGroup[] _groups;

        public string[] GetGroupsIds() {
            return _groups.Select(group => group.ID).ToArray();
        }

        public string[] GetSoundsIds(string groupId) {
            var group = _groups.FirstOrDefault(soundGroup => soundGroup.ID == groupId);
            return group == null ? null : group.GetIds();
        }

        public SoundInfo GetSoundInfo(string id) {
            foreach (var soundGroup in _groups) {
                var sound = soundGroup.GetSoundInfo(id);
                if (sound != null) return sound;
            }

            return null;
        }
    }
}