using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField]
    private Transform _respawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            GameManager.Instance.lives -= 1;
            CharacterController cc = other.GetComponent<CharacterController>();
            if(cc!=null)
            {
                cc.enabled = false;
            }
            other.transform.position = _respawnPoint.transform.position;
            
            StartCoroutine(EnableCharacterControllerRoutine(cc));
        }
    }
    IEnumerator EnableCharacterControllerRoutine(CharacterController cc)
    {
        yield return new WaitForSeconds(0.1f);
        cc.enabled = true;
    }
}
