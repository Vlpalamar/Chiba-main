using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnim : MonoBehaviour
{
    [SerializeField] private float timeBetween;
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        StartCoroutine(ChangeAnims());
    }

    IEnumerator ChangeAnims()
    {
        _anim.Play("idle");
        yield return new WaitForSeconds(15);
        _anim.Play("spawn");
        yield return new  WaitForSeconds(timeBetween);
        _anim.Play("attack");
        yield return new WaitForSeconds(timeBetween);
        _anim.Play("run");
        yield return new WaitForSeconds(timeBetween);
        _anim.Play("die");
        yield return new WaitForSeconds(timeBetween);

        yield return null;
        


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
