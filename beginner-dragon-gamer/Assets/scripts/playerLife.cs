using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLife : MonoBehaviour
{
    public int maximumLife;
    public int currentLife;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maximumLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage()
    {
        currentLife -= 1;
        if (currentLife <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
