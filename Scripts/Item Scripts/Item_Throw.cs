using UnityEngine;
using System.Collections;

namespace S1
{
	public class Item_Throw : MonoBehaviour {
		
		private Item_Master itemMaster;
		private Transform myTransform;
		private Rigidbody myRigidBody;
		private Vector3 throwDirection;

		public bool canBeThrown;
		public string throwButtonName;
		public float throwForce;

		// Use this for initialization
		void Start () {
			SetInitialReferences ();
		}
		
		// Update is called once per frame
		void Update () {

			CheckForThrowInput ();
		}

		void SetInitialReferences() {

			itemMaster = GetComponent<Item_Master> ();
			myTransform = transform;
			myRigidBody = GetComponent<Rigidbody> ();

		}

		void CheckForThrowInput(){

			if (throwButtonName != null) {
				if (Input.GetButtonDown (throwButtonName) && Time.timeScale > 0 && canBeThrown &&
				    myTransform.root.CompareTag (GameManager_References._playerTag)) {

					Debug.Log ("Throw Button Pressed");
					CarryOutThrowActions ();
				}
			}

		}

		void CarryOutThrowActions(){

			throwDirection = myTransform.parent.forward;
			//separate child from parent
			myTransform.parent = null;
			itemMaster.CallEventObjectThrow ();
			Debug.Log ("Ready to throw Item");
			HurlItem ();

		}

		void HurlItem(){

			myRigidBody.AddForce (throwDirection * throwForce, ForceMode.Impulse);
			Debug.Log ("Threw Item");

		}
	}
}
