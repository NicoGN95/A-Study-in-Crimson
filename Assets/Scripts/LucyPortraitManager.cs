using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers;

public class LucyPortraitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHappyPortrait()
    {
        PixelCrushers.DialogueSystem.DialogueManager.SetPortrait("???", "Arte/Lucy/MuyFeliz");
    }
}
