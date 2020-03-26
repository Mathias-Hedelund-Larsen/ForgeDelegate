using System;
using UnityEngine;
using System.Reflection;

namespace HephaestusForge.ForgeDelegates.Internal
{
    [Serializable]
    public abstract class ForgeDelegate
    {
#pragma warning disable 0649

        [SerializeField]
        private string[] _methodNames;

        [SerializeField]
        private UnityEngine.Object[] _targets;

#pragma warning restore 0649

        public abstract bool Invokable { get; }

        protected T CreateDelegate<T>() where T : Delegate
        {
            T[] forgeDelegates = new T[_methodNames.Length];

            for (int i = 0; i < _methodNames.Length; i++)
            {
                forgeDelegates[i] = (T)Delegate.CreateDelegate(typeof(T), _targets[i],
                    _targets[i].GetType().GetMethod(_methodNames[i], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
            }

            return (T)Delegate.Combine(forgeDelegates);
        }
    }
}
