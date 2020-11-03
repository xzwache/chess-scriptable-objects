using System.Collections;
using System.Collections.Generic;
using GameEvents;
using UnityEngine;

[CreateAssetMenu(fileName = "SwordData", menuName = "Items/Swords", order = 0)]
public class SwordData : ScriptableObject {
    [SerializeField] private string _swordName;
    [SerializeField] private string _description;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _cost;
    [SerializeField] private int _damage;

    [Range(0f, 180f)] [SerializeField] private float _rotationSpeed;

    [SerializeField] private GameEvent _updateEvent;
    
    public string SwordName => _swordName;
    public string Description => _description;
    public GameObject Prefab => _prefab;
    public Sprite Icon => _icon;
    public int Cost => _cost;
    public int Damage => _damage;
    public float RotationSpeed => _rotationSpeed;

    [ContextMenu("UpdateData")]
    public void UpdateData() {
        _updateEvent.Raise();
    }
}
