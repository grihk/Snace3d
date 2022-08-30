using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
    public float delay = 3;
    

    public string levelName;
    public IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
        


    }
     
            
                
}

