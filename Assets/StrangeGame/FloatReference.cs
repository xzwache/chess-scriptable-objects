using System;
using System.Collections;
using System.Collections.Generic;
using StrangeGame;
using UnityEngine;

[Serializable]
public class FloatReference {

    [SerializeField] private bool _useConstants = default;
    [SerializeField] private float _constantValue = default;

    [SerializeField] private FloatVariable _variable;

    public FloatReference() {
        _useConstants = true;
    }

    public FloatReference(float value) {
        _useConstants = true;
        _constantValue = value;
    }

    public float Value => _useConstants ? _constantValue : _variable.Value;
    public FloatVariable Variable => _variable;

    public static implicit operator float(FloatReference reference) {
        return reference.Value;
    }
}
