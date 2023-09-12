using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{

    
    [SerializeField] private PlayerController player;
    [SerializeField] private TMP_Text  text;


    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        text.text = player.Addkey().ToString();
    }
}
