using UnityEngine;
[CreateAssetMenu]
public class SpawnData : ScriptableObject
{
    public Vector3 value;

    public void SetValueFromTransform(Vector3 obj)
    {
        value = obj;
    }
}
