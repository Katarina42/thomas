using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGl : MonoBehaviour {

    
    
    public Material mat;
    //exit position
    public float x;
    public float y;
    public float width;
    public float height;

    public void OnPostRender()
    {
        DrawExit(x, y, width, height);
      
    }

    public void DrawExit(float x,float y,float width,float height)
    {
        GL.Begin(GL.LINE_STRIP);
        mat.SetPass(0);
        GL.Vertex3 (x, y, 0f);
        GL.Vertex3(x+width, y, 0f);
        GL.Vertex3(x+width, y+height, 0f);
        GL.Vertex3(x, y+height, 0f);
        GL.Vertex3(x, y, 0f);
        GL.End();

    }


    }
