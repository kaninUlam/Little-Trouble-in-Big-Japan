using UnityEngine;
using System.Collections;

public class GunRayCast : MonoBehaviour
{
	public float DamageDealt = 50;

	public LayerMask layersChecked;

	public GameObject raycastOrigin;

	public float weaponRange = 100;




	public void raycastShoot()
	{
		Debug.Log("imGay");
		
		RaycastHit hit;
		Debug.DrawRay(raycastOrigin.transform.position, raycastOrigin.transform.forward, Color.green, 2000);
		if (Physics.Raycast(transform.position, transform.forward, out hit, 100, layersChecked))
		{
			Debug.Log(hit.collider.gameObject);
			if (hit.collider.tag == "Enemy")
			{
				Debug.Log("hit enemy");
				EnemyHealth enemyHP = hit.collider.gameObject.GetComponent<EnemyHealth>();
				Health healthComponent = hit.collider.gameObject.GetComponent<Health>();
				if (healthComponent != null)
				{
					Debug.Log(DamageDealt);
					
					healthComponent.takeDamage(DamageDealt);

				}

				if (enemyHP != null)
				{
					Debug.Log(DamageDealt);
					enemyHP.takeDamage(DamageDealt);
				}
			}
		}


	}
}