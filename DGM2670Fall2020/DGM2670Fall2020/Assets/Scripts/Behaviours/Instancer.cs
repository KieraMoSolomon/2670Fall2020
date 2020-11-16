using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    //public Vector3Data rotationDirection;

    public void Instance()
    {
        var location = transform.position;
        var newObj = Instantiate(prefab);
        //var newObj = Instantiate(prefab, location, Quaternion.Euler(this.rotationDirection.value));
    }
}
