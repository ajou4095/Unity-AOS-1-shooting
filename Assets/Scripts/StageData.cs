using UnityEngine;

// [CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
[CreateAssetMenu]
public class StageData : ScriptableObject
{
    [SerializeField]
    private Vector2 limitMin;
    [SerializeField]
    private Vector2 limitMax;
    
    public Vector2 LimitMin => limitMin;
    public Vector2 LimitMax => limitMax;
}
