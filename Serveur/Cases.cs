using System;

public class Cases
{
    private Boolean peutEtreEcraser;
    private int posX, posY;

    public Cases (int x, int y)
    {
        this.peutEtreEcraser = new Boolean();
        this.posX = x;
        this.posY = y;
    }

    public int X
    {
        get { return posX; }
        set { posX = value; }
    }

    public int Y
    {
        get { return posY; }
        set { posY = value; }
    }

    public Boolean PeutEtreEcraser
    {
        get { return peutEtreEcraser; }
        set { peutEtreEcraser = value; }
    }

}
