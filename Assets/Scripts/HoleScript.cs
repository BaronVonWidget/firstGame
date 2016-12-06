using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HoleScript : MonoBehaviour {

    public Text WinText;

    // Use this for initialization
    void Start () {
        WinText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            WinText.text = "YOU WIN!";
        }
    }
}
