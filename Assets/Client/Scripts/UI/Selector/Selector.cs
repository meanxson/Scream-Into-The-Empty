using System;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    [field: SerializeField] public float Duration { get; private set; }
    private Image _image;

    private void Awake() => _image = GetComponent<Image>();

    private void Start()
    {
        if (!gameObject.activeSelf)
            return;

        gameObject.SetActive(false);
    }
}