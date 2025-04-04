using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{   
    public Animator transition;
    public float transitionTime = 1f;
    public Button myButton;
    
    /*// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextScene();
        }
    }*/

    void Start()
    {
        myButton.onClick.AddListener(LoadNextScene);
    }

    public void LoadNextScene()
    {   
        // Load the next scene in the scene order
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    
    //Coroutine
    IEnumerator LoadScene(int sceneIndex)
    {
        // Play animation
        transition.SetTrigger("Start");
        
        //Wait for animation
        yield return new WaitForSeconds(transitionTime);
        
        //Load scene
        SceneManager.LoadScene(sceneIndex);
    }
}
