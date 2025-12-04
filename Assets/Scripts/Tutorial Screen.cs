using Unity.VisualScripting;
using UnityEngine;

public class TutorialScreen : MonoBehaviour
{
   
        
        public GameObject startMenuUI; 

    void Start()
    {
        Time.timeScale = 0f;
        startMenuUI.SetActive(true); 
    }

    public void StartGame()
    {
       
        Time.timeScale = 1f; 
        startMenuUI.SetActive(false); 
    }

    

}

