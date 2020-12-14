using UnityEngine;
using System.Collections;

public class FooterAnimationController : MonoBehaviour
{
    public Animation anim;

    private void Start()
    {
        Animation anim = GetComponent<Animation>();
    }

    public void MainToArchive()
    {
        anim.Play("FooterHide");
    }

    public void ArchiveToMain()
    {
        anim.Play("FooterShow");
    }
}
