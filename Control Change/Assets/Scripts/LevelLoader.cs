using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public Animator anim;
    public float transitionTime;

    public void LoadNextLevel() {
        Debug.Log("Loading Next Level");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int index) {
        Debug.Log("Fading");
        anim.SetTrigger("fade");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(index);
    }
}