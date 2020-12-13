using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
    public Animation anim;
    public GameObject BackButton;
    // public GameObjects

    private void Start()
    {
        // Animation anim = GetComponent<Animation>();
        // BackButton = GameObject.Find("BackButton");
        // Debug.Log(BackButton.GetComponent<Animation>);
    }

    public void MainToArchive()
    {
        // anim.Play("BackButtonShow");
        anim.Play("FooterHide");
    }

    public void ArchiveToMain()
    {
        // anim.Play("BackButtonHide");
        anim.Play("FooterShow");
    }
}
