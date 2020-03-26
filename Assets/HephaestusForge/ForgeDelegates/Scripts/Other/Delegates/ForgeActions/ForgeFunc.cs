using System;
using UnityEngine;
using System.Collections.Generic;

namespace HephaestusForge.ForgeDelegates
{
    public abstract class ForgeFunc<TOut> : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
        [NonSerialized]
        private Func<TOut> _funcs;

        public override bool Invokable
        {
            get => _funcs != null;
        }

        public void OnAfterDeserialize()
        {
            _funcs = CreateDelegate<Func<TOut>>();
        }

        public void OnBeforeSerialize()
        {
        }

        public TOut Invoke()
        {
            return _funcs.Invoke();
        }

        public IEnumerable<TOut> InvokeSeperate()
        {
            foreach (Func<TOut> func in _funcs.GetInvocationList())
            {
                yield return func.Invoke();
            }
        }

        public void Add(Func<TOut> func)
        {
            _funcs += func;
        }

        public void Remove(Func<TOut> func)
        {
            _funcs -= func;
        }
    }

    public abstract class ForgeFunc<TIn, TOut> : Internal.ForgeDelegate, ISerializationCallbackReceiver
    {
#pragma warning disable 0649

        [SerializeField]
        private TIn _arg;

#pragma warning restore 0649

        [NonSerialized]
        private Func<TIn, TOut> _funcs;

        public override bool Invokable
        {
            get => _funcs != null;
        }

        public void OnAfterDeserialize()
        {
            _funcs = CreateDelegate<Func<TIn, TOut>>();
        }

        public void OnBeforeSerialize()
        {
        }

        public TOut Invoke()
        {
            return _funcs.Invoke(_arg);
        }

        public TOut Invoke(TIn arg)
        {
            return _funcs.Invoke(arg);
        }

        public IEnumerable<TOut> InvokeSeperate()
        {
            foreach (Func<TIn, TOut> func in _funcs.GetInvocationList())
            {
                yield return func.Invoke(_arg);
            }
        }

        public IEnumerable<TOut> InvokeSeperate(TIn arg)
        {
            foreach (Func<TIn, TOut> func in _funcs.GetInvocationList())
            {
                yield return func.Invoke(arg);
            }
        }

        public void Add(Func<TIn, TOut> func)
        {
            _funcs += func;
        }

        public void Remove(Func<TIn, TOut> func)
        {
            _funcs -= func;
        }
    }
}