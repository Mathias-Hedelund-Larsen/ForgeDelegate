using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace HephaestusForge.ForgeDelegates
{
    [CustomPropertyDrawer(typeof(Internal.ForgeDelegate), true)]
    public class ForgeDelegatePropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            
        }
    }
}