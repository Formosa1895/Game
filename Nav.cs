using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Characters.ThirdPerson
{
public class nav : MonoBehaviour {
	public Transform aa;
	public NavMeshAgent Nav{ get; private set; }
	public int attackRange= 100;
	public float attackangle=90.0f;
	public Transform target;
	bool die;
	public Collider player;
	RaycastHit hit;
	Animator anim;
	public GUISkin skin;
	public ThirdPersonCharacter character { get; private set; }
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
			Nav = GetComponentInChildren<NavMeshAgent>();
			character = GetComponent<ThirdPersonCharacter>();
	}
	
	// Update is called once per frame
	void Update () {
			print (CanSeeTarget ());
		if (CanSeeTarget ()) {
				Nav.destination = aa.position;
				character.Move (Nav.desiredVelocity, false, false);

			}
		if(!CanSeeTarget())
			{
				character.Move(Vector3.zero, false, false);

			}
	}
	bool CanSeeTarget (){
		if (Vector3.Distance (transform.position, target.position) > attackRange)
			return false;

			

		Vector3 targetdir = target.position - transform.position;
		if (Physics.Linecast (transform.position, target.position, out hit)) {
				if ((Vector3.Angle (transform.forward, targetdir) < attackangle))
				{
					return hit.transform == target;
				}
			}

		return false;
	}

		void OnGUI()
		{

			if (CanSeeTarget ()) {
				GUI.Box (new Rect (Screen.width / 2, 10, 120, 60), "");
				GUI.Label (new Rect (Screen.width / 2, 10, 120, 60), "你被鄉民發現惹！");
			}
			if (die == true) {
				Application.LoadLevel(1);
			}
		}
		void OnTriggerEnter(Collider other)
		{
			if (other == player)
				die = true;
		}
	
		}
}