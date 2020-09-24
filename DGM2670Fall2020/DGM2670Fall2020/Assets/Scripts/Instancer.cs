using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    public SpawnData rotationDirection;

    public void Instance()
    {
        var location = transform.position;
        var newObj= Instantiate(prefab, location, Quaternion.Euler(this.rotationDirection.value))
        print(rotationDirection.value);
        print(newObj.transform.eulerAngles);
    }
}
