using UnityEngine;
using System.Collections;

public class BorderScript : MonoBehaviour {
    void OnTriggerExit()
    {
        Debug.Log("OUT OF BOUNDS");
    }
}
