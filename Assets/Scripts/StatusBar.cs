using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{

    [SerializeField] int maxScore = 100;
    

    [SerializeField] AirBar manager;

    [SerializeField] Text text;

   [SerializeField] Image image;
    
    private void Awake()
    {
        image = GetComponent<Image>();
        manager.OnScoreChanged.AddListener(UpdateStatusBar);
        UpdateStatusBar(0);
    }

    private void UpdateStatusBar(int increase) 
    {
        image.fillAmount = Mathf.Clamp((float)manager.Score / (float)maxScore, 0.05f, 1);
        text.text = "Air: " + manager.Score;
    }
}
