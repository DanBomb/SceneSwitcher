using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	public void SceneSwitcherBlack () {

		SceneManager.LoadScene (1);
	}
	public void SceneSwitcherGreen () {

		SceneManager.LoadScene (2);
	}
	public void SceneSwitcherBlue () {

		SceneManager.LoadScene (0);
	}
}
