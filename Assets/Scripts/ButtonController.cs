using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public Animation anim;

    private void Start()
    {
        Animation anim = GetComponent<Animation>();
    }

    public void MainToArchive()
    {
        anim.Play("ButtonHideRight");
    }

    public void ArchiveToMain()
    {
        anim.Play("ButtonShowRight");
    }
}
