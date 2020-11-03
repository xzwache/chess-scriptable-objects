using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sound {
    public class SoundGroupUI : MonoBehaviour {
        [SerializeField] private SoundButton _soundButton;
        [SerializeField] private Text _header;

        public void Setup(string id, string[] sounds, Action<string> callback) {
            _header.text = id;
            _soundButton.Setup(sounds[0], callback);

            for (int i = 1; i < sounds.Length; i++) {
                var btn = Instantiate(_soundButton, _soundButton.transform.parent);
                btn.Setup(sounds[i], callback);
            }
        }
    }
}