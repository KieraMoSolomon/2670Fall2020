using UnityEngine;
[CreateAssetMenu]
public class SpawnData : ScriptableObject
{
    public Vector3 value;

    public Vector3 SetPosition()
    {
        return value;
    }
}
