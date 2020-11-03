using System;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents {
    public class GameEventsListener : MonoBehaviour {
        [SerializeField] private UnityEvent _response = new UnityEvent();
        [SerializeField] private GameEvent _event;

        private void OnEnable() {
            _event.RegisterListener(this);
        }

        private void OnDisable() {
            _event.UnregisterListener(this);
        }

        public void OnEventRaised() {
            _response.Invoke();
        }
    }
}