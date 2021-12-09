using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Client.Scripts.UI.Button
{
    public class ButtonSelector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private Selector _selector;
        [SerializeField] private Color _selectColor;
        private TMP_Text _text;
        private Color _defaultColor;

        private void Awake() => _text = GetComponentInChildren<TMP_Text>();

        private void Start() => _defaultColor = _text.color;

        public void OnPointerEnter(PointerEventData eventData)
        {
            _text.DOColor(_selectColor, _selector.Duration);
            _selector.transform.DOMove(transform.position, _selector.Duration).OnStart(() =>
            {
                _selector.gameObject.SetActive(true);
            });
        }

        public void OnPointerExit(PointerEventData eventData) => _text.DOColor(_defaultColor, _selector.Duration);
    }
}