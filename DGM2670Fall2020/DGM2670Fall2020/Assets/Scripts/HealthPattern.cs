using UnityEngine;

public class HealthPattern : MonoBehaviour
{
    public FloatData myHeath, startHealth;

    public MoveData deathMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        myHeath.value = startHealth.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (myHeath.value == 0)
        {
            Debug.Log("You died");
            GetComponent<CharacterMovement>().movePattern = deathMovement;
            //die
        }
    }
}
