using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ButtonClick : MonoBehaviour,IPointerDownHandler {
    [SerializeField]
    private AudioClip _pressedClip;
    [SerializeField]
    private AudioSource _audioSource;
    int firstIndex = 0;
    int lastIndex;
    int buildIndex;

    void Start() {
        lastIndex = SceneManager.sceneCountInBuildSettings - 1;
    }

    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) {
        _audioSource.PlayOneShot(_pressedClip);
    }

    public void CustomOnClicked() {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        if (gameObject.name.Equals("left_arrow"))
        {
            if (buildIndex == 0)
            {
                SceneManager.LoadScene(lastIndex);
            }
            else
            {
                SceneManager.LoadScene(buildIndex - 1);
            }
        }
        else if (gameObject.name.Equals("right_arrow"))
        {
            if (buildIndex == lastIndex)
            {
                SceneManager.LoadScene(firstIndex);
            }
            else
            {
                SceneManager.LoadScene(buildIndex + 1);
            }
        }
    }
}
