using System;

public class Joueur : Cases
{
    private String name;
    private int score;
    public Joueur(String s, int i, int j) : base(i, j)
    {
        PeutEtreEcraser = false;
        this.name = s;
        this.score = 0;
    }


    public String Name
    {
        get { return this.name;}
        set { this.name = value;}
    }

    public int Score
    {
        get { return this.score; }
        set { this.score = value; }
    }
}
