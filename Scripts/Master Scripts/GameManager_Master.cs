using UnityEngine;
using System.Collections;
/// <summary>
/// Game manager master.
/// Acts as the main event listener for all GameManaer_* scripts
/// Events listen for calls from other scripts
/// </summary>
namespace S1
{
    public class GameManager_Master : MonoBehaviour
    {
        public delegate void GameManagerEventHandler();
        public event GameManagerEventHandler MenuToggleEvent;
        public event GameManagerEventHandler InventoryUIToggleEvent;
        public event GameManagerEventHandler RestartLevelEvent;
        public event GameManagerEventHandler GoToMenuSceneEvent;
        public event GameManagerEventHandler GameOverEvent;

		//set flags
		public bool isGameOver;
		public bool isInventoryUIOn;
		public bool isMenuOn;

		//Toggles the Main Menu on/off
		public void CallEventMenuToggle()
		{
			if (MenuToggleEvent != null) {
				MenuToggleEvent ();
			}
		}

		//Toggles the Inventory On/Off
		public void CallInventoryToggle() 
		{
			if (InventoryUIToggleEvent != null) {
				InventoryUIToggleEvent ();
			}
		}

		//Calls the restart level event
		public void CallRestartLevel() 
		{
			if (RestartLevelEvent != null) {
				RestartLevelEvent();
			}
		}


		public void CallGoToMenuScene() 
		{
			if (GoToMenuSceneEvent != null) {
				GoToMenuSceneEvent();
			}
		}
		public void CallGameOverEvent() 
		{
			if (GameOverEvent != null) {
				isGameOver = true;
				GameOverEvent();
			}
		}
    }//end class
}//end namespace