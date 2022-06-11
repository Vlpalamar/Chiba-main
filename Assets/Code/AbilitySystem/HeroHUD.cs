using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

//спелл худ вешается в префаб игрока    
public class HeroHUD : NetworkBehaviour
{

    [SerializeField] private GameObject FullHud;
   // [SerializeField] private GameObject HeroPortret;
    [SerializeField] private Image _HeroPortret;
    [SerializeField] private Sprite[] sprites;






    private const string PlayerTag = "Player";
    private Animator anim;
    public List<Image> slotsIcone;
    public List<Image> reloadsIcone;
    private bool isOpen=false;
    protected CastSystem _castSystem;
    protected AbilityManager _abilityManager;
    protected Hero _hero;

    private void Start()
    {
        anim = GetComponent<Animator>(); 


    }
    public void SetPortret(int indx)
    {
       
        _HeroPortret = GameObject.Find("HeroPortret").GetComponent<Image>();
        print(sprites[indx].name);
        print("SetPortret");
        _HeroPortret.sprite = sprites[indx];
    }




    private void Update()
    {
        if (_castSystem)
            return;


        if (GameObject.FindGameObjectWithTag(PlayerTag))
            Init();
        
       
    }



    

    public void Active()
    {

        //FullHud.transform.position = new Vector3(FullHud.transform.position.x, 0, FullHud.transform.position.z);
    }

    public void OnOpenShopButtonClick()
    {
        isOpen = !isOpen;
        anim.SetBool("OpenShop", isOpen);
    }


    private void Init()
    {

        GameObject mainHero = GameObject.FindGameObjectWithTag(PlayerTag);
        _hero = mainHero.GetComponent<Hero>();
        _castSystem = mainHero.GetComponent<CastSystem>();
        _abilityManager= mainHero.GetComponent<AbilityManager>();
        for (int i = 0; i < _castSystem.Spells.Count; i++)
        {
            slotsIcone[i].sprite = _castSystem.Spells[i].Attribute.Icone;
        }
    }
}
