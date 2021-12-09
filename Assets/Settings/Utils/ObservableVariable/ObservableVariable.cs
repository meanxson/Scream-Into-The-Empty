﻿using System;

namespace ObservableVariable
{
    public class ObservableVariable<T> : IObservable
    {
        public event Action<object> OnChanged;

        private T _value;

        public T Value
        {
            get => _value;
            set
            {  
                _value = value;
                OnChanged?.Invoke(value);
            }
        }

        public ObservableVariable()
        {
            Value = default;
        }

        public ObservableVariable(T value)
        {
            _value = value;
        }

        public override string ToString() => $"{Value}";
    }
}