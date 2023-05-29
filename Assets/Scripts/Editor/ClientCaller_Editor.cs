using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

[CustomEditor(typeof(Client_Caller))]
public class ClientCaller_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Call Client"))
        {
            Client_Caller caller = (Client_Caller)target;
            caller.Call_Client();
        }
    }
}
