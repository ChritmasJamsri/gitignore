using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private int score = 0;
    [SerializeField] private int scorekey = 0;
    [SerializeField] private int Key = 0;

    private Rigidbody rb;

    public void AddScore()
    {
        score = score + 1;
    }

    public void AddScorekey()
    {
        scorekey = scorekey +1 ;
    }

    public int Addkey()
    {
        return scorekey;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f;
        float Y = 0.0f;
        
        if (Input.GetKey(KeyCode.A)) 
        {
            Y = rotationSpeed * Time.deltaTime;
        }



        else if (Input.GetKey(KeyCode.D)) 
        {
            Y = -rotationSpeed * Time.deltaTime;
        }
        


        else if (Input.GetKey(KeyCode.W))
        {
            x = rotationSpeed * Time.deltaTime;
        }


        else if (Input.GetKey(KeyCode.S))
        {
           x  = -rotationSpeed * Time.deltaTime;
        }

        rb.AddTorque(x, 0, Y);

    }
}
