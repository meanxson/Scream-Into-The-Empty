using System.Collections.Generic;
using UnityEngine;

namespace ObservableVariable
{
    public class ObservableLogger : IObserver
    {
        private readonly List<IObservable> _observables;

        public ObservableLogger()
        {
            _observables = new List<IObservable>();
        }

        public ObservableLogger(IObservable observable)
        {
            _observables = new List<IObservable> {observable};
            observable.OnChanged += OnChanged;
        }

        public ObservableLogger(IObservable[] observables)
        {
            _observables = new List<IObservable>(observables);

            foreach (var observable in observables)
            {
                observable.OnChanged += OnChanged;
            }
        }

        private void OnChanged(object obj)
        {
            Debug.Log($"{obj.GetType().Namespace} value changed. New Value {obj}");
        }

        public void AddObservable(IObservable observable)
        {
            if (_observables.Contains(observable))
                return;

            _observables.Add(observable);
            observable.OnChanged += OnChanged;
        }

        public void Dispose()
        {
            foreach (var observable in _observables)
                observable.OnChanged -= OnChanged;
        }
    }
}