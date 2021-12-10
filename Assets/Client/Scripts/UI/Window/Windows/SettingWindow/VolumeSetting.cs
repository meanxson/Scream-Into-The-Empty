using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Client.Scripts.UI.Window.Windows.SettingWindow
{
    public class VolumeSetting : MonoBehaviour
    {
        [SerializeField] private Slider[] _sliders;
        [SerializeField]private AudioMixer _mixer;
        
        private VolumeSettingModel _model;

        private void Awake()
        {
            _model = new VolumeSettingModel(_sliders, _mixer);
        }

        private void OnEnable() 
            => Sign(_model.OnMasterChanged, _model.OnMusicChanged, _model.OnEffectChanged, _model.OnVoiceChanged);

        private void Sign(params UnityAction<float>[] actions)
        {
            for (var i = 0; i < _sliders.Length; i++) 
                _sliders[i].onValueChanged.AddListener(actions[i]);
        }


        [Button]
        private void InitSliders() => _sliders = GetComponentsInChildren<Slider>();
    }
}