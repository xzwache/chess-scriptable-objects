using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sound;

public class SoundsPlayer : MonoBehaviour
{
    [SerializeField] private SoundConfig _soundConfig;
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private Sound.SoundGroupUI _soundGroupUi;

    private void Start()
    {
        var groups = _soundConfig.GetGroupsIds();

        for (var i = 1; i < groups.Length; i++)
        {
            var ids = _soundConfig.GetSoundsIds(groups[i]);

            var group = Instantiate(_soundGroupUi, _soundGroupUi.transform.parent);
            group.Setup(groups[i], ids, PlaySound);
        }
        _soundGroupUi.Setup(groups[0], _soundConfig.GetSoundsIds(groups[0]), PlaySound);
    }

    private void PlaySound(string id)
    {
        _audioSource.Stop();
        var info = _soundConfig.GetSoundInfo(id);

        if (info == null)
            return;

        _audioSource.clip = info.Clip;
        _audioSource.loop = info.Loop;
        _audioSource.pitch = info.Pitch;
        _audioSource.volume = info.Volume;

        _audioSource.Play();
    }
}