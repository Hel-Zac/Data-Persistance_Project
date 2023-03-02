using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    private Text bestScore;
    void Start()
    {
        bestScore = GetComponent<Text>();
        Actualise();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Actualise()
    {
        if(SavedData.bestScore != 0)
        {
            bestScore.text = "Best Score :\n" + SavedData.nameBest + " : " + SavedData.bestScore.ToString();
        }
        else
        {
            bestScore.text = " ";
        }
    }
}
