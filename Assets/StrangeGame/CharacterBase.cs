using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StrangeGame;

public abstract class CharacterBase : MonoBehaviour {

    [SerializeField] protected StrangeGame.CharacterInfo _characterInfo;
    [SerializeField] private Image _healthImage;

    protected float _maxHP;

    private void OnEnable() {
        _maxHP = _characterInfo.Hp;
        OnHPChanged(_maxHP);

        _characterInfo.Hp.Variable.OnValueChanged += OnHPChanged;
    }

    private void OnDisable() {
        _characterInfo.Hp.Variable.OnValueChanged -= OnHPChanged;
    }

    private void OnHPChanged(float hp) {
        _healthImage.fillAmount = hp / _maxHP;
    }
}
