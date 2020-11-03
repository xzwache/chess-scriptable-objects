using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundInfo", menuName = "Sound/Info", order = 0)]
public class SoundInfo : ScriptableObject {
    [SerializeField] private string _id;
    [SerializeField] private AudioClip _clip;
    [SerializeField] private bool _loop;
    [SerializeField] [Range(0f, 1f)] private float _volume = 1;
    [SerializeField] [Range(0f, 3f)] private float _pitch = 1;
    
    public string ID => _id;
    public AudioClip Clip => _clip;
    public bool Loop => _loop;
    public float Volume => _volume;
    public float Pitch => _pitch;
}
