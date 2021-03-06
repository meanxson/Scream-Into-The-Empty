using Client.Scripts.Common;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Client.Scripts.UI.Window.Windows.SettingWindow
{
    public class VolumeSettingModel
    {
        private readonly Slider[] _slider;
        private readonly AudioMixer _mixer;

        private readonly string[] _prefs;

        public VolumeSettingModel(Slider[] slider, AudioMixer mixer)
        {
            _slider = slider;
            _mixer = mixer;

            _prefs = new[]
            {
                PlayerPrefsConstant.Setting.Master, PlayerPrefsConstant.Setting.Music,
                PlayerPrefsConstant.Setting.Effect, PlayerPrefsConstant.Setting.Voice
            };
        }

        //TODO: Refactoring - BAD PRACTICING
        public void OnMasterChanged(float value)
        {
            const int index = 0;
            Change(index, value);
        }

        public void OnMusicChanged(float value)
        {
            const int index = 1;
            Change(index, value);
        }

        public void OnEffectChanged(float value)
        {
            const int index = 2;
            Change(index, value);
        }

        public void OnVoiceChanged(float value)
        {
            const int index = 3;
            Change(index, value);
        }

        private void Change(int index, float value)
        {
            _slider[index].value = value;
            PlayerPrefs.SetFloat(_prefs[index], value);
            _mixer.SetFloat(_prefs[index], value);
            PlayerPrefs.Save();
        }
    }
}