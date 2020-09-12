using UnityEngine;

public class HealthPattern : MonoBehaviour
{
    public FloatData myHeath, startHealth;

    public MoveData deathMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        myHeath.value = startHealth.value;
        Debug.Log(myHeath.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            myHeath.value--;
            
            Debug.Log(myHeath.value);
        }
        if (myHeath.value <= 0)
        {
            Debug.Log("You died");
            GetComponent<CharacterMovement>().movePattern = deathMovement;
            //respawn
            //die
        }
    }
}
