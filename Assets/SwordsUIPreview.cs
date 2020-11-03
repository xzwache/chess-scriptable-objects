using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordsUIPreview : MonoBehaviour {

    [SerializeField] private SwordData _swordData;
    [SerializeField] private Transform _rootPoint;
    [SerializeField] private Text _nameLabel;
    [SerializeField] private Text _descriptionLabel;
    [SerializeField] private Image _iconImage;
    [SerializeField] private Text _costLabel;
    [SerializeField] private Text _damageLabel;

    private GameObject _swordObject;
    
    void Start() {
        SetupData();
    }
    
    void Update()
    {
        _rootPoint.Rotate(Time.deltaTime * _swordData.RotationSpeed * Vector3.up, Space.World);
    }

    public void SetupData() {
        if (_swordObject != null) {
            Destroy(_swordObject);
        }
        
        _swordObject = Instantiate(_swordData.Prefab, _rootPoint);
        _swordObject.transform.localScale = Vector3.one * 30f;
        _nameLabel.text = _swordData.SwordName;
        _descriptionLabel.text = _swordData.Description;
        _iconImage.sprite = _swordData.Icon;
        _costLabel.text = $"Cost: {_swordData.Cost}";
        _damageLabel.text = $"Damage: {_swordData.Damage}";
    }
}
