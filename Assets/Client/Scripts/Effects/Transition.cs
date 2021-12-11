using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Scripts.Effects
{
    public class Transition : MonoBehaviour
    {
        [SerializeField] private float _duration;
        private Image _image;

        private void Awake() => _image = GetComponent<Image>();

        private void Start()
        {
            _image.DOFade(1, 0);
        }

        public void FadeIn()
        {
            _image.DOFade(1, _duration).OnStart((() => { gameObject.SetActive(true); }));
        }


        public void FadeOut()
        {
            _image.DOFade(0, _duration).OnComplete((() => { gameObject.SetActive(false); }));
        }
    }
}