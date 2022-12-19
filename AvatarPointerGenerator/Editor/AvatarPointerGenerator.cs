using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using ABI.CCK.Components;

namespace AvatarPointerGenerator
{
    public class AvatarPointerGenerator : EditorWindow
    {
        private CVRAvatar avatar;

        [MenuItem("Tools/Avatar Pointer Generator")]
        public static void ShowWindow()
        {
            var window = (AvatarPointerGenerator)GetWindow(typeof(AvatarPointerGenerator), false, "Avatar Pointer Generator");
            window.Show();
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Selected Avatar", EditorStyles.boldLabel);
            avatar = (CVRAvatar)EditorGUILayout.ObjectField(avatar, typeof(CVRAvatar), true);
            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("Use Selection"))
            {
                GameObject[] selectedObjects = Selection.gameObjects;
                if (selectedObjects != null)
                {
                    avatar = selectedObjects.Select(obj => obj.GetComponentInParent<CVRAvatar>()).FirstOrDefault();
                }
            }

            EditorGUI.BeginDisabledGroup(avatar == null);
            if (GUILayout.Button("Generate Pointers"))
            {
                ColliderGen.GenerateDefaultColliders(avatar);
            }
            EditorGUI.EndDisabledGroup();
        }
    }
}
