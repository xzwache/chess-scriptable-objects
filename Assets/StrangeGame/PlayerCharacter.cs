using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace StrangeGame {
    public class PlayerCharacter : CharacterBase {
        [SerializeField] private Transform _enemy;

        private void Update() {
            var distance = _enemy.transform.position.x - transform.position.x;
            if (distance >= 1.0f || _characterInfo.Speed < 0.0f) {
                transform.Translate(Time.deltaTime * _characterInfo.Speed * transform.forward);
            }
        }
    }
}