using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

[CustomEditor(typeof(Client_Caller))]
public class ClientCaller_Editor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement myInspector = new VisualElement();

        Button button = new Button(() => ((Client_Caller)target).Call_Client());
        button.text = "Call Client";
        myInspector.Add(button);

        return myInspector;
    }
}
