using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents {
    [CreateAssetMenu(fileName = "GameEvent", menuName = "Items/GameEvent", order = 0)]
    public class GameEvent : ScriptableObject {
        private readonly List<GameEventsListener> _listeners = new List<GameEventsListener>();

        public void Raise() {
            for (int i = _listeners.Count - 1; i >= 0; i--) {
                _listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventsListener listener) {
            _listeners.Add(listener);
        }
        
        public void UnregisterListener(GameEventsListener listener) {
            _listeners.Remove(listener);
        }
    }
}
