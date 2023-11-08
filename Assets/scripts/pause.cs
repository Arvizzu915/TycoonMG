using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    float timestop = 1f;
    [SerializeField] GameObject pauseText;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (timestop > 0f)
            {
                pauseText.SetActive(true);
                timestop = 0f;
            }
            else
            {
                pauseText.SetActive(false);
                timestop = 1f;
            }
            Time.timeScale = timestop;
        }
    }
}
