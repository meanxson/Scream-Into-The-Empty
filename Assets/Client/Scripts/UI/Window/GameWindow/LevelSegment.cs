using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSegment : MonoBehaviour
{
    [SerializeField] private string _nameOfLevel;
    [SerializeField] private bool _isUnlock;

    private Button _button;
    private TMP_Text _text;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _text = GetComponentInChildren<TMP_Text>();
    }

    private void Start()
    {
        if (_isUnlock) _button.interactable = false;
        _text.text = _nameOfLevel;
    }
}