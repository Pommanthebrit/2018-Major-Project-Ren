using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public bool paused = false;

    [SerializeField]
    GameObject pauseMenu;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true) {
                Resume();
            } else {
                Pause();
            }
        }
       
	}
    public void Resume() {
        paused = false;
        pauseMenu.SetActive(true);
    }

    public void Pause() {
        paused = true;
        pauseMenu.SetActive(false);

    }
}
