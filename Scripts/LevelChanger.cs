using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int LevelToLoad;

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(1)) {
            FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1); 
        }  
    }

    public void FadeToLevel(int index) {
        LevelToLoad = index;    
        animator.SetTrigger("FadeOut");

    }

    public void OnFadeComplete() {
        SceneManager.LoadScene(LevelToLoad);
    }
}
