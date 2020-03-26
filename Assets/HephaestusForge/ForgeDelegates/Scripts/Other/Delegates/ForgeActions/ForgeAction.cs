using System;
using UnityEngine;

namespace HephaestusForge.ForgeDelegates
{
    [Serializable]
    public sealed class ForgeAction : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
        [NonSerialized]
        private Action _actions;

        public override bool Invokable
        {
            get => _actions != null;
        }

        public void OnAfterDeserialize()
        {
            _actions = CreateDelegate<Action>();
        }

        public void OnBeforeSerialize()
        {            
        }

        public void Invoke()
        {
            _actions.Invoke();
        }

        public void Add(Action action)
        {
            _actions = action;
        }

        public void Remove(Action action)
        {
            _actions -= action;
        }
    }

    public abstract class ForgeActione<TIn> : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
#pragma warning disable 0649

        [SerializeField]
        private TIn _arg;

#pragma warning restore 0649

        [NonSerialized]
        private Action<TIn> _actions;

        public override bool Invokable
        {
            get => _actions != null;
        }

        public void OnAfterDeserialize()
        {
            _actions = CreateDelegate<Action<TIn>>();
        }

        public void OnBeforeSerialize()
        {            
        }

        public void Invoke()
        {
            _actions.Invoke(_arg);
        }

        public void Invoke(TIn arg)
        {
            _actions.Invoke(arg);
        }

        public void Add(Action<TIn> action)
        {
            _actions = action;
        }

        public void Remove(Action<TIn> action)
        {
            _actions -= action;
        }
    }

    public abstract class ForgeActione<TInOne, TInTwo> : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
#pragma warning disable 0649

        [SerializeField]
        private TInOne _argOne;

        [SerializeField]
        private TInTwo _argTwo;

#pragma warning restore 0649

        [NonSerialized]
        private Action<TInOne, TInTwo> _actions;

        public override bool Invokable
        {
            get => _actions != null;
        }

        public void OnAfterDeserialize()
        {
            _actions = CreateDelegate<Action<TInOne, TInTwo>>();
        }

        public void OnBeforeSerialize()
        {
        }

        public void Invoke()
        {
            _actions.Invoke(_argOne, _argTwo);
        }

        public void Invoke(TInOne argOne, TInTwo argTwo)
        {
            _actions.Invoke(argOne, argTwo);
        }

        public void Add(Action<TInOne, TInTwo> action)
        {
            _actions = action;
        }

        public void Remove(Action<TInOne, TInTwo> action)
        {
            _actions -= action;
        }
    }

    public abstract class ForgeActione<TInOne, TInTwo, TInThree> : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
#pragma warning disable 0649

        [SerializeField]
        private TInOne _argOne;

        [SerializeField]
        private TInTwo _argTwo;

        [SerializeField]
        private TInThree _argThree;

#pragma warning restore 0649

        [NonSerialized]
        private Action<TInOne, TInTwo, TInThree> _actions;

        public override bool Invokable
        {
            get => _actions != null;
        }

        public void OnAfterDeserialize()
        {
            _actions = CreateDelegate<Action<TInOne, TInTwo, TInThree>>();
        }

        public void OnBeforeSerialize()
        {
        }

        public void Invoke()
        {
            _actions.Invoke(_argOne, _argTwo, _argThree);
        }

        public void Invoke(TInOne argOne, TInTwo argTwo, TInThree argThree)
        {
            _actions.Invoke(argOne, argTwo, argThree);
        }

        public void Add(Action<TInOne, TInTwo, TInThree> action)
        {
            _actions = action;
        }

        public void Remove(Action<TInOne, TInTwo, TInThree> action)
        {
            _actions -= action;
        }
    }

    public abstract class ForgeActione<TInOne, TInTwo, TInThree, TInFour> : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
#pragma warning disable 0649

        [SerializeField]
        private TInOne _argOne;

        [SerializeField]
        private TInTwo _argTwo;

        [SerializeField]
        private TInThree _argThree;

#pragma warning restore 0649

        [NonSerialized]
        private Action<TInOne, TInTwo, TInThree> _actions;

        public override bool Invokable
        {
            get => _actions != null;
        }

        public void OnAfterDeserialize()
        {
            _actions = CreateDelegate<Action<TInOne, TInTwo, TInThree>>();
        }

        public void OnBeforeSerialize()
        {
        }

        public void Invoke()
        {
            _actions.Invoke(_argOne, _argTwo, _argThree);
        }

        public void Invoke(TInOne argOne, TInTwo argTwo, TInThree argThree)
        {
            _actions.Invoke(argOne, argTwo, argThree);
        }

        public void Add(Action<TInOne, TInTwo, TInThree> action)
        {
            _actions = action;
        }

        public void Remove(Action<TInOne, TInTwo, TInThree> action)
        {
            _actions -= action;
        }
    }
}
