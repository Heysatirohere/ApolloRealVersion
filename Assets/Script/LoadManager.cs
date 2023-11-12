using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class LoadManager : MonoBehaviour
{
   
    public void Load(string scene)
    {
        SceneManager.LoadScene(scene);
       
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
