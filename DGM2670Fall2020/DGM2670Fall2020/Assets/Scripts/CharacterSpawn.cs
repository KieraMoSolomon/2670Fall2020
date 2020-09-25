using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour
{
    public Vector3Data vData;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = vData.value;
    }

}
