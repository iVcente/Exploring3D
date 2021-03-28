using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeight : MonoBehaviour {
    public Transform player;
    Text uiText;

    // Start is called before the first frame update
    void Start() {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        // Debug.Log(player.position.y);
        int height = Mathf.RoundToInt(player.position.y) - 1;
        uiText.text = height.ToString();
    }
}
