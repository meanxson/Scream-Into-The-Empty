using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Client.Scripts.Effects
{
    public class BrokenLightEffect : MonoBehaviour
    {
        [SerializeField] private Light _light;

        private Coroutine _brokenEffect;

        private void Start() => _brokenEffect = StartCoroutine(BrokenEffect());

        private void OnDisable() => StopCoroutine(_brokenEffect);

        private IEnumerator BrokenEffect()
        {
            while (true)
            {
                var randomIteration = Random.Range(0, 10);
                for (var i = 0; i < randomIteration; i++)
                {
                    _light.enabled = !_light.isActiveAndEnabled;
                    yield return new WaitForSeconds(Random.Range(0.01f, 0.2f));
                }
                yield return new WaitForSeconds(Random.Range(1, 5));
            }
        }
    }
}