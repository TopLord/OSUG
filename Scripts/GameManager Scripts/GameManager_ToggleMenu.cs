using UnityEngine;
using System.Collections;

namespace S1
{

	public class GameManager_ToggleMenu : MonoBehaviour {

		private GameManager_Master gameManagerMaster;
		public GameObject menu;

		// Use this for initialization
		void Start () {
			
		}
	
		// Update is called once per frame
		void Update () {
			CheckForMenuToggleRequest ();
		}

		void OnEnable() {
			SetInitialReferences ();
			//open a menu when its game over
			gameManagerMaster.GameOverEvent += ToggleMenu;
		}

		void OnDisable() {
			gameManagerMaster.GameOverEvent -= ToggleMenu;
		}

		void SetInitialReferences(){
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void CheckForMenuToggleRequest(){
			if (Input.GetKeyUp (KeyCode.Escape) && !gameManagerMaster.isGameOver && !gameManagerMaster.isInventoryUIOn) {
				ToggleMenu ();
			}
		}

		void ToggleMenu(){
			if (menu != null) {
				//activate a disabled game object
				menu.SetActive (!menu.activeSelf);
				gameManagerMaster.isMenuOn = !gameManagerMaster.isMenuOn;
				gameManagerMaster.CallEventMenuToggle ();
			} else {
				Debug.LogWarning ("You need to assign a UI GameObject to the Toggle Menu script in the inspector!");
			}
		}
	}//end class
}//end namespace