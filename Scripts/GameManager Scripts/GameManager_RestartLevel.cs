﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace S1
{
	public class GameManager_RestartLevel : MonoBehaviour {

		private GameManager_Master gameManagerMaster;

		void OnEnable(){
			SetInitialReferences ();
			gameManagerMaster.RestartLevelEvent += RestartLevel;
		}

		void OnDisable(){
			gameManagerMaster.RestartLevelEvent -= RestartLevel;
		}

		void SetInitialReferences(){
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void RestartLevel(){
			SceneManager.LoadScene ("Prototype");
		}


	}//end class
}
