using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour
{
    public SpawnData startSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = startSpawn.value;
    }

}
