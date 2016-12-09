using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HoleScript : MonoBehaviour {

    public Text WinText;
    public Image Background;
    public AudioClip HoleSound;
    public ParticleSystem Fireworks;

    private AudioSource source;

    // Use this for initialization
    void Start () {
        WinText.text = "";
        Background.gameObject.SetActive(false);
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            source.PlayOneShot(HoleSound, 1f);
            Background.gameObject.SetActive(true);
            WinText.text = "YOU WIN!";
        }
    }
}
