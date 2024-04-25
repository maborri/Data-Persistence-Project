using UnityEngine;
using UnityEngine.UI;

public class GameUi : MonoBehaviour {
    public Text infoText;
    
    void Start() {
        if (NameManager.Instance != null) {
            infoText.text = "Best Score: " + NameManager.Instance.highscore.name + " : " + NameManager.Instance.highscore.value;
        }
    }
}
