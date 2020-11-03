using System;
using UnityEngine;

namespace StrangeGame {
    public class InputController : MonoBehaviour {
        [SerializeField] private FloatVariable _enymyHp;
        [SerializeField] private FloatVariable _playerSpeed;
        [SerializeField] private Transform _enemyTransform;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private Camera _camera;

        private void Update() {
            if (Input.GetMouseButtonDown(0)) {
                var distance = Mathf.Abs(_playerTransform.position.x - _enemyTransform.position.x);
                if (distance < 1.5f) {
                    var ray = _camera.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out var hit)) {
                        if (hit.transform == _enemyTransform)
                            _enymyHp.Value -= 0.5f;
                    }
                }
            }

            _playerSpeed.Value = Input.GetAxis("Horizontal");
        }
    }
}