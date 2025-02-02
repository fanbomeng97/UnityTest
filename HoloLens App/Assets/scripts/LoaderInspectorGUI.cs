﻿using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(ConnectorLoader))]
public class LoaderInspectortGUI : Editor
{
    private SerializedObject test;
    private SerializedProperty TargetScene, ModelName, ModelPosition, ModelRotation, ModelScale, Manipulable, ManipulationType;
    void OnEnable()
    {
        test = new SerializedObject(target);
        TargetScene = test.FindProperty("TargetScene");
        ModelName = test.FindProperty("ModelName");
        ModelPosition = test.FindProperty("ModelPosition");
        ModelRotation = test.FindProperty("ModelRotation");
        ModelScale = test.FindProperty("ModelScale");
        Manipulable = test.FindProperty("Manipulable");
        ManipulationType = test.FindProperty("TwoHandsManipulationType");
    }
    public override void OnInspectorGUI()
    {
        //test.Update();
        EditorGUILayout.PropertyField(TargetScene);
        EditorGUILayout.PropertyField(ModelName);
        EditorGUILayout.PropertyField(ModelPosition);
        EditorGUILayout.PropertyField(ModelRotation);
        EditorGUILayout.PropertyField(ModelScale);
        EditorGUILayout.PropertyField(Manipulable);
        if (Manipulable.boolValue)
        {
            EditorGUILayout.PropertyField(ManipulationType);
        }
        test.ApplyModifiedProperties();
    }
}