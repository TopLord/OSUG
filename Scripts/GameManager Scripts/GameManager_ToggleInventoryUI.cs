using UnityEngine;
using System.Collections;

namespace S1
{
	public class GameManager_ToggleInventoryUI : MonoBehaviour {

		[Tooltip("If this game uses an invetory set to true")]
		public bool hasInventory;
		public GameObject inventoryUI;
		public string toggleInventoryButton;

		private GameManager_Master gameManagerMaster;

		// Use this for initialization
		void Start () {
			SetInitialReferences ();
		}

		// Update is called once per frame
		void Update () {
			CheckForInventoryToggleRequest ();
		}

		void SetInitialReferences(){
			gameManagerMaster = GetComponent<GameManager_Master> ();

			if (toggleInventoryButton == "") {
				Debug.LogWarning ("Please type in Inventory button toggle name in inspector");
				this.enabled = false;
			}
		}

		void CheckForInventoryToggleRequest() {
			if (Input.GetButtonUp(toggleInventoryButton) && !gameManagerMaster.isMenuOn && !gameManagerMaster.isGameOver
			   && hasInventory) {
				ToggleInventoryUI ();
			}
		}

		public void ToggleInventoryUI() {
			if (inventoryUI != null) {
				//set current state to opposite of current state
				Debug.Log ("i Button Pressed");
				inventoryUI.SetActive (!inventoryUI.activeSelf);
				gameManagerMaster.isInventoryUIOn = !gameManagerMaster.isInventoryUIOn;
				gameManagerMaster.CallInventoryToggle();

			}
		}
	}


}