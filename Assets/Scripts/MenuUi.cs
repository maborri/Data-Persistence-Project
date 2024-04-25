using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUi : MonoBehaviour {   
    public void OnNameChange(string newName) {
        NameManager.Instance.username = newName;
    }

    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
