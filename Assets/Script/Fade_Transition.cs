using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade_Transition : MonoBehaviour
{
    public Animator animator;
    public GameObject chair;

    private bool ending = false;

    // Update is called once per frame
    void Update()
    {

        if (chair != null && chair.transform.position.y < -10)
        {
            FadeToScene();
            ending = true;
        } else if (SceneManager.GetActiveScene().name == "Ending" && Input.GetKeyDown(KeyCode.Space))
        {
            FadeToScene();
            ending = false;
        }
    }

    public void FadeToScene ()
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        if (ending)
        {
            SceneManager.LoadScene(1);
        } else {
            SceneManager.LoadScene(0);
        }
    }
}
