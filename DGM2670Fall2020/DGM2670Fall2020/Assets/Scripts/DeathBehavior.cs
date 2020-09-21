using UnityEngine;

public class DeathBehavior : MonoBehaviour
{
    public SpawnData startPoint;
    public GameObject obj;
    public void OnTriggerEnter(Collider other)
    {  
        Debug.Log("Trigger!!!!");
        Debug.Log(obj.transform.position);
        obj.transform.position = new Vector3(1f, 0f, 0f);
        Debug.Log(obj.transform.position);

        //other.transform.position = startPoint.value;
        
        
    }
}
