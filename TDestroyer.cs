using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TDestroyer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI BulletText;
    [SerializeField] TextMeshProUGUI DollarsTXT;
    [SerializeField] TextMeshProUGUI PlusTXT;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    static int bullet = 30;
    static int dlls = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        bullet -= 1;
        dlls += 100;
        BulletText.text = bullet + "";
        DollarsTXT.text = dlls + "$";
        PlusTXT.text = "+ 100$";
        if (bullet == 29){
            Destroy(Image5);
        }
        if (bullet == 28){
            Destroy(Image4);
        }
        if (bullet == 27){
            Destroy(Image3);
        }
        if (bullet == 26){
            Destroy(Image2);
        }
        if (bullet == 25){
            Destroy(Image1);
        }
        Destroy(gameObject);
    }
}
