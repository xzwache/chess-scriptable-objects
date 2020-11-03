using System;
using UnityEngine;

namespace StrangeGame {
    [CreateAssetMenu(fileName = "FloatVariable", menuName = "Variables/Float", order = 0)]
    public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver {
        public event Action<float> OnValueChanged;
        [SerializeField] private float _initialValue = default;

        private float _value;

        public float Value {
            get => _value;
            set {
                this._value = value;
                OnValueChanged?.Invoke(value);
            }
        }

        public float InitialiValue => _initialValue;

        public void OnBeforeSerialize() { }

        public void OnAfterDeserialize() {
            _value = _initialValue;
        }
    }
}