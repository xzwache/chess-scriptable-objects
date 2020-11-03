using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sound {
    public class SoundButton : MonoBehaviour {
        [SerializeField] private Button _button;
        [SerializeField] private Text _buttonText;

        private string _id;
        private Action<string> _onPlaySoundCallback;

        public void Setup(string soundId, Action<string> callback) {
            _buttonText.text = soundId;
            _id = soundId;
            _onPlaySoundCallback = callback;
        }

        private void OnEnable() {
            _button.onClick.AddListener(OnSoundButtonClicked);            
        }

        private void OnDisable() {
            _button.onClick.RemoveListener(OnSoundButtonClicked);
        }

        private void OnSoundButtonClicked() {
            _onPlaySoundCallback?.Invoke(_id);
        }
    }
}