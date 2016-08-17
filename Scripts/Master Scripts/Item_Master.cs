using UnityEngine;
using System.Collections;

namespace S1
{
	public class Item_Master : MonoBehaviour {
		

		private Player_Master playerMaster;

		public delegate void GeneralEventHandler();
		public event GeneralEventHandler EventObjectThrow;
		public event GeneralEventHandler EventObjectPickup;

		public delegate void PickupActionEventHandler(Transform item);
		public event PickupActionEventHandler EventPickupAction;

		void OnEnable() {

			SetInitialReferences ();
		
		}

		void OnDisable() {
			
		
		}

		public void CallEventObjectThrow() {

			if (EventObjectThrow != null) {
				EventObjectThrow ();

			}
			playerMaster.CallEventHandsEmpty();
			playerMaster.CallEventInventoryChanged ();
		}

		public void CallEventObjectPickup(){

			if (EventObjectPickup != null) {
				EventObjectPickup ();

			}
			playerMaster.CallEventInventoryChanged ();
		}

		public void CallEventPickupAction(Transform item){

			if (EventPickupAction != null) {
				EventPickupAction (item);
			}
		}

		//give any item access to _player properties
		void SetInitialReferences() {

			if (GameManager_References._player != null) {
				playerMaster = GameManager_References._player.GetComponent<Player_Master> ();
			}
		
		}
	}
}
