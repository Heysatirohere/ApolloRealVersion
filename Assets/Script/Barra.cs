using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Barra : MonoBehaviour
{

    public Image barra;
    public string sceneToLoad;
    float timeBarra = 90;
    void Update()
    {
        if (timeBarra <= 0)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        timeBarra -= Time.deltaTime;
        barra.fillAmount = timeBarra / 90;
    }
}