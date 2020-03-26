using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HephaestusForge.ForgeDelegates
{
    public class Demo : MonoBehaviour
    {
#pragma warning disable 0649

        [SerializeField]
        private ForgeAction _forgeAction;

#pragma warning restore 0649


        // Start is called before the first frame update
        void Start()
        {
            _forgeAction.Invoke();
        }

        private void Test()
        {

#if UNITY_EDITOR || DEVELOPMENT_BUILD
            Debug.Log("Test");
#endif

        }

        public void T()
        {

#if UNITY_EDITOR || DEVELOPMENT_BUILD
            Debug.Log("T");
#endif

        }
    }
}