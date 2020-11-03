using System;
using UnityEngine;

namespace StrangeGame {
    public class EnemyCharacter : CharacterBase {
        [SerializeField] private Transform _player;
        [SerializeField] private FloatVariable _playerHp;

        protected void Update() {
            if (Mathf.Abs(_player.transform.position.x - transform.position.x) > 1f) {
                transform.Translate(Time.deltaTime * _characterInfo.Speed * transform.forward, Space.World);
                return;
            }

            _playerHp.Value -= Time.deltaTime;
        }
    }
}