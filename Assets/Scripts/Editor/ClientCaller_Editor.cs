using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System;

[CustomEditor(typeof(Client_Caller))]
public class ClientCaller_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Call Client"))
        {
            Client_Caller caller = (Client_Caller)target;
            Utils.ClearLogConsole();
            caller.Call_Client();
        }
    }
}


public static class Utils
{
    static MethodInfo _clearConsoleMethod;
    static MethodInfo clearConsoleMethod
    {
        get
        {
            if (_clearConsoleMethod == null)
            {
                Assembly assembly = Assembly.GetAssembly(typeof(SceneView));
                Type logEntries = assembly.GetType("UnityEditor.LogEntries");
                _clearConsoleMethod = logEntries.GetMethod("Clear");
            }
            return _clearConsoleMethod;
        }
    }

    public static void ClearLogConsole()
    {
        clearConsoleMethod.Invoke(new object(), null);
    }
}