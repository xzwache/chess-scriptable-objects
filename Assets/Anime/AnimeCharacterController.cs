using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Anime {
    public class AnimeCharacterController : MonoBehaviour {
        
        [SerializeField] private AnimeCharacterData _data;

        [SerializeField] private Transform [] _legs;
        [SerializeField] private Transform [] _knees;
        [SerializeField] private Transform _chest;
        [SerializeField] private Transform _neck;
        [SerializeField] private Transform [] _breasts;

        private void Start() {
            UpdateCharacter();
        }
        
#if UNITY_EDITOR
        private void Update() {
            if (Selection.activeGameObject != gameObject) {
                return;
            }
            
            UpdateCharacter();
        }
#endif
        
        private void UpdateCharacter() {
            foreach (var item in _legs) { item.localScale = _data.GetLegSize(item.localScale); }
            foreach (var item in _knees) { item.localScale = _data.GetKneeSize(item.localScale); }
            foreach (var item in _breasts) { item.localScale = _data.BreastSize; }

            _chest.localScale = _data.ChestSize;
            _neck.localScale = _data.NeckSize;
        }
    }
}